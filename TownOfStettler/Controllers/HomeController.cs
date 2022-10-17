using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TownOfStettler.Models;
//using System.Web.ModelBinding;

namespace TownOfStettler.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> Index(string SearchString)
        //{
        //    ViewData["CurrentFilter"] = SearchString;
        //    var info = from i in _context.DeviceInformations
        //               select i;
        //    if (!string.IsNullOrEmpty(SearchString))
        //    {
        //        info = info.Where(i => i.TosNumber.Contains(SearchString));
        //    }
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