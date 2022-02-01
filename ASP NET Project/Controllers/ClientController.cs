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
    public class ClientController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ClientController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: CarController
        public ActionResult Index()
        {
            IEnumerable<Client> clientList = _db.Clients;
            return View(clientList);
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
        public IActionResult Create(Client obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Add(obj);
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
            var obj = _db.Clients.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //post delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Clients.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Clients.Remove(obj);
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
            var obj = _db.Clients.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //post update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Client obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    }
}