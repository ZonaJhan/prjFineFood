using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjFineFoodCore.Models;
using prjFineFoodCore.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace prjFineFoodCore.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataBaseContext _context;

        private readonly IWebHostEnvironment _environment;

        public AdminController(DataBaseContext context, IWebHostEnvironment photo)
        {
            _context = context;
            _environment = photo;
        }


        public IActionResult MemberList()
        {
            var datas = _context.Members.Select(m => m);
            List<CMemberViewModel> list = new List<CMemberViewModel>();
            foreach (Member m in datas)
            {
                CMemberViewModel model = new CMemberViewModel() { member = m };
                list.Add(model);
            }
            return View(list);
        }

        public IActionResult CityList()
        {
            var datas = _context.Cities.Select(m => m);
            List<CAreaViewModel> list = new List<CAreaViewModel>();
            foreach (City c in datas)
            {
                CAreaViewModel model = new CAreaViewModel() { cities = c };
                list.Add(model);
            }
            return View(list);
        }

        public IActionResult FoodList()
        {
            var datas = _context.Foods.Select(f => f);
            List<CFoodViewModel> list = new List<CFoodViewModel>();
            foreach (Food f in datas)
            {
                CFoodViewModel model = new CFoodViewModel() { foods = f };
                list.Add(model);
            }
            return View(list);
        }
        public IActionResult FoodCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FoodCreate(CFoodViewModel vModel)
        {
            if (vModel.foodphoto != null)
            {
                string photoName = Guid.NewGuid().ToString() + ".jpg";
                vModel.Photo = photoName;
                vModel.foodphoto.CopyTo(new FileStream(_environment.WebRootPath + "/images/" + photoName, FileMode.Create));
            }
            _context.Foods.Add(vModel.foods);
            _context.SaveChanges();

            return RedirectToAction("FoodList");
        }

        public IActionResult FoodEdit(int? id)
        {
            if (id == null)
                return RedirectToAction("FoodList");
            Food food = _context.Foods.FirstOrDefault(f => f.FoodId == id);
            if(food == null)
                return RedirectToAction("FoodList");

            CFoodViewModel model = new CFoodViewModel();
            model.foods = food;
            return View(model);
        }
        [HttpPost]
        public IActionResult FoodEdit(CFoodViewModel vModel)
        {
            Food food = _context.Foods.FirstOrDefault(f => f.FoodId == vModel.FoodId);
            if (food != null)
            {
                if (vModel.foodphoto != null)
                {
                    string photoName = Guid.NewGuid().ToString() + ".jpg";
                    food.Photo = photoName;
                    vModel.foodphoto.CopyTo(new FileStream(_environment.WebRootPath + "/images/Foods/" + photoName, FileMode.Create));
                }
                food.RestaurantId = vModel.RestaurantId;
                food.FoodName = vModel.FoodName;
                food.Price = vModel.Price;
                food.Available = vModel.Available;
                _context.SaveChanges();
            }
            return RedirectToAction("FoodList");
        }

        public IActionResult FoodDelete(int? id)
        {
            if (id != null)
            {
                Food food = _context.Foods.FirstOrDefault(f => f.FoodId == id);
                if (food != null)
                {
                    _context.Foods.Remove(food);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("FoodList");
        }

        public IActionResult RestaurantList()
        {
            var datas = _context.Restaurants.Select(r => r);
            List<CRestaurantViewModel> list = new List<CRestaurantViewModel>();
            foreach (Restaurant r in datas)
            {
                CRestaurantViewModel model = new CRestaurantViewModel() { restaurants = r };
                list.Add(model);
            }
            return View(list);
        }

        public IActionResult RestaurantEdit(int? id)
        {
            if (id == null)
                return RedirectToAction("RestaurantList");
            Restaurant rest = _context.Restaurants.FirstOrDefault(r => r.RestaurantId == id);
            if (rest == null)
                return RedirectToAction("RestaurantList");
            CRestaurantViewModel model = new CRestaurantViewModel();
            model.restaurants = rest;
            return View(model);
        }
        [HttpPost]
        public IActionResult RestaurantEdit(CRestaurantViewModel vModel)
        {
            Restaurant rest = _context.Restaurants.FirstOrDefault(r => r.RestaurantId == vModel.RestaurantId);
            if (rest != null)
            {
                if (vModel.Photo != null)
                {
                    string photoName = Guid.NewGuid().ToString() + ".jpg";
                    rest.Photos = photoName;
                    vModel.Photo.CopyTo(new FileStream(_environment.WebRootPath + "/Images/Restaurants/" + photoName, FileMode.Create));
                }
                rest.RestaurantAccount = vModel.RestaurantAccount;
                rest.Password = vModel.Password;
                rest.ZipCode = vModel.ZipCode;
                rest.RestaurantName = vModel.RestaurantName;
                rest.Address = vModel.Address;
                rest.PhoneNumber = vModel.PhoneNumber;
                rest.Description = vModel.Description;
                rest.WeekDayOff = vModel.WeekDayOff;
                rest.OpenTime = vModel.OpenTime;
                rest.CloseTime = vModel.CloseTime;
                rest.Latitude = vModel.Latitude;
                rest.Longitude = vModel.Longitude;
                rest.OrderAvailable = vModel.OrderAvailable;
                rest.RegistrationDate = vModel.RegistrationDate;
                rest.Activited = vModel.Activited;


                _context.SaveChanges();
            }
            return RedirectToAction("RestaurantList");
        }
    }
}
