using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThirdPartyPolicy.Data;
using ThirdPartyPolicy.Models;

namespace ThirdPartyPolicy.Controllers
{
    public class PolicyController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PolicyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Policy> ObjList = _db.Policies;
            return View(ObjList);
        }

        //GET - CREATE
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Policy policy)
        {
            if (ModelState.IsValid)
            {
                _db.Policies.Add(policy);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(policy);
        }

        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Policies.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Policy policy)
        {
            if (ModelState.IsValid)
            {
                _db.Policies.Update(policy);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(policy);
        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Policies.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var policy = _db.Policies.Find(id);
            if (policy == null)
            {
                return NotFound();
            }
            
                _db.Policies.Remove(policy);
                _db.SaveChanges();
                return RedirectToAction("Index");
            
            return View(policy);
        }
    }
}
