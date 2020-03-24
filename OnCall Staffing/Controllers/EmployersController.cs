using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnCall_Staffing.Data;
using OnCall_Staffing.Models;

namespace OnCall_Staffing.Controllers
{
    public class EmployersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var currentEmployer = _context.Employer.Where(e => e.IdentityUserId == userId).FirstOrDefault();

            var posting =  _context.Posting
                .Include(p => p.Facility)
                .Include(p => p.PositionTitle)
                .Include(p => p.DateTime)
                .Include(p => p.PayRate)
                .Include(p => p.PositionDescription)
                .Include(p => p.ArrivalInstructions)
                .Include(p => p.Address.StreetAddress)
                .Include(p => p.Address.City)
                .Include(p => p.Address.State)
                .Include(p => p.Address.ZipCode)
                .ToList();
            return View(posting);

            //var applicationDbContext = _context.Employer.Include(e => e.IdentityUser);
        }

        // GET: Employers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employer = await _context.Employer
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployerID == id);
            if (employer == null)
            {
                return NotFound();
            }

            return View(employer);
        }

        // GET: Employers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Employers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employer employer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employer.IdentityUserId = userId;

                _context.Add(employer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Employers");
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employer.IdentityUserId);
            return View(employer);
        }

        // GET: Employers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employer = await _context.Employer.FindAsync(id);
            if (employer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employer.IdentityUserId);
            return View(employer);
        }

        // POST: Employers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployerID,FirstName,LastName,IdentityUserId")] Employer employer)
        {
            if (id != employer.EmployerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployerExists(employer.EmployerID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employer.IdentityUserId);
            return View(employer);
        }

        // GET: Employers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employer = await _context.Employer
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployerID == id);
            if (employer == null)
            {
                return NotFound();
            }

            return View(employer);
        }

        // POST: Employers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employer = await _context.Employer.FindAsync(id);
            _context.Employer.Remove(employer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployerExists(int id)
        {
            return _context.Employer.Any(e => e.EmployerID == id);
        }
    }
}
