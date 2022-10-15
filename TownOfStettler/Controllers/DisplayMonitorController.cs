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
    public class DisplayMonitorController : Controller
    {
        private readonly DatabaseContext _context;

        public DisplayMonitorController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: DisplayMonitor
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.DisplayMonitors.Include(d => d.Device);
            return View(await databaseContext.ToListAsync());
        }

        // GET: DisplayMonitor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DisplayMonitors == null)
            {
                return NotFound();
            }

            var displayMonitor = await _context.DisplayMonitors
                .Include(d => d.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (displayMonitor == null)
            {
                return NotFound();
            }

            return View(displayMonitor);
        }

        // GET: DisplayMonitor/Create
        public IActionResult Create()
        {
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id");
            return View();
        }

        // POST: DisplayMonitor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DeviceId,ViewSizeInches,ViewType,Resolution,RefreshRateHz,SerialNumber,OutputType,NumberOfOutputs,Notes")] DisplayMonitor displayMonitor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(displayMonitor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", displayMonitor.DeviceId);
            return View(displayMonitor);
        }

        // GET: DisplayMonitor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DisplayMonitors == null)
            {
                return NotFound();
            }

            var displayMonitor = await _context.DisplayMonitors.FindAsync(id);
            if (displayMonitor == null)
            {
                return NotFound();
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", displayMonitor.DeviceId);
            return View(displayMonitor);
        }

        // POST: DisplayMonitor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceId,ViewSizeInches,ViewType,Resolution,RefreshRateHz,SerialNumber,OutputType,NumberOfOutputs,Notes")] DisplayMonitor displayMonitor)
        {
            if (id != displayMonitor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(displayMonitor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DisplayMonitorExists(displayMonitor.Id))
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
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", displayMonitor.DeviceId);
            return View(displayMonitor);
        }

        // GET: DisplayMonitor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DisplayMonitors == null)
            {
                return NotFound();
            }

            var displayMonitor = await _context.DisplayMonitors
                .Include(d => d.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (displayMonitor == null)
            {
                return NotFound();
            }

            return View(displayMonitor);
        }

        // POST: DisplayMonitor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DisplayMonitors == null)
            {
                return Problem("Entity set 'DatabaseContext.DisplayMonitors'  is null.");
            }
            var displayMonitor = await _context.DisplayMonitors.FindAsync(id);
            if (displayMonitor != null)
            {
                _context.DisplayMonitors.Remove(displayMonitor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DisplayMonitorExists(int id)
        {
          return _context.DisplayMonitors.Any(e => e.Id == id);
        }
    }
}
