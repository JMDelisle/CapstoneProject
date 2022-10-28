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
using static System.Formats.Asn1.AsnWriter;

namespace TownOfStettler.Controllers
{
    public class AddNewPrinterController : Controller
    {
        private readonly DatabaseContext _context;
        public AddNewPrinterController(DatabaseContext context)
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
        public IActionResult EnterNewPrinter(string ownerLocationName, string ownerAddress, string ownerPhoneNumber, string printerType, string connectionType, string warrantyType, string warrantyLength, string warrantyExpiryDate, string tiedToDevice, string printerTOS, string printerSerNum, string printerModel, string store, string price, string date)
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

            DeviceInformation deviceId = null;
            foreach (DeviceInformation info in _context.DeviceInformations)
            {
                int tiedDevice = int.Parse(tiedToDevice);
                if (info.Id == tiedDevice)
                {
                    deviceId = info;
                };
                if (deviceId != null)
                {
                    DeviceInformation deviceInformation = new DeviceInformation()
                    {
                        DeviceTypeId = 5,
                        OwnerLocation = ownerLocation.Id,
                        TosNumber = printerTOS,
                        SerialNumber = printerSerNum,
                        ModelNumber = printerModel,
                        PurchaseStore = store,
                        PurchasePrice = Math.Round(Decimal.Parse(price), 2),
                        PurchaseDate = DateOnly.Parse(date),
                        OperatingSystem = "none",
                        Destroyed = false,
                    };

                    _context.DeviceInformations.Add(deviceInformation);
                    _context.SaveChanges();
                }
            if (printerType != null || connectionType != null)
            {
                Printer printer = new Printer()
                {
                    OwnerLocation = ownerLocation.Id,  //int FK
                    TosNumber = printerTOS,
                    DeviceId = tiedDevice,
                    Type = printerType,  //varchar(20)
                    ConnectionType = connectionType,  //varchar(15)
                };
                _context.Printers.Add(printer);
                _context.SaveChanges();
            }
            }
            if (warrantyType != null || warrantyLength != null)
            {
                Warranty warranty = new Warranty()
                {
                    TypeOfWarranty = warrantyType,  //varchar(100)
                    LengthOfWarranty = warrantyLength,  //varchar(15)
                    WarrantyExpiryDate = DateOnly.Parse(warrantyExpiryDate),  //date (nullable)
                };
                _context.Warranties.Add(warranty);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
