using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSProject.Data;
using KSProject.Models;

namespace KSProject.Controllers
{
    public class DedicationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DedicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dedications
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dedication.ToListAsync());
        }

        // GET: Dedications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dedication = await _context.Dedication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dedication == null)
            {
                return NotFound();
            }

            return View(dedication);
        }

        // GET: Dedications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dedications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Desarrollo,Gestion,Formacion,Soporte,Investigacion,NoDedicadas")] Dedication dedication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dedication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dedication);
        }

        // GET: Dedications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dedication = await _context.Dedication.FindAsync(id);
            if (dedication == null)
            {
                return NotFound();
            }
            return View(dedication);
        }

        // POST: Dedications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Desarrollo,Gestion,Formacion,Soporte,Investigacion,NoDedicadas")] Dedication dedication)
        {
            if (id != dedication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dedication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DedicationExists(dedication.Id))
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
            return View(dedication);
        }

        // GET: Dedications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dedication = await _context.Dedication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dedication == null)
            {
                return NotFound();
            }

            return View(dedication);
        }

        // POST: Dedications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dedication = await _context.Dedication.FindAsync(id);
            _context.Dedication.Remove(dedication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DedicationExists(int id)
        {
            return _context.Dedication.Any(e => e.Id == id);
        }
    }
}
