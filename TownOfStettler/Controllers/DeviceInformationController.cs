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
        //public async Task<IActionResult> Index()
        //{
        //    var databaseContext = _context.DeviceInformations.Include(d => d.DeviceType).Include(d => d.DisplayMonitorNavigation).Include(d => d.InstalledSoftware01Navigation).Include(d => d.InstalledSoftware02Navigation).Include(d => d.InstalledSoftware03Navigation).Include(d => d.InstalledSoftware04Navigation).Include(d => d.InstalledSoftware05Navigation).Include(d => d.InstalledSoftware06Navigation).Include(d => d.InstalledSoftware07Navigation).Include(d => d.InstalledSoftware08Navigation).Include(d => d.InstalledSoftware09Navigation).Include(d => d.InstalledSoftware10Navigation).Include(d => d.InstalledSoftware11Navigation).Include(d => d.InstalledSoftware12Navigation).Include(d => d.InstalledSoftware13Navigation).Include(d => d.InstalledSoftware14Navigation).Include(d => d.InstalledSoftware15Navigation).Include(d => d.InstalledSoftware16Navigation).Include(d => d.InstalledSoftware17Navigation).Include(d => d.InstalledSoftware18Navigation).Include(d => d.InstalledSoftware19Navigation).Include(d => d.InstalledSoftware20Navigation).Include(d => d.OwnerLocationNavigation);
        //    return View(await databaseContext.ToListAsync());
        //}

        public async Task<IActionResult> Index(string SearchString)
        {
            ViewData["Filter"] = SearchString;
            var Info = from i in _context.DeviceInformations
                       select i;
            if (!String.IsNullOrEmpty(SearchString))
            {
                Info = Info.Where(i => i.TosNumber.Contains(SearchString));

            }
            return View(Info);
        }


        // GET: DeviceInformation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DeviceInformations == null)
            {
                return NotFound();
            }

            var deviceInformation = await _context.DeviceInformations
                .Include(d => d.DeviceType)
                .Include(d => d.DisplayMonitorNavigation)
                .Include(d => d.InstalledSoftware01Navigation)
                .Include(d => d.InstalledSoftware02Navigation)
                .Include(d => d.InstalledSoftware03Navigation)
                .Include(d => d.InstalledSoftware04Navigation)
                .Include(d => d.InstalledSoftware05Navigation)
                .Include(d => d.InstalledSoftware06Navigation)
                .Include(d => d.InstalledSoftware07Navigation)
                .Include(d => d.InstalledSoftware08Navigation)
                .Include(d => d.InstalledSoftware09Navigation)
                .Include(d => d.InstalledSoftware10Navigation)
                .Include(d => d.InstalledSoftware11Navigation)
                .Include(d => d.InstalledSoftware12Navigation)
                .Include(d => d.InstalledSoftware13Navigation)
                .Include(d => d.InstalledSoftware14Navigation)
                .Include(d => d.InstalledSoftware15Navigation)
                .Include(d => d.InstalledSoftware16Navigation)
                .Include(d => d.InstalledSoftware17Navigation)
                .Include(d => d.InstalledSoftware18Navigation)
                .Include(d => d.InstalledSoftware19Navigation)
                .Include(d => d.InstalledSoftware20Navigation)
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
            ViewData["DisplayMonitor"] = new SelectList(_context.DisplayMonitors, "Id", "Id");
            ViewData["InstalledSoftware01"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware02"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware03"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware04"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware05"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware06"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware07"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware08"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware09"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware10"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware11"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware12"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware13"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware14"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware15"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware16"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware17"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware18"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware19"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["InstalledSoftware20"] = new SelectList(_context.Softwares, "Id", "Id");
            ViewData["OwnerLocation"] = new SelectList(_context.OwnerLocations, "Id", "Id");
            return View();
        }

        // POST: DeviceInformation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DeviceTypeId,OwnerLocation,TosNumber,DisplayMonitor,SerialNumber,ModelNumber,PowerSupply,PurchaseStore,PurchasePrice,PurchaseDate,OperatingSystem,Destroyed,Notes,InstalledSoftware01,InstalledSoftware02,InstalledSoftware03,InstalledSoftware04,InstalledSoftware05,InstalledSoftware06,InstalledSoftware07,InstalledSoftware08,InstalledSoftware09,InstalledSoftware10,InstalledSoftware11,InstalledSoftware12,InstalledSoftware13,InstalledSoftware14,InstalledSoftware15,InstalledSoftware16,InstalledSoftware17,InstalledSoftware18,InstalledSoftware19,InstalledSoftware20,DisplayMonitorNavigationId")] DeviceInformation deviceInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deviceInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceTypeId"] = new SelectList(_context.HardwareDevices, "Id", "Id", deviceInformation.DeviceTypeId);
            ViewData["DisplayMonitor"] = new SelectList(_context.DisplayMonitors, "Id", "Id", deviceInformation.DisplayMonitor);
            ViewData["InstalledSoftware01"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware01);
            ViewData["InstalledSoftware02"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware02);
            ViewData["InstalledSoftware03"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware03);
            ViewData["InstalledSoftware04"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware04);
            ViewData["InstalledSoftware05"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware05);
            ViewData["InstalledSoftware06"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware06);
            ViewData["InstalledSoftware07"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware07);
            ViewData["InstalledSoftware08"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware08);
            ViewData["InstalledSoftware09"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware09);
            ViewData["InstalledSoftware10"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware10);
            ViewData["InstalledSoftware11"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware11);
            ViewData["InstalledSoftware12"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware12);
            ViewData["InstalledSoftware13"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware13);
            ViewData["InstalledSoftware14"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware14);
            ViewData["InstalledSoftware15"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware15);
            ViewData["InstalledSoftware16"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware16);
            ViewData["InstalledSoftware17"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware17);
            ViewData["InstalledSoftware18"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware18);
            ViewData["InstalledSoftware19"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware19);
            ViewData["InstalledSoftware20"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware20);
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
            ViewData["DisplayMonitor"] = new SelectList(_context.DisplayMonitors, "Id", "Id", deviceInformation.DisplayMonitor);
            ViewData["InstalledSoftware01"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware01);
            ViewData["InstalledSoftware02"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware02);
            ViewData["InstalledSoftware03"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware03);
            ViewData["InstalledSoftware04"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware04);
            ViewData["InstalledSoftware05"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware05);
            ViewData["InstalledSoftware06"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware06);
            ViewData["InstalledSoftware07"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware07);
            ViewData["InstalledSoftware08"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware08);
            ViewData["InstalledSoftware09"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware09);
            ViewData["InstalledSoftware10"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware10);
            ViewData["InstalledSoftware11"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware11);
            ViewData["InstalledSoftware12"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware12);
            ViewData["InstalledSoftware13"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware13);
            ViewData["InstalledSoftware14"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware14);
            ViewData["InstalledSoftware15"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware15);
            ViewData["InstalledSoftware16"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware16);
            ViewData["InstalledSoftware17"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware17);
            ViewData["InstalledSoftware18"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware18);
            ViewData["InstalledSoftware19"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware19);
            ViewData["InstalledSoftware20"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware20);
            ViewData["OwnerLocation"] = new SelectList(_context.OwnerLocations, "Id", "Id", deviceInformation.OwnerLocation);
            return View(deviceInformation);
        }

        // POST: DeviceInformation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceTypeId,OwnerLocation,TosNumber,DisplayMonitor,SerialNumber,ModelNumber,PowerSupply,PurchaseStore,PurchasePrice,PurchaseDate,OperatingSystem,Destroyed,Notes,InstalledSoftware01,InstalledSoftware02,InstalledSoftware03,InstalledSoftware04,InstalledSoftware05,InstalledSoftware06,InstalledSoftware07,InstalledSoftware08,InstalledSoftware09,InstalledSoftware10,InstalledSoftware11,InstalledSoftware12,InstalledSoftware13,InstalledSoftware14,InstalledSoftware15,InstalledSoftware16,InstalledSoftware17,InstalledSoftware18,InstalledSoftware19,InstalledSoftware20,DisplayMonitorNavigationId")] DeviceInformation deviceInformation)
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
            ViewData["DisplayMonitor"] = new SelectList(_context.DisplayMonitors, "Id", "Id", deviceInformation.DisplayMonitor);
            ViewData["InstalledSoftware01"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware01);
            ViewData["InstalledSoftware02"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware02);
            ViewData["InstalledSoftware03"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware03);
            ViewData["InstalledSoftware04"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware04);
            ViewData["InstalledSoftware05"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware05);
            ViewData["InstalledSoftware06"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware06);
            ViewData["InstalledSoftware07"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware07);
            ViewData["InstalledSoftware08"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware08);
            ViewData["InstalledSoftware09"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware09);
            ViewData["InstalledSoftware10"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware10);
            ViewData["InstalledSoftware11"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware11);
            ViewData["InstalledSoftware12"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware12);
            ViewData["InstalledSoftware13"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware13);
            ViewData["InstalledSoftware14"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware14);
            ViewData["InstalledSoftware15"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware15);
            ViewData["InstalledSoftware16"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware16);
            ViewData["InstalledSoftware17"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware17);
            ViewData["InstalledSoftware18"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware18);
            ViewData["InstalledSoftware19"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware19);
            ViewData["InstalledSoftware20"] = new SelectList(_context.Softwares, "Id", "Id", deviceInformation.InstalledSoftware20);
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
                .Include(d => d.DisplayMonitorNavigation)
                .Include(d => d.InstalledSoftware01Navigation)
                .Include(d => d.InstalledSoftware02Navigation)
                .Include(d => d.InstalledSoftware03Navigation)
                .Include(d => d.InstalledSoftware04Navigation)
                .Include(d => d.InstalledSoftware05Navigation)
                .Include(d => d.InstalledSoftware06Navigation)
                .Include(d => d.InstalledSoftware07Navigation)
                .Include(d => d.InstalledSoftware08Navigation)
                .Include(d => d.InstalledSoftware09Navigation)
                .Include(d => d.InstalledSoftware10Navigation)
                .Include(d => d.InstalledSoftware11Navigation)
                .Include(d => d.InstalledSoftware12Navigation)
                .Include(d => d.InstalledSoftware13Navigation)
                .Include(d => d.InstalledSoftware14Navigation)
                .Include(d => d.InstalledSoftware15Navigation)
                .Include(d => d.InstalledSoftware16Navigation)
                .Include(d => d.InstalledSoftware17Navigation)
                .Include(d => d.InstalledSoftware18Navigation)
                .Include(d => d.InstalledSoftware19Navigation)
                .Include(d => d.InstalledSoftware20Navigation)
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
