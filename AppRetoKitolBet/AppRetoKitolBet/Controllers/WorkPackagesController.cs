using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppRetoKirolBet.Data;
using AppRetoKirolBet.Models;
using Microsoft.AspNetCore.Identity;

namespace AppRetoKirolBet.Controllers
{
    public class WorkPackagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public WorkPackagesController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: WorkPackages
        public async Task<IActionResult> Index()
        {
            //    IdentityUser currentUser = await _userManager.GetUserAsync(User);
            //    List<WorkPackage> workPackages = await _context.WorkPackage
            //        .Include(x => x.UserWorkPackages)
            //        //.Include(x => x.UserWorkPackages.User.Login)
            //        .Include(x => x._Links)
            //        .Include(x => x._Links.Status)
            //        .Include(x => x._Links.Type)
            //        .Include(x => x._Links.Priority)
            //        .Include(x => x._Links.Assignee)
            //        .Include(x => x.Description)
            //        .Where(x => x.UserWorkPackages.User.Login == currentUser.Email)
            //        .ToListAsync();
            return View();//workPackages);
        //    //return View(await _context.WorkPackage.ToListAsync());
        }

        // GET: WorkPackages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workPackage = await _context.WorkPackage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workPackage == null)
            {
                return NotFound();
            }

            return View(workPackage);
        }

        // GET: WorkPackages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WorkPackages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdWPOpenProject,Subject,EstimatedTime,RemainingTime,StartDate,DueDate")] WorkPackage workPackage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workPackage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workPackage);
        }

        // GET: WorkPackages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workPackage = await _context.WorkPackage.FindAsync(id);
            if (workPackage == null)
            {
                return NotFound();
            }
            return View(workPackage);
        }

        // POST: WorkPackages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdWPOpenProject,Subject,EstimatedTime,RemainingTime,StartDate,DueDate")] WorkPackage workPackage)
        {
            if (id != workPackage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workPackage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkPackageExists(workPackage.Id))
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
            return View(workPackage);
        }

        // GET: WorkPackages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workPackage = await _context.WorkPackage
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workPackage == null)
            {
                return NotFound();
            }

            return View(workPackage);
        }

        // POST: WorkPackages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workPackage = await _context.WorkPackage.FindAsync(id);
            _context.WorkPackage.Remove(workPackage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkPackageExists(int id)
        {
            return _context.WorkPackage.Any(e => e.Id == id);
        }
    }
}
