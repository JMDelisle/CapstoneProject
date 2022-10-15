﻿using System;
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
    public class ModificationController : Controller
    {
        private readonly DatabaseContext _context;

        public ModificationController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Modification
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Modifications.Include(m => m.HardDrive).Include(m => m.Processor).Include(m => m.Ram).Include(m => m.SecondaryDrive).Include(m => m.SoundCard).Include(m => m.VideoCard);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Modification/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Modifications == null)
            {
                return NotFound();
            }

            var modification = await _context.Modifications
                .Include(m => m.HardDrive)
                .Include(m => m.Processor)
                .Include(m => m.Ram)
                .Include(m => m.SecondaryDrive)
                .Include(m => m.SoundCard)
                .Include(m => m.VideoCard)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modification == null)
            {
                return NotFound();
            }

            return View(modification);
        }

        // GET: Modification/Create
        public IActionResult Create()
        {
            ViewData["HardDriveId"] = new SelectList(_context.HardDrives, "Id", "Id");
            ViewData["ProcessorId"] = new SelectList(_context.Processsors, "Id", "Id");
            ViewData["RamId"] = new SelectList(_context.Rams, "Id", "Id");
            ViewData["SecondaryDriveId"] = new SelectList(_context.SecondaryDrives, "Id", "Id");
            ViewData["SoundCardId"] = new SelectList(_context.SoundCards, "Id", "Id");
            ViewData["VideoCardId"] = new SelectList(_context.VideoCards, "Id", "Id");
            return View();
        }

        // POST: Modification/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProcessorId,RamId,HardDriveId,SecondaryDriveId,SoundCardId,VideoCardId,Notes")] Modification modification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HardDriveId"] = new SelectList(_context.HardDrives, "Id", "Id", modification.HardDriveId);
            ViewData["ProcessorId"] = new SelectList(_context.Processsors, "Id", "Id", modification.ProcessorId);
            ViewData["RamId"] = new SelectList(_context.Rams, "Id", "Id", modification.RamId);
            ViewData["SecondaryDriveId"] = new SelectList(_context.SecondaryDrives, "Id", "Id", modification.SecondaryDriveId);
            ViewData["SoundCardId"] = new SelectList(_context.SoundCards, "Id", "Id", modification.SoundCardId);
            ViewData["VideoCardId"] = new SelectList(_context.VideoCards, "Id", "Id", modification.VideoCardId);
            return View(modification);
        }

        // GET: Modification/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Modifications == null)
            {
                return NotFound();
            }

            var modification = await _context.Modifications.FindAsync(id);
            if (modification == null)
            {
                return NotFound();
            }
            ViewData["HardDriveId"] = new SelectList(_context.HardDrives, "Id", "Id", modification.HardDriveId);
            ViewData["ProcessorId"] = new SelectList(_context.Processsors, "Id", "Id", modification.ProcessorId);
            ViewData["RamId"] = new SelectList(_context.Rams, "Id", "Id", modification.RamId);
            ViewData["SecondaryDriveId"] = new SelectList(_context.SecondaryDrives, "Id", "Id", modification.SecondaryDriveId);
            ViewData["SoundCardId"] = new SelectList(_context.SoundCards, "Id", "Id", modification.SoundCardId);
            ViewData["VideoCardId"] = new SelectList(_context.VideoCards, "Id", "Id", modification.VideoCardId);
            return View(modification);
        }

        // POST: Modification/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProcessorId,RamId,HardDriveId,SecondaryDriveId,SoundCardId,VideoCardId,Notes")] Modification modification)
        {
            if (id != modification.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModificationExists(modification.Id))
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
            ViewData["HardDriveId"] = new SelectList(_context.HardDrives, "Id", "Id", modification.HardDriveId);
            ViewData["ProcessorId"] = new SelectList(_context.Processsors, "Id", "Id", modification.ProcessorId);
            ViewData["RamId"] = new SelectList(_context.Rams, "Id", "Id", modification.RamId);
            ViewData["SecondaryDriveId"] = new SelectList(_context.SecondaryDrives, "Id", "Id", modification.SecondaryDriveId);
            ViewData["SoundCardId"] = new SelectList(_context.SoundCards, "Id", "Id", modification.SoundCardId);
            ViewData["VideoCardId"] = new SelectList(_context.VideoCards, "Id", "Id", modification.VideoCardId);
            return View(modification);
        }

        // GET: Modification/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Modifications == null)
            {
                return NotFound();
            }

            var modification = await _context.Modifications
                .Include(m => m.HardDrive)
                .Include(m => m.Processor)
                .Include(m => m.Ram)
                .Include(m => m.SecondaryDrive)
                .Include(m => m.SoundCard)
                .Include(m => m.VideoCard)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modification == null)
            {
                return NotFound();
            }

            return View(modification);
        }

        // POST: Modification/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Modifications == null)
            {
                return Problem("Entity set 'DatabaseContext.Modifications'  is null.");
            }
            var modification = await _context.Modifications.FindAsync(id);
            if (modification != null)
            {
                _context.Modifications.Remove(modification);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModificationExists(int id)
        {
          return _context.Modifications.Any(e => e.Id == id);
        }
    }
}