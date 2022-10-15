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
    public class SecondaryDrivesController : Controller
    {
        private readonly DatabaseContext _context;

        public SecondaryDrivesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: SecondaryDrives
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.SecondaryDrives.Include(s => s.Device);
            return View(await databaseContext.ToListAsync());
        }

        // GET: SecondaryDrives/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SecondaryDrives == null)
            {
                return NotFound();
            }

            var secondaryDrife = await _context.SecondaryDrives
                .Include(s => s.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (secondaryDrife == null)
            {
                return NotFound();
            }

            return View(secondaryDrife);
        }

        // GET: SecondaryDrives/Create
        public IActionResult Create()
        {
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id");
            return View();
        }

        // POST: SecondaryDrives/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DeviceId,Type,Removable,SerialNumber,Destroyed,Notes")] SecondaryDrife secondaryDrife)
        {
            if (ModelState.IsValid)
            {
                _context.Add(secondaryDrife);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", secondaryDrife.DeviceId);
            return View(secondaryDrife);
        }

        // GET: SecondaryDrives/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SecondaryDrives == null)
            {
                return NotFound();
            }

            var secondaryDrife = await _context.SecondaryDrives.FindAsync(id);
            if (secondaryDrife == null)
            {
                return NotFound();
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", secondaryDrife.DeviceId);
            return View(secondaryDrife);
        }

        // POST: SecondaryDrives/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceId,Type,Removable,SerialNumber,Destroyed,Notes")] SecondaryDrife secondaryDrife)
        {
            if (id != secondaryDrife.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(secondaryDrife);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SecondaryDrifeExists(secondaryDrife.Id))
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
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", secondaryDrife.DeviceId);
            return View(secondaryDrife);
        }

        // GET: SecondaryDrives/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SecondaryDrives == null)
            {
                return NotFound();
            }

            var secondaryDrife = await _context.SecondaryDrives
                .Include(s => s.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (secondaryDrife == null)
            {
                return NotFound();
            }

            return View(secondaryDrife);
        }

        // POST: SecondaryDrives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SecondaryDrives == null)
            {
                return Problem("Entity set 'DatabaseContext.SecondaryDrives'  is null.");
            }
            var secondaryDrife = await _context.SecondaryDrives.FindAsync(id);
            if (secondaryDrife != null)
            {
                _context.SecondaryDrives.Remove(secondaryDrife);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecondaryDrifeExists(int id)
        {
          return _context.SecondaryDrives.Any(e => e.Id == id);
        }
    }
}
