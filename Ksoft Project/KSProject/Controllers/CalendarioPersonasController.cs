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
    public class CalendarioPersonasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalendarioPersonasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CalendarioPersonas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CalendarioPersona.Include(c => c.Calendario).Include(c => c.Persona);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CalendarioPersonas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendarioPersona = await _context.CalendarioPersona
                .Include(c => c.Calendario)
                .Include(c => c.Persona)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendarioPersona == null)
            {
                return NotFound();
            }

            return View(calendarioPersona);
        }

        // GET: CalendarioPersonas/Create
        public IActionResult Create()
        {
            ViewData["PersonaId"] = new SelectList(_context.Calendario, "Id", "Id");
            ViewData["WorkPackageId"] = new SelectList(_context.Persona, "Id", "Id");
            return View();
        }

        // POST: CalendarioPersonas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PersonaId,WorkPackageId")] CalendarioPersona calendarioPersona)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calendarioPersona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonaId"] = new SelectList(_context.Calendario, "Id", "Id", calendarioPersona.PersonaId);
            ViewData["WorkPackageId"] = new SelectList(_context.Persona, "Id", "Id", calendarioPersona.WorkPackageId);
            return View(calendarioPersona);
        }

        // GET: CalendarioPersonas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendarioPersona = await _context.CalendarioPersona.FindAsync(id);
            if (calendarioPersona == null)
            {
                return NotFound();
            }
            ViewData["PersonaId"] = new SelectList(_context.Calendario, "Id", "Id", calendarioPersona.PersonaId);
            ViewData["WorkPackageId"] = new SelectList(_context.Persona, "Id", "Id", calendarioPersona.WorkPackageId);
            return View(calendarioPersona);
        }

        // POST: CalendarioPersonas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PersonaId,WorkPackageId")] CalendarioPersona calendarioPersona)
        {
            if (id != calendarioPersona.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calendarioPersona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalendarioPersonaExists(calendarioPersona.Id))
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
            ViewData["PersonaId"] = new SelectList(_context.Calendario, "Id", "Id", calendarioPersona.PersonaId);
            ViewData["WorkPackageId"] = new SelectList(_context.Persona, "Id", "Id", calendarioPersona.WorkPackageId);
            return View(calendarioPersona);
        }

        // GET: CalendarioPersonas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendarioPersona = await _context.CalendarioPersona
                .Include(c => c.Calendario)
                .Include(c => c.Persona)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendarioPersona == null)
            {
                return NotFound();
            }

            return View(calendarioPersona);
        }

        // POST: CalendarioPersonas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calendarioPersona = await _context.CalendarioPersona.FindAsync(id);
            _context.CalendarioPersona.Remove(calendarioPersona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalendarioPersonaExists(int id)
        {
            return _context.CalendarioPersona.Any(e => e.Id == id);
        }
    }
}
