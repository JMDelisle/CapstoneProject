using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TownOfStettler.Data;
using TownOfStettler.Models;

namespace TownOfStettler.Controllers
{
    public class ProcesssorController : Controller
    {
        private readonly DatabaseContext _context;

        public ProcesssorController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Processsor
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Processsors.Include(p => p.Device);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Processsor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Processsors == null)
            {
                return NotFound();
            }

            var processsor = await _context.Processsors
                .Include(p => p.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (processsor == null)
            {
                return NotFound();
            }

            return View(processsor);
        }

        // GET: Processsor/Create
        public IActionResult Create()
        {
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id");
            return View();
        }

        // POST: Processsor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DeviceId,Type,SpeedGhz,SerialNumber,Generation,CoreCount,Destroyed,Notes")] Processsor processsor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(processsor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", processsor.DeviceId);
            return View(processsor);
        }

        // GET: Processsor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Processsors == null)
            {
                return NotFound();
            }

            var processsor = await _context.Processsors.FindAsync(id);
            if (processsor == null)
            {
                return NotFound();
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", processsor.DeviceId);
            return View(processsor);
        }

        // POST: Processsor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceId,Type,SpeedGhz,SerialNumber,Generation,CoreCount,Destroyed,Notes")] Processsor processsor)
        {
            if (id != processsor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(processsor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcesssorExists(processsor.Id))
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
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", processsor.DeviceId);
            return View(processsor);
        }

        // GET: Processsor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Processsors == null)
            {
                return NotFound();
            }

            var processsor = await _context.Processsors
                .Include(p => p.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (processsor == null)
            {
                return NotFound();
            }

            return View(processsor);
        }

        // POST: Processsor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Processsors == null)
            {
                return Problem("Entity set 'DatabaseContext.Processsors'  is null.");
            }
            var processsor = await _context.Processsors.FindAsync(id);
            if (processsor != null)
            {
                _context.Processsors.Remove(processsor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcesssorExists(int id)
        {
          return _context.Processsors.Any(e => e.Id == id);
        }
    }
}
