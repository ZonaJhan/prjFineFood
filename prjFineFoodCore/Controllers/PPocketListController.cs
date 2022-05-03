using Microsoft.AspNetCore.Mvc;
using prjFineFoodCore.Models;
using prjFineFoodCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjFineFoodCore.Controllers
{
    public class PPocketListController : Controller
    {
        private readonly DataBaseContext _context;
        public PPocketListController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult PocketList()
        {
            var datas = _context.PocketLists.Where(m => m.MemberId == 2).ToList();
            //var data = _context.Members.Where(c => c.MemberId == 2).ToList();
            List<CPocketListViewModels> list = new List<CPocketListViewModels>();
            CPocketListViewModels model;
            foreach (PocketList q in datas)
            {
                model = new CPocketListViewModels() { pocket = q };
                list.Add(model);
            }
            return View(list);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("PocketList");
            var cust = _context.PocketLists.FirstOrDefault(c => c.PocketListId == id);
            if (cust == null)
                return RedirectToAction("PocketList");
            return View(cust);
        }
        [HttpPost]
        public IActionResult Edit(PocketList editPocketList)
        {
            var pock = _context.PocketLists.FirstOrDefault(c => c.PocketListId == editPocketList.PocketListId);
            if (pock != null)
            {
                pock.MemberId = editPocketList.MemberId;
                pock.PocketListName = editPocketList.PocketListName;
                pock.IsPublic = editPocketList.IsPublic;                
                _context.SaveChanges();
            }
            return RedirectToAction("PocketList");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PocketList pocket)
        {
            _context.Add(pocket);
            _context.SaveChanges();
            return RedirectToAction("PocketList");
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                PocketList poList = _context.PocketLists.FirstOrDefault(c => c.PocketListId == id);
                if (poList != null)
                {
                    _context.PocketLists.Remove(poList);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("PocketList");
        }
        public IActionResult Detail(/*int? id*/)
        {
            //if (id == null)
            //    return RedirectToAction("PocketList");
            //var cust = _context.PocketListDetails.Where(c => c.PocketListId == id && c.PocketList.MemberId == 2);
            //if (cust == null)
            //    return RedirectToAction("PocketList");
            return View(/*cust*/);
        }
    }
}
