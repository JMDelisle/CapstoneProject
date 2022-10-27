using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TownOfStettler.Data;
using TownOfStettler.Models;
using TownOfStettler.Models.Exceptions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using MessagePack;
using ValidationException = TownOfStettler.Models.Exceptions.ValidationException;

namespace TownOfStettler.Controllers
{
    public class AddNewHardwareDeviceController : Controller
    {
        private readonly DatabaseContext _context;
        public AddNewHardwareDeviceController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // If there are exceptions, store them in the view data/bag
            if (TempData["Exceptions"] != null)
            {
                ViewData["Exceptions"] =
                     JsonConvert.DeserializeObject(TempData["Exceptions"].ToString(), typeof(ValidationException));
            }

            return View();
        }

        public IActionResult EnterNewHardwareDevice(string ownerLocationName, string hrdwreTOSnum, string hrdwreType, string ownerAddress, string ownerPhoneNumber)
        {
            OwnerLocation ownerLocation = null;
            foreach (OwnerLocation entry in _context.OwnerLocations)
            {
                if (entry.Name == ownerLocationName)
                {
                    ownerLocation = entry;
                };
            }
            if (ownerLocation is null)
            {
                ownerLocation = new OwnerLocation()
                {
                    Name = ownerLocationName,  //varchar(60)
                    Address = ownerAddress,  //varchar(75)
                    PhoneNumber = ownerPhoneNumber,  //text (nullable)
                };

                _context.OwnerLocations.Add(ownerLocation);
                _context.SaveChanges();
            }
            if (hrdwreTOSnum != null || hrdwreType != null)
            {
                OtherHardware hardware = new OtherHardware()
                {
                    OwnerLocation = ownerLocation.Id,  //int FK
                    TosNumber = hrdwreTOSnum,  //varchar(20)
                    TypeOfDevice = hrdwreType,  //varchar(40)
                    Destroyed = false,  //bool
                };
                _context.OtherHardwares.Add(hardware);
                _context.SaveChanges();
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
