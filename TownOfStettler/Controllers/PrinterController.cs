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
    public class PrinterController : Controller
    {
        private readonly DatabaseContext _context;

        public PrinterController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Printer
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Printers.Include(p => p.Device);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Printer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Printers == null)
            {
                return NotFound();
            }

            var printer = await _context.Printers
                .Include(p => p.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (printer == null)
            {
                return NotFound();
            }

            return View(printer);
        }

        // GET: Printer/Create
        public IActionResult Create()
        {
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id");
            return View();
        }

        // POST: Printer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DeviceId,Type,ConnectionType,Notes")] Printer printer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(printer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", printer.DeviceId);
            return View(printer);
        }

        // GET: Printer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Printers == null)
            {
                return NotFound();
            }

            var printer = await _context.Printers.FindAsync(id);
            if (printer == null)
            {
                return NotFound();
            }
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", printer.DeviceId);
            return View(printer);
        }

        // POST: Printer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceId,Type,ConnectionType,Notes")] Printer printer)
        {
            if (id != printer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(printer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrinterExists(printer.Id))
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
            ViewData["DeviceId"] = new SelectList(_context.DeviceInformations, "Id", "Id", printer.DeviceId);
            return View(printer);
        }

        // GET: Printer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Printers == null)
            {
                return NotFound();
            }

            var printer = await _context.Printers
                .Include(p => p.Device)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (printer == null)
            {
                return NotFound();
            }

            return View(printer);
        }

        // POST: Printer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Printers == null)
            {
                return Problem("Entity set 'DatabaseContext.Printers'  is null.");
            }
            var printer = await _context.Printers.FindAsync(id);
            if (printer != null)
            {
                _context.Printers.Remove(printer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrinterExists(int id)
        {
          return _context.Printers.Any(e => e.Id == id);
        }
    }
}
