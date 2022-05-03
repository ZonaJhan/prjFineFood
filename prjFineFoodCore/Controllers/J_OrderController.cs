using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjFineFoodCore.Models;
using prjFineFoodCore.ViewModels;
using prjMVCCoreClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjFineFoodCore.Controllers
{
    public class OrderController : Controller
    {
        private readonly DataBaseContext _context;


        public OrderController(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Checkout()
        {
            List<CShoppingCartItem> cart = new List<CShoppingCartItem>();
            string json = "";
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_PURCHASED_FOODS))
            {
                json = HttpContext.Session.GetString(CDictionary.SK_PURCHASED_FOODS);
                cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(json);
            }
            else
                return RedirectToAction("CartView");

            return View(cart);
        }

        public IActionResult CreateOrder()
        {
            //string json = HttpContext.Session.GetString(CDictionary.SK_PURCHASED_FOODS);
            //List<CShoppingCartItem> cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(json);

            //Order order = new Order();
            //order.OrderDate = DateTime.Now.ToString();
            //order.MemberId = 1;
            //order.RestaurantId = (int)HttpContext.Session.GetInt32(CDictionary.SK_RESTAURANTID);



            //HttpContext.Session.SetString(CDictionary.SK_PURCHASED_FOODS, "");
            return View();
        }

        public IActionResult ReviewOrder()
        {
            return View();
        }


    }
}
