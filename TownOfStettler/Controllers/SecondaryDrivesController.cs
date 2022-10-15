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

            var SecondaryDrive = await _context.SecondaryDrives
                .Include(s => s.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (SecondaryDrive == null)
            {
                return NotFound();
            }

            return View(SecondaryDrive);
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
        public async Task<IActionResult> Create([Bind("Id,DeviceId,Type,Removable,SerialNumber,Destroyed,Notes")] SecondaryDrive SecondaryDrive)
        {
            if (ModelState.IsValid)
            {
                _context.Add(SecondaryDrive);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", SecondaryDrive.DeviceId);
            return View(SecondaryDrive);
        }

        // GET: SecondaryDrives/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SecondaryDrives == null)
            {
                return NotFound();
            }

            var SecondaryDrive = await _context.SecondaryDrives.FindAsync(id);
            if (SecondaryDrive == null)
            {
                return NotFound();
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", SecondaryDrive.DeviceId);
            return View(SecondaryDrive);
        }

        // POST: SecondaryDrives/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceId,Type,Removable,SerialNumber,Destroyed,Notes")] SecondaryDrive SecondaryDrive)
        {
            if (id != SecondaryDrive.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(SecondaryDrive);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SecondaryDriveExists(SecondaryDrive.Id))
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
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", SecondaryDrive.DeviceId);
            return View(SecondaryDrive);
        }

        // GET: SecondaryDrives/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SecondaryDrives == null)
            {
                return NotFound();
            }

            var SecondaryDrive = await _context.SecondaryDrives
                .Include(s => s.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (SecondaryDrive == null)
            {
                return NotFound();
            }

            return View(SecondaryDrive);
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
            var SecondaryDrive = await _context.SecondaryDrives.FindAsync(id);
            if (SecondaryDrive != null)
            {
                _context.SecondaryDrives.Remove(SecondaryDrive);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecondaryDriveExists(int id)
        {
          return _context.SecondaryDrives.Any(e => e.Id == id);
        }
    }
}
