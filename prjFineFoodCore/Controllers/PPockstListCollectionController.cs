using Microsoft.AspNetCore.Mvc;
using prjFineFoodCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjFineFoodCore.Controllers
{
    public class PPockstListCollectionController : Controller
    {
        private readonly DataBaseContext _context;
        public PPockstListCollectionController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            var datas = _context.PocketListActions.Where(m => m.MemberId == 2 && m.ActionId == 1).ToList();
            //var data = _context.Members.Where(c => c.MemberId == 2).ToList();
            List<PocketListAction> list = new List<PocketListAction>();
            //CPocketListViewModels model;
            //foreach (PocketList q in datas)
            //{
            //    model = new CPocketListViewModels() { pocket = q };
            //    list.Add(model);
            //}
            return View(datas);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
