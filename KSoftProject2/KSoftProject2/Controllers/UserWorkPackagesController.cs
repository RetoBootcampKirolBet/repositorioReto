using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSoftProject2.Data;
using KSoftProject2.Models;

namespace KSoftProject2.Controllers
{
    public class UserWorkPackagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserWorkPackagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserWorkPackages
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.UserWorkPackage.Include(u => u.User).Include(u => u.WorkPackage);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: UserWorkPackages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userWorkPackage = await _context.UserWorkPackage
                .Include(u => u.User)
                .Include(u => u.WorkPackage)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userWorkPackage == null)
            {
                return NotFound();
            }

            return View(userWorkPackage);
        }

        // GET: UserWorkPackages/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id");
            ViewData["WorkPackageId"] = new SelectList(_context.WorkPackage, "Id", "Id");
            return View();
        }

        // POST: UserWorkPackages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,WorkPackageId")] UserWorkPackage userWorkPackage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userWorkPackage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userWorkPackage.UserId);
            ViewData["WorkPackageId"] = new SelectList(_context.WorkPackage, "Id", "Id", userWorkPackage.WorkPackageId);
            return View(userWorkPackage);
        }

        // GET: UserWorkPackages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userWorkPackage = await _context.UserWorkPackage.FindAsync(id);
            if (userWorkPackage == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userWorkPackage.UserId);
            ViewData["WorkPackageId"] = new SelectList(_context.WorkPackage, "Id", "Id", userWorkPackage.WorkPackageId);
            return View(userWorkPackage);
        }

        // POST: UserWorkPackages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,WorkPackageId")] UserWorkPackage userWorkPackage)
        {
            if (id != userWorkPackage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userWorkPackage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserWorkPackageExists(userWorkPackage.Id))
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
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userWorkPackage.UserId);
            ViewData["WorkPackageId"] = new SelectList(_context.WorkPackage, "Id", "Id", userWorkPackage.WorkPackageId);
            return View(userWorkPackage);
        }

        // GET: UserWorkPackages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userWorkPackage = await _context.UserWorkPackage
                .Include(u => u.User)
                .Include(u => u.WorkPackage)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userWorkPackage == null)
            {
                return NotFound();
            }

            return View(userWorkPackage);
        }

        // POST: UserWorkPackages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userWorkPackage = await _context.UserWorkPackage.FindAsync(id);
            _context.UserWorkPackage.Remove(userWorkPackage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserWorkPackageExists(int id)
        {
            return _context.UserWorkPackage.Any(e => e.Id == id);
        }
    }
}
