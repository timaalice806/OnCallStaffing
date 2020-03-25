using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnCall_Staffing.Data;
using OnCall_Staffing.Models;

namespace OnCall_Staffing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;
        public object Input { get; set; }
        public object Role { get; set; }

        public ApplicationDbContext Context => _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var employer = _context.Employer.Where(er => er.IdentityUserId == userId).FirstOrDefault();
            var employee = _context.Employee.Where(ee => ee.IdentityUserId == userId).FirstOrDefault();

            if (User.IsInRole("Employer") && employer == null)
            {
                return RedirectToAction("Create", "Employers");
            }
            else if (employer != null)
            {
                return RedirectToAction("Index", "Postings");
            }
            if (User.IsInRole("Employee") && employee == null)
            {
                return RedirectToAction("Create", "Employees");
            }
            else if (employee != null)
            {
                return RedirectToAction("Index", "Postings");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
