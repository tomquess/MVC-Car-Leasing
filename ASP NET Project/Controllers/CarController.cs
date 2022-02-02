/*using Microsoft.AspNetCore.Http;
using ASP_NET_Project.Data;
using ASP_NET_Project.Models;
using static ASP_NET_Project.Helper;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace ASP_NET_Project.Controllers
{
    public class CarController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CarController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: CarController
        public async Task<ActionResult> Index()
        {
            //IEnumerable<Car> carList = _db.Cars;
            return View(await _db.Cars.ToListAsync());
        }


        // GET: CarController/Create
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            return View(await _db.Cars.ToListAsync());
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Car obj)
        {   if (ModelState.IsValid)
            {
                _db.Cars.Add(obj);
                await _db.SaveChangesAsync();

                return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewTable", _db.Cars.ToList())});
            }
            return View(obj);
        }
        //get delete
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Cars.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //post delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize]
        public async Task<ActionResult> DeletePost(int? id)
        {
            var obj = _db.Cars.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Cars.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //get update
        public async Task<ActionResult> Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = await _db.Cars.FindAsync(id);
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
        public async Task<IActionResult> Update(int? id, Car obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                _db.Cars.Update(obj);
                await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
*//*                    if(!ObjExists(obj.Id))
                    //if()
                    {*//*
                        return NotFound();
*//*                    } else
                    {
                        throw;
                    }*//*
                }
                //return RedirectToAction("Index");
            }
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewTable", _db.Cars.ToList()) });
        }


        *//*        private bool ObjExists (Car obj)
                {
                    return _db.Cars.Any(e =>
                    {
                        return e.Id == obj;
                    });
                }*//*

    }
}
*/
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

namespace ASP_NET_Project.Controllers
{
    public class CarController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CarController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: CarController
        public ActionResult Index()
        {
            IEnumerable<Car> carList = _db.Cars;
            return View(carList);
        }


        // GET: CarController/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car obj)
        {
            //tutaj trzeba dodać try-catch który będzie zwracał wartości to jest waildacja form i jest potrzebna na 3 catch (DbUpdateConcurrencyException)
            if (ModelState.IsValid)
            {
                _db.Cars.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //get delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Cars.Find(id);
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
            var obj = _db.Cars.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Cars.Remove(obj);
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
            var obj = _db.Cars.Find(id);
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
        public IActionResult Update(Car obj)
        {
            if (ModelState.IsValid)
            {
                _db.Cars.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    }
}