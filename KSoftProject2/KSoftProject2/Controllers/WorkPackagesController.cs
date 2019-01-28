﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSoftProject2.Data;
using KSoftProject2.Models;
using Microsoft.AspNetCore.Identity;
using KSoftProject2.Services;

namespace KSoftProject2.Controllers
{
    public class WorkPackagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<KSUser> _userManager;
        private readonly KSProjectServices _services;

        public WorkPackagesController(KSProjectServices services, ApplicationDbContext context, UserManager<KSUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _services = services;
        }

        public IActionResult SearchResult()
        {
            return View();
        }

        //Busqueda
        //public async Task<IActionResult> SearchResult (string searchString)
        //{
        //    //KSUser currentUser = await _userManager.GetUserAsync(User);
        //    //User usuario = _context.User.Where(x => x.Login == currentUser.Email).FirstOrDefault();
        //    //List<UserWorkPackage> workPackages = new List<UserWorkPackage>();

        //    var busqueda = from s in _context.WorkPackage select s;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        busqueda = busqueda.Where(s => s._Links.CustomField1.KsoftProject.Contains(searchString)
        //                               || s._Links.CustomField2.Sprint.Contains(searchString));
        //    }
        //        result = await _context.busqueda
        //        //.Include(x => x.WorkPackage)
        //        .Include(x => x._Links)
        //        .Include(x => x._Links.Status)
        //        .Include(x => x._Links.Type)
        //        .Include(x => x._Links.Priority)
        //        .Include(x => x._Links.Assignee)
        //        .Include(x => x.Description)
        //        .Include(x => x._Links.CustomField1)
        //        .Include(x => x._Links.CustomField2)
        //        .Include(x => x._Links.Responsible)
        //        .Include(x => x._Links.Author)
        //        //.Where(x => x.WorkPackage.User.Login == currentUser.Email)
        //        .ToListAsync();
        //    var busquedaFinal = busqueda.ToListAsync();
        //    if (busqueda == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(workPackage);
        //}
        //}

        // GET: WorkPackages
        public async Task<IActionResult> Index()

        {
            KSUser currentUser = await _userManager.GetUserAsync(User);
            User usuario = _context.User.Where(x => x.Login == currentUser.Email).FirstOrDefault();
            List<UserWorkPackage> workPackages = new List<UserWorkPackage>();

            //if (currentUser.Email == "administrador@gmail.com")
            if (User.HasClaim("admin", "admin"))
            {
                workPackages = await _context.UserWorkPackage
                .Include(x => x.WorkPackage)
                //.Include(x => x.UserWorkPackages.Select(t => t.User.Login == currentUser.Email))
                .Include(x => x.WorkPackage._Links)
                .Include(x => x.WorkPackage._Links.Status)
                .Include(x => x.WorkPackage._Links.Type)
                .Include(x => x.WorkPackage._Links.Priority)
                .Include(x => x.WorkPackage._Links.Assignee)
                .Include(x => x.WorkPackage.Description)
                .Include(x => x.WorkPackage._Links.CustomField1)
                .Include(x => x.WorkPackage._Links.CustomField2)
                .Include(x => x.WorkPackage._Links.Responsible)
                .Include(x => x.WorkPackage._Links.Author)
                //.Where(x => x.WorkPackage.User.Login == currentUser.Email)
                .ToListAsync();
            }
            else
            {
                workPackages = await _context.UserWorkPackage
                .Where(x => x.User.Login == currentUser.Email)
                .Include(x => x.WorkPackage)
                //.Include(x => x.UserWorkPackages.Select(t => t.User.Login == currentUser.Email))
                .Include(x => x.WorkPackage._Links)
                .Include(x => x.WorkPackage._Links.Status)
                .Include(x => x.WorkPackage._Links.Type)
                .Include(x => x.WorkPackage._Links.Priority)
                .Include(x => x.WorkPackage._Links.Assignee)
                .Include(x => x.WorkPackage.Description)
                .Include(x => x.WorkPackage._Links.CustomField1)
                .Include(x => x.WorkPackage._Links.CustomField2)
                .Include(x => x.WorkPackage._Links.Responsible)
                .Include(x => x.WorkPackage._Links.Author)
                //.Where(x => x.WorkPackage.User.Login == currentUser.Email)
                .ToListAsync();
            }

            return View(workPackages);
            //return View(await _context.WorkPackage.ToListAsync());
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
            KSUser currentUser = await _userManager.GetUserAsync(User);
            User usuario = _context.User.Where(x => x.Login == currentUser.Email).FirstOrDefault();
            List<UserWorkPackage> workPackages = new List<UserWorkPackage>();

            //if (currentUser.Email == "administrador@gmail.com")
            if (User.HasClaim("admin", "admin"))
            {
                workPackages = await _context.UserWorkPackage
                .Include(x => x.WorkPackage)
                //.Include(x => x.UserWorkPackages.Select(t => t.User.Login == currentUser.Email))
                .Include(x => x.WorkPackage._Links)
                .Include(x => x.WorkPackage._Links.Status)
                .Include(x => x.WorkPackage._Links.Type)
                .Include(x => x.WorkPackage._Links.Priority)
                .Include(x => x.WorkPackage._Links.Assignee)
                .Include(x => x.WorkPackage.Description)
                .Include(x => x.WorkPackage._Links.CustomField1)
                .Include(x => x.WorkPackage._Links.CustomField2)
                .Include(x => x.WorkPackage._Links.Responsible)
                .Include(x => x.WorkPackage._Links.Author)
                //.Where(x => x.WorkPackage.User.Login == currentUser.Email)
                .ToListAsync();
            }
            else
            {
                workPackages = await _context.UserWorkPackage
                .Where(x => x.User.Login == currentUser.Email)
                .Include(x => x.WorkPackage)
                //.Include(x => x.UserWorkPackages.Select(t => t.User.Login == currentUser.Email))
                .Include(x => x.WorkPackage._Links)
                .Include(x => x.WorkPackage._Links.Status)
                .Include(x => x.WorkPackage._Links.Type)
                .Include(x => x.WorkPackage._Links.Priority)
                .Include(x => x.WorkPackage._Links.Assignee)
                .Include(x => x.WorkPackage.Description)
                .Include(x => x.WorkPackage._Links.CustomField1)
                .Include(x => x.WorkPackage._Links.CustomField2)
                .Include(x => x.WorkPackage._Links.Responsible)
                .Include(x => x.WorkPackage._Links.Author)
                //.Where(x => x.WorkPackage.User.Login == currentUser.Email)
                .ToListAsync();
            }
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
