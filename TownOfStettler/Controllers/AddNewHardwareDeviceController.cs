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

//namespace TownOfStettler.Controllers
//{
//    public class AddNewHardwareDeviceController : Controller
//    {
//        private readonly DatabaseContext _context;
//        public AddNewHardwareDeviceController(DatabaseContext context)
//        {
//            _context = context;
//        }
//        public IActionResult Index()
//        {
//            // If there are exceptions, store them in the view data/bag
//            if (TempData["Exceptions"] != null)
//            {
//                ViewData["Exceptions"] =
//                     JsonConvert.DeserializeObject(TempData["Exceptions"].ToString(), typeof(ValidationException));
//            }

//            return View();
//        }

//                _context.OwnerLocations.Add(ownerLocation);
//                _context.SaveChanges();
//            }
//            if (hrdwreTOSnum != null || hrdwreType != null)
//            {
//                OtherHardware hardware = new OtherHardware()
//                {
//                    OwnerLocation = ownerLocation.Id,  //int FK
//                    TosNumber = hrdwreTOSnum,  //varchar(20)
//                    TypeOfDevice = hrdwreType,  //varchar(40)
//                    Destroyed = false,  //bool
//                    Notes = notes  //text  (nullable)
//                };
//                _context.OtherHardwares.Add(hardware);
//                _context.SaveChanges();
//            }

//            if (warrantyType != null || warrantyLength != null)
//            {
//                Warranty warranty = new Warranty()
//                {
//                    TypeOfWarranty = warrantyType,  //varchar(100)
//                    LengthOfWarranty = warrantyLength,  //varchar(15)
//                    WarrantyExpiryDate = DateOnly.Parse(warrantyExpiryDate),  //date (nullable)
//                    Notes = notes,  //text (nullable)
//                };
//                _context.Warranties.Add(warranty);
//            }

//            _context.SaveChanges();
//            return RedirectToAction("Index");
//        }
//    }
//}
