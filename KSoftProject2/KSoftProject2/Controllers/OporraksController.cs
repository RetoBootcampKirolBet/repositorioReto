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
    public class OporraksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OporraksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Oporraks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Oporrak.ToListAsync());
        }

        // GET: Oporraks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oporrak = await _context.Oporrak
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oporrak == null)
            {
                return NotFound();
            }

            return View(oporrak);
        }

        // GET: Oporraks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Oporraks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,DiasDeVacaciones,HorasDeVacaciones")] Oporrak oporrak)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oporrak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oporrak);
        }

        // GET: Oporraks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oporrak = await _context.Oporrak.FindAsync(id);
            if (oporrak == null)
            {
                return NotFound();
            }
            return View(oporrak);
        }

        // POST: Oporraks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,DiasDeVacaciones,HorasDeVacaciones")] Oporrak oporrak)
        {
            if (id != oporrak.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oporrak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OporrakExists(oporrak.Id))
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
            return View(oporrak);
        }

        // GET: Oporraks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oporrak = await _context.Oporrak
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oporrak == null)
            {
                return NotFound();
            }

            return View(oporrak);
        }

        // POST: Oporraks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oporrak = await _context.Oporrak.FindAsync(id);
            _context.Oporrak.Remove(oporrak);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OporrakExists(int id)
        {
            return _context.Oporrak.Any(e => e.Id == id);
        }
    }
}
