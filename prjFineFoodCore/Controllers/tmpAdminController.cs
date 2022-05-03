using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjFineFoodCore.Controllers
{
    public class tmpAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MessageBoard()    //MessageBoard
        {
            return View();
        }
        


        public IActionResult Error()    //404
        {
            return View();
        }

        public IActionResult Blank()    //blank
        {
            return View();
        }

        public IActionResult Buttons()    //buttons
        {
            return View();
        }
        public IActionResult Cards()    //cards
        {
            return View();
        }
        public IActionResult Charts()    //charts
        {
            return View();
        }

        public IActionResult ForgotPassword()    //forgot-password
        {
            return View();
        }
        public IActionResult Login()    //login
        {
            return View();
        }
        public IActionResult Register()    //register
        {
            return View();
        }
        public IActionResult Tables()    //tables
        {
            return View();
        }
        public IActionResult UtilitiesAnimation()    //utilities-animation
        {
            return View();
        }
        public IActionResult UtilitiesBorder()    //utilities-border
        {
            return View();
        }
        public IActionResult UtilitiesColor()    //utilities-color
        {
            return View();
        }
        public IActionResult UtilitiesOther()    //utilities-other
        {
            return View();
        }
    }
}
