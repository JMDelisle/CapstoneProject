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
    public class AddNewMonitorController : Controller
    {
        private readonly DatabaseContext _context;
        public AddNewMonitorController(DatabaseContext context)
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

        public IActionResult EnterNewMonitor(string ownerLocationName, string ownerAddress, string ownerPhoneNumber, string TosNumber, string monitorSize, string monitorType, string monitorResolution, string monitorRefreshRate, string monitorSerialNumber, string monitorOutput, string monOutNum)
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

            if (monitorSize != null || monitorType != null || monitorSerialNumber != null)
            {
                DisplayMonitor displayMonitor = new DisplayMonitor()
            {
                TosNumber = TosNumber, //varchar(25)
                ViewSizeInches = Decimal.Parse(monitorSize),  //decimal (3,2)
                ViewType = monitorType,  //varchar (30)
                Resolution = monitorResolution,  //varchar(20)
                RefreshRateHz = int.Parse(monitorRefreshRate),  //int(3) (nullable)
                SerialNumber = monitorSerialNumber,  //varchar(50)
                OutputType = monitorOutput,  //varchar(10) (nullable)
                NumberOfOutputs = int.Parse(monOutNum),  //int (nullable)
            };
            _context.DisplayMonitors.Add(displayMonitor);
            _context.SaveChanges();
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
