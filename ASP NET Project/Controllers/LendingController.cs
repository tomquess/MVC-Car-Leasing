using Microsoft.AspNetCore.Http;
using ASP_NET_Project.Data;
using ASP_NET_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP_NET_Project.Controllers
{
    [Authorize]
    public class LendingController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LendingController(ApplicationDbContext db)
        {
            _db = db;
        }
        


        // GET: LendingController
        public ActionResult Index()
        {
            IEnumerable<Lending> LendingList = _db.Lendings;
            return View(LendingList);
        }


        // GET: LendingController/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



        // POST: LendingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Lending obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Lendings.Add(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(obj);
            }
            catch
            {
                return RedirectToAction("CreateError");
            }
            
        }

        //error dla create
        public IActionResult CreateError()
        {
            return View();
        }

        //get delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Lendings.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //post delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Lendings.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Lendings.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //get update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Lendings.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //post update
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize]
        public IActionResult Update(Lending obj)
        {
            if (ModelState.IsValid)
            {
                _db.Lendings.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    }
}
