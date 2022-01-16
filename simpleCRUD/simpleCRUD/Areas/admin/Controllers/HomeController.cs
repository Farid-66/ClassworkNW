using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simpleCRUD.Data;
using simpleCRUD.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleCRUD.Areas.admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Employees.Include(p => p.Position).ToList());
        }
    }
}
