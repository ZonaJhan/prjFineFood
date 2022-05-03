using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prjFineFoodCore.Models;
using prjFineFoodCore.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace prjFineFoodCore.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly DataBaseContext _context;

        public HomeController(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()    //By Josh
        {
            var cidatas = _context.Cities.OrderByDescending(c => c.CityId).ToList();
            List<CAreaViewModel> list = new List<CAreaViewModel>();
            foreach (City c in cidatas)
            {
                CAreaViewModel model = new CAreaViewModel() { cities = c };
                list.Add(model);
            }
            var redatas = _context.Regions.OrderByDescending(r => r.ZipCode).ToList();
            foreach (Region r in redatas)
            {
                CAreaViewModel model = new CAreaViewModel() { region = r };
                list.Add(model);
            }

            return View(list);
        }

        public IActionResult Intro()
        {
            return View();
        }

        public IActionResult NewView()
        {
            return View();
        }

        public IActionResult Bubble()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
