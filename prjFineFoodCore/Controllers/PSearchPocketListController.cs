using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjFineFoodCore.Controllers
{
    public class PSearchPocketListController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
    }
}
