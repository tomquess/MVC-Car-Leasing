using Microsoft.AspNetCore.Http;
using ASP_NET_Project.Data;
using ASP_NET_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        // GET: CarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            _db.Cars.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Delete/5
       // public ActionResult Delete(int id)
       // {
        //    return View();
        ////}

        // POST: CarController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(Car obj,int id, IFormCollection collection)
        //{
        //    _db.Cars.Remove(obj);
        //    _db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
