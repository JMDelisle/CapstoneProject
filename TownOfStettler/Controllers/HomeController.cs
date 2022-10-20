using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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