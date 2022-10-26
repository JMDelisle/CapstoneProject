using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TownOfStettler.Models;
using TownOfStettler.Data;

namespace TownOfStettler.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index(string searchString)
        {
            object[,] modelCollections = new object[,] {
                            { "Device Information", _context.DeviceInformations },
                            { "Display Monitor", _context.DisplayMonitors },
                            { "Ethernet Network", _context.EthernetNetworks },
                            { "Hard Drive", _context.HardDrives },
                            { "Hardware Device", _context.HardwareDevices },
                            { "History", _context.Histories },
                            { "Installed Softwar", _context.InstalledSoftwares },
                            { "In-Use Monitor", _context.InuseMonitors.ToList() },
                            { "Miscellaneous Drive/Reader", _context.SecondaryDrives },
                            { "Modification", _context.Modifications },
                            { "Other Hardware", _context.OtherHardwares },
                            { "Output", _context.Outputs },
                            { "Owner Location", _context.OwnerLocations },
                            { "Part", _context.Parts },
                            { "Printer", _context.Printers },
                            { "Processor", _context.Processors },
                            { "RAM", _context.Rams },
                            { "Software", _context.Softwares },
                            { "Sound Card", _context.SoundCards },
                            { "Video Card", _context.VideoCards },
                            { "Warranty", _context.Warranties }
            };


            ViewData["homeFilter"] = searchString;

            List<string> matchingInfo = new List<string>();
            if (!String.IsNullOrWhiteSpace(searchString))
            {
                for (int i = 0; i < modelCollections.GetLength(0); i++)
                {
                    var modelName = (string)modelCollections[i, 0];
                    var modelRows = new List<object>((IEnumerable<object>)modelCollections[i, 1]);
                    foreach (var item in modelRows)
                    {
                        var allProps = item.GetType().GetProperties();
                        string itemID = allProps[0].GetValue(item).ToString();
                        for (int j = 1; j < allProps.Length; j++)
                        {
                            string field = "";
                            if (allProps[j].GetValue(item) != null)
                            {
                                field = allProps[j].GetValue(item).ToString().ToUpper();
                            }
                            if (field.Contains(searchString.ToUpper()))
                            {
                                matchingInfo.Add(modelName + ": ID #" + itemID + " [ " + allProps[j].Name + " ]");
                            }
                        }
                    }
                }
            }
            ViewBag.HomeInfo = matchingInfo;
            return View();
        }

        [HttpPost]
        public IActionResult Index(int table_number)
        {
            ViewBag.tableNumber = table_number;
            ViewData["homeFilter"] = "";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



//using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;
//using Microsoft.EntityFrameworkCore;
//using TownOfStettler.Models;
//using TownOfStettler.Data;

//namespace TownOfStettler.Controllers
//{
//    public class HomeController : Controller
//    {
//        //private readonly ILogger<HomeController> _logger;

//        //public HomeController(ILogger<HomeController> logger)
//        //{
//        //    _logger = logger;
//        //}

//        private readonly DatabaseContext _context;

//        public HomeController(DatabaseContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        //public async Task<IActionResult> Index(string searchString)
//        //{
//        //    int foundInfo = 0;
//        //    ViewData["homeFilter"] = searchString;
//        //    var Info = from i in _context.DeviceInformations
//        //               select i;
//        //    if (!String.IsNullOrEmpty(searchString))
//        //    {
//        //        Info = Info.Where(i => i.TosNumber.Contains(searchString));
//        //       foreach(var item in Info)
//        //        {
//        //            foundInfo = item.Id;
//        //        }

//        //    }
//        //    ViewBag.HomeInfo = foundInfo;
//        //    return View();
//        //}

//        //public async Task<IActionResult> FindFilters(string searchString)
//        //{
//        //    ViewData["homeFilter"] = searchString;
//        //    var Info = from i in _context.DeviceInformations
//        //               select i;
//        //    if (!String.IsNullOrEmpty(searchString))
//        //    {
//        //        Info = Info.Where(i => i.TosNumber.Contains(searchString));
//        //    }
//        //    ViewBag.HomeInfo = Info;
//        //    return View();

//        //}



//        [HttpPost]
//        public IActionResult Index(int table_number)
//        {
//            ViewBag.tableNumber = table_number;
//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}