using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjFineFoodCore.Models;
using prjFineFoodCore.ViewModel;
using prjMVCCoreClass.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace prjFineFoodCore.Controllers
{
    public class PlaceOrder : Controller
    {
        private readonly DataBaseContext _context;

        public PlaceOrder(DataBaseContext context)
        {
            _context = context;
        }


        public IActionResult Restaurant()
        {
            var datas = _context.Restaurants.Select(r => r).ToList();
            List<CRestaurantViewModel> list = new List<CRestaurantViewModel>();
            foreach (Restaurant r in datas)
            {
                CRestaurantViewModel model = new CRestaurantViewModel() { restaurants = r };
                list.Add(model);
            }
            return View(list);
        }

        public IActionResult RestaurantMenu(int? id)
        {
            if (id != null)
                HttpContext.Session.SetInt32(CDictionary.SK_RESTAURANTID, (int)id);

                
            var rdatas = _context.Restaurants.FirstOrDefault(r => r.RestaurantId == id);
            ViewBag.RestaurantName = rdatas.RestaurantName;
            ViewBag.RestaurantAddress = rdatas.Address;
            ViewBag.RestaurantPhone = rdatas.PhoneNumber;

            var fdatas = _context.Foods.Where(f => f.RestaurantId == id);
            List<CFoodViewModel> list = new List<CFoodViewModel>();
            foreach (Food f in fdatas)
            {
                CFoodViewModel model = new CFoodViewModel() { foods = f };
                list.Add(model);
            }
            return View(list);
        }
        public IActionResult AddToCart(int? id)
        {
            if (id == null)
                return RedirectToAction("RestaurantMenu");
            ViewBag.RestId = (int)HttpContext.Session.GetInt32(CDictionary.SK_RESTAURANTID);
            ViewBag.Fid = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart(CAddToCartViewModel vModel)
        {
            int fId = (int)HttpContext.Session.GetInt32(CDictionary.SK_RESTAURANTID);
            Food food = _context.Foods.FirstOrDefault(f => f.FoodId == vModel.txtFoodId);
            if(food == null)
                return RedirectToAction("RestaurantMenu", new { id = fId });

            List<CShoppingCartItem> cart = null;
            string json = "";
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_PURCHASED_FOODS))
            {
                json = HttpContext.Session.GetString(CDictionary.SK_PURCHASED_FOODS);
                cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(json);
            }
            else
                cart = new List<CShoppingCartItem>();

            int index = cart.FindIndex(f => f.foodId.Equals(vModel.txtFoodId));
            if (index != -1)
            {
                cart[index].count += vModel.txtCount;
            }
            else
            {
                CShoppingCartItem item = new CShoppingCartItem()
                {
                    count = vModel.txtCount,
                    price = (decimal)food.Price,
                    foodId = vModel.txtFoodId,
                    food = food
                };
                cart.Add(item);
            }

            json = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString(CDictionary.SK_PURCHASED_FOODS, json);

            return RedirectToAction("RestaurantMenu", new { id = fId });
        }

        public IActionResult CartView()
        {
            int fId = (int)HttpContext.Session.GetInt32(CDictionary.SK_RESTAURANTID);
            ViewBag.RestId = fId;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_PURCHASED_FOODS))
                return RedirectToAction("RestaurantMenu", new { id = fId });
            string json = HttpContext.Session.GetString(CDictionary.SK_PURCHASED_FOODS);
            List<CShoppingCartItem> cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(json);
            return View(cart);
        }
        public IActionResult CartViewDelete(int? id)
        {
            string json = HttpContext.Session.GetString(CDictionary.SK_PURCHASED_FOODS);
            List<CShoppingCartItem> cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(json);

            int index = cart.FindIndex(f => f.foodId.Equals(id));
            cart.RemoveAt(index);

            json = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString(CDictionary.SK_PURCHASED_FOODS, json);
            return RedirectToAction("CartView");
        }

    }
}
