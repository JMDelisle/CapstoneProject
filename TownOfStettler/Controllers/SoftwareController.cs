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
    public class SoftwareController : Controller
    {
        private readonly DatabaseContext _context;

        public SoftwareController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Software
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Softwares.ToListAsync());
        //}

        //Search SoftwareName
        public async Task<IActionResult> Index(string SearchString)
        {
            ViewData["Filter"] = SearchString;
            var Info = from i in _context.Softwares
                       select i;
            if (!String.IsNullOrEmpty(SearchString))
            {
                //Info = Info.Where(i => i.ProductKey.Contains(SearchString));
                Info = Info.Where(i => i.SoftwareName.Contains(SearchString));
                //Info = Info.Where(i => i.AssociatedAccount.Contains(SearchString));
                //Info = Info.Where(i => i.Subscription.ToString().Contains(SearchString));
                //Info = Info.Where(i => i.SubscriptionEndDate.ToString().Contains(SearchString));
                //Info = Info.Where(i => i.PurchaseDate.ToString().Contains(SearchString));
                //Info = Info.Where(i => i.PurchasePrice.ToString().Contains(SearchString));
                //Info = Info.Where(i => i.DevicesAllowed.ToString().Contains(SearchString));
                //Info = Info.Where(i => i.EndOfSupportDate.ToString().Contains(SearchString));
                //Info = Info.Where(i => i.Notes.Contains(SearchString));

            }
            return View(Info);
        }

        // GET: Software/Details/5
        public async Task<IActionResult> Details(int? id, string SubscriptionEndDate, string PurchaseDate, string EndOfSupportDate)
        {
            if (id == null || _context.Softwares == null)
            {
                return NotFound();
            }

            var software = await _context.Softwares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (software == null)
            {
                software.SubscriptionEndDate = DateOnly.Parse(SubscriptionEndDate);
                software.PurchaseDate = DateOnly.Parse(PurchaseDate);
                software.EndOfSupportDate = DateOnly.Parse(EndOfSupportDate);

                return NotFound();
            }

            return View(software);
        }

        // GET: Software/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Software/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductKey,SoftwareName,AssociatedAccount,Subscription,SubscriptionEndDate,PurchaseDate,PurchasePrice,DevicesAllowed,EndOfSupportDate,Notes")] Software software)
        {
            if (ModelState.IsValid)
            {
                _context.Add(software);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(software);
        }

        // GET: Software/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Softwares == null)
            {
                return NotFound();
            }

            var software = await _context.Softwares.FindAsync(id);
            if (software == null)
            {
                return NotFound();
            }
            return View(software);
        }

        // POST: Software/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,string SubscriptionEndDate,string PurchaseDate,string EndOfSupportDate,[Bind("Id,ProductKey,SoftwareName,AssociatedAccount,Subscription,SubscriptionEndDate,PurchaseDate,PurchasePrice,DevicesAllowed,EndOfSupportDate,Notes")] Software software)
        {
            if (id != software.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                software.SubscriptionEndDate = DateOnly.Parse(SubscriptionEndDate);
                try
                {
                    software.SubscriptionEndDate = DateOnly.Parse(SubscriptionEndDate);
                    software.PurchaseDate = DateOnly.Parse(PurchaseDate);
                    software.EndOfSupportDate = DateOnly.Parse(EndOfSupportDate);
                    _context.Update(software);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SoftwareExists(software.Id))
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
            return View(software);
        }

        // GET: Software/Delete/5
        public async Task<IActionResult> Delete(int? id, string SubscriptionEndDate, string PurchaseDate, string EndOfSupportDate)
        {
            if (id == null || _context.Softwares == null)
            {
                return NotFound();
            }

            var software = await _context.Softwares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (software == null)
            {
                software.SubscriptionEndDate = DateOnly.Parse(SubscriptionEndDate);
                software.PurchaseDate = DateOnly.Parse(PurchaseDate);
                software.EndOfSupportDate = DateOnly.Parse(EndOfSupportDate);
                return NotFound();
            }

            return View(software);
        }

        // POST: Software/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Softwares == null)
            {
                return Problem("Entity set 'DatabaseContext.Softwares'  is null.");
            }
            var software = await _context.Softwares.FindAsync(id);
            if (software != null)
            {
                _context.Softwares.Remove(software);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SoftwareExists(int id)
        {
            return _context.Softwares.Any(e => e.Id == id);
        }
    }
}
