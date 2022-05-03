using Microsoft.AspNetCore.Mvc;
using prjFineFoodCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjFineFoodCore.Controllers
{
    public class ZController : Controller
    {
        private readonly DataBaseContext _context;
        public ZController(DataBaseContext context)
        {
            _context = context;
        }
        //==============================Index Page=======================================
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult City()
        {
            var cities = _context.Cities.Select(c => new { c.City1 }).Distinct().OrderBy(c => c.City1);
            return Json(cities);
        }
        public IActionResult Districts(string city)
        {
            var districts = _context.Regions.Where(a => a.City.City1 == city).Select(a => new { a.AdminDisct }).Distinct().OrderBy(a => a.AdminDisct);
            return Json(districts);
        }
        public IActionResult RType()
        {
            var RType = _context.RestaurantTypes.Select(r => new { r.Types }).Distinct().OrderBy(r => r.Types);
            return Json(RType);

        }
        public IActionResult DType(string RType)
        {
            var DType = _context.RestaurantSubtypes.Where(dt => dt.RestaurantType.Types == RType).Select(dt => new { dt.RestaurantSubtype1 }).Distinct().OrderBy(dt => dt.RestaurantSubtype1);
            return Json(DType);
        }

        public IActionResult Restaurant()
        {
            var restaurant = _context.Restaurants.Select(c => new { c.RestaurantName }).Distinct().OrderBy(c => c.RestaurantName);
            return Json(restaurant);
        }

        public IActionResult RestaurantSearch(string city, string dis)
        {
            var restaurant = (from r in _context.Restaurants
                              join re in _context.Regions on r.ZipCode equals re.ZipCode
                              join c in _context.Cities on re.CityId equals c.CityId
                              //join tr in _context.TypeReferences on r.RestaurantId equals tr.RestaurantId
                              //join rs in _context.RestaurantSubtypes on tr.RestaurantSubtypeId equals rs.RestaurantSubtypeId
                              //join rt in _context.RestaurantTypes on rs.RestaurantTypeId equals rt.RestaurantTypeId
                              where c.City1 == city &&
                              re.AdminDisct == dis
                              select new { r.RestaurantName }).Distinct();
            return Json(restaurant);
        }
        public IActionResult cndNrndRSearch(string city, string dis, string RType, string Dtype)
        {
            var restaurant = (from r in _context.Restaurants
                              join re in _context.Regions on r.ZipCode equals re.ZipCode
                              join c in _context.Cities on re.CityId equals c.CityId
                              join tr in _context.TypeReferences on r.RestaurantId equals tr.RestaurantId
                              join rs in _context.RestaurantSubtypes on tr.RestaurantSubtypeId equals rs.RestaurantSubtypeId
                              join rt in _context.RestaurantTypes on rs.RestaurantTypeId equals rt.RestaurantTypeId
                              where c.City1 == city &&
                              re.AdminDisct == dis &&
                              rs.RestaurantSubtype1 == Dtype &&
                              rs.RestaurantType.Types == RType
                              select new { r.RestaurantName }).Distinct();
            return Json(restaurant);
        }
        public IActionResult cndNrRSearch(string city, string dis, string RType)
        {
            var restaurant = (from r in _context.Restaurants
                              join re in _context.Regions on r.ZipCode equals re.ZipCode
                              join c in _context.Cities on re.CityId equals c.CityId
                              join tr in _context.TypeReferences on r.RestaurantId equals tr.RestaurantId
                              join rs in _context.RestaurantSubtypes on tr.RestaurantSubtypeId equals rs.RestaurantSubtypeId
                              where c.City1 == city &&
                              re.AdminDisct == dis &&
                              rs.RestaurantType.Types == RType
                              select new { r.RestaurantName }).Distinct();
            return Json(restaurant);
        }
        public IActionResult RnDTypeSearch(string RType, string DType)
        {
            var restaurant = (from r in _context.Restaurants
                              join re in _context.Regions on r.ZipCode equals re.ZipCode
                              join c in _context.Cities on re.CityId equals c.CityId
                              join tr in _context.TypeReferences on r.RestaurantId equals tr.RestaurantId
                              join rs in _context.RestaurantSubtypes on tr.RestaurantSubtypeId equals rs.RestaurantSubtypeId
                              where rs.RestaurantType.Types == RType &&
                              rs.RestaurantSubtype1 == DType
                              select new { r.RestaurantName }).Distinct();
            return Json(restaurant);
        }
        public IActionResult RTypeRSearch(string RType)
        {
            var restaurant = (from r in _context.Restaurants
                              join re in _context.Regions on r.ZipCode equals re.ZipCode
                              join c in _context.Cities on re.CityId equals c.CityId
                              join tr in _context.TypeReferences on r.RestaurantId equals tr.RestaurantId
                              join rs in _context.RestaurantSubtypes on tr.RestaurantSubtypeId equals rs.RestaurantSubtypeId
                              where rs.RestaurantType.Types == RType
                              select new { r.RestaurantName }).Distinct();
            return Json(restaurant);
        }
        public IActionResult cNrndRSearch(string city, string RType, string DType)
        {
            var restaurant = (from r in _context.Restaurants
                              join re in _context.Regions on r.ZipCode equals re.ZipCode
                              join c in _context.Cities on re.CityId equals c.CityId
                              join tr in _context.TypeReferences on r.RestaurantId equals tr.RestaurantId
                              join rs in _context.RestaurantSubtypes on tr.RestaurantSubtypeId equals rs.RestaurantSubtypeId
                              where c.City1 == city &&
                              rs.RestaurantSubtype1 == DType &&
                              rs.RestaurantType.Types == RType
                              select new { r.RestaurantName }).Distinct();
            return Json(restaurant);
        }

        public IActionResult cNrSearch(string city, string RType)
        {
            var restaurant = (from r in _context.Restaurants
                              join re in _context.Regions on r.ZipCode equals re.ZipCode
                              join c in _context.Cities on re.CityId equals c.CityId
                              join tr in _context.TypeReferences on r.RestaurantId equals tr.RestaurantId
                              join rs in _context.RestaurantSubtypes on tr.RestaurantSubtypeId equals rs.RestaurantSubtypeId
                              where c.City1 == city &&
                              rs.RestaurantType.Types == RType
                              select new { r.RestaurantName }).Distinct();
            return Json(restaurant);
        }
        public IActionResult cSearch(string city)
        {
            var restaurant = (from r in _context.Restaurants
                              join re in _context.Regions on r.ZipCode equals re.ZipCode
                              join c in _context.Cities on re.CityId equals c.CityId
                              where c.City1 == city
                              select new { r.RestaurantName }).Distinct();
            return Json(restaurant);
        }
        //==============================cards=============================================
        //public IActionResult RestaurantCard() 
        //{
        //    var restaurantCard
        //    return Json(restaurantCard);
        //}

        //==============================admin LogIn=======================================
        public IActionResult adminLogin()
        {
            return View();

        }

    }
}
