using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simpleCRUD.Data;
using simpleCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleCRUD.Areas.admin.Controllers
{
    [Area("admin")]
    public class EmployeeController : Controller
    {
        private AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Position = _context.Positions.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            _context.Employees.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int? id)
        {
            ViewBag.Position = _context.Positions.ToList();
            Employee employee = _context.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee model)
        {
            _context.Employees.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int? id)
        {
            Employee employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
