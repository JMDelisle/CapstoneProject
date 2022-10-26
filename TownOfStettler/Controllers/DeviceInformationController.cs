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
    public class DeviceInformationController : Controller
    {
        private readonly DatabaseContext _context;

        public DeviceInformationController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: DeviceInformation
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.DeviceInformations.Include(d => d.DeviceType).Include(d => d.OwnerLocationNavigation);
            return View(await databaseContext.ToListAsync());
        }

            //Search TosNumber
            //public async Task<IActionResult> Index(string SearchString)
            //{
            //    ViewData["Filter"] = SearchString;
            //    var Info = from i in _context.DeviceInformations
            //               select i;
            //    if (!String.IsNullOrEmpty(SearchString))
            //    {
            //        //Info = Info.Where(i => i.DeviceTypeId.ToString().Contains(SearchString));
            //        //Info = Info.Where(i => i.OwnerLocation.ToString().Contains(SearchString));
            //        Info = Info.Where(i => i.TosNumber.Contains(SearchString));
            //        //Info = Info.Where(i => i.SerialNumber.Contains(SearchString));
            //        //Info = Info.Where(i => i.ModelNumber.Contains(SearchString));
            //        //Info = Info.Where(i => i.PowerSupply.Contains(SearchString));
            //        //Info = Info.Where(i => i.PurchaseStore.Contains(SearchString));
            //        //Info = Info.Where(i => i.PurchasePrice.ToString().Contains(SearchString));
            //        //Info = Info.Where(i => i.PurchaseDate.ToString().Contains(SearchString));
            //        //Info = Info.Where(i => i.OperatingSystem.Contains(SearchString));
            //        //Info = Info.Where(i => i.Destroyed.ToString().Contains(SearchString));
            //        //Info = Info.Where(i => i.Notes.Contains(SearchString));

            //    }
            //    return View(Info);
            //}

            // GET: DeviceInformation/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DeviceInformations == null)
            {
                return NotFound();
            }

            var deviceInformation = await _context.DeviceInformations
                .Include(d => d.DeviceType)
                .Include(d => d.OwnerLocationNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deviceInformation == null)
            {
                return NotFound();
            }

            return View(deviceInformation);
        }

        // GET: DeviceInformation/Create
        public IActionResult Create()
        {
            ViewData["DeviceTypeId"] = new SelectList(_context.HardwareDevices, "Id", "Id");
            ViewData["OwnerLocation"] = new SelectList(_context.OwnerLocations, "Id", "Id");
            return View();
        }

        // POST: DeviceInformation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DeviceTypeId,OwnerLocation,TosNumber,SerialNumber,ModelNumber,PowerSupply,PurchaseStore,PurchasePrice,PurchaseDate,OperatingSystem,Destroyed,Notes")] DeviceInformation deviceInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deviceInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceTypeId"] = new SelectList(_context.HardwareDevices, "Id", "Id", deviceInformation.DeviceTypeId);
            ViewData["OwnerLocation"] = new SelectList(_context.OwnerLocations, "Id", "Id", deviceInformation.OwnerLocation);
            return View(deviceInformation);
        }

        // GET: DeviceInformation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DeviceInformations == null)
            {
                return NotFound();
            }

            var deviceInformation = await _context.DeviceInformations.FindAsync(id);
            if (deviceInformation == null)
            {
                return NotFound();
            }
            ViewData["DeviceTypeId"] = new SelectList(_context.HardwareDevices, "Id", "Id", deviceInformation.DeviceTypeId);
            ViewData["OwnerLocation"] = new SelectList(_context.OwnerLocations, "Id", "Id", deviceInformation.OwnerLocation);
            return View(deviceInformation);
        }

        // POST: DeviceInformation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceTypeId,OwnerLocation,TosNumber,SerialNumber,ModelNumber,PowerSupply,PurchaseStore,PurchasePrice,PurchaseDate,OperatingSystem,Destroyed,Notes")] DeviceInformation deviceInformation)
        {
            if (id != deviceInformation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deviceInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeviceInformationExists(deviceInformation.Id))
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
            ViewData["DeviceTypeId"] = new SelectList(_context.HardwareDevices, "Id", "Id", deviceInformation.DeviceTypeId);
            ViewData["OwnerLocation"] = new SelectList(_context.OwnerLocations, "Id", "Id", deviceInformation.OwnerLocation);
            return View(deviceInformation);
        }

        // GET: DeviceInformation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DeviceInformations == null)
            {
                return NotFound();
            }

            var deviceInformation = await _context.DeviceInformations
                .Include(d => d.DeviceType)
                .Include(d => d.OwnerLocationNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deviceInformation == null)
            {
                return NotFound();
            }

            return View(deviceInformation);
        }

        // POST: DeviceInformation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DeviceInformations == null)
            {
                return Problem("Entity set 'DatabaseContext.DeviceInformations'  is null.");
            }
            var deviceInformation = await _context.DeviceInformations.FindAsync(id);
            if (deviceInformation != null)
            {
                _context.DeviceInformations.Remove(deviceInformation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeviceInformationExists(int id)
        {
            return _context.DeviceInformations.Any(e => e.Id == id);
        }
    }
}
