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

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            int foundInfo = 0;
            ViewData["homeFilter"] = searchString;
            var Info = from i in _context.DeviceInformations
                       select i;
            if (!String.IsNullOrEmpty(searchString))
            {
                Info = Info.Where(i => i.TosNumber.Contains(searchString));
                foreach (var item in Info)
                {
                    foundInfo = item.Id;
                }
              

            }
            ViewBag.HomeInfo = foundInfo;
            return View(foundInfo);
        }

        //public async Task<IActionResult> FindFilters(string searchString)
        //{
        //    ViewData["homeFilter"] = searchString;
        //    var Info = from i in _context.DeviceInformations
        //               select i;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        Info = Info.Where(i => i.TosNumber.Contains(searchString));
        //    }
        //    ViewBag.HomeInfo = Info;
        //    return View();

        //}



        [HttpPost]
        public IActionResult Index(int table_number)
        {
            ViewBag.tableNumber = table_number;
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