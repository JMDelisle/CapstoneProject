using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TownOfStettler.Data;
using TownOfStettler.Models;
//using System.Web.ModelBinding;

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



        //public async Task<IActionResult> Index()
        //{
        //    var DatabaseContext = _context.DeviceInformations.Include(a => a.DeviceTypeId).Include(a => a.TosNumber).OrderBy(a => a.Id);
        //    return View(await DatabaseContext.ToListAsync());
        //}




        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> Index(string searchstring)
        {
            ViewData["CurrentFilter"] = searchstring;
            var info = from i in _context.DeviceInformations
                       select i;
            if (!string.IsNullOrEmpty(searchstring))
            {
                info = info.Where(i => i.TosNumber.Contains(searchstring));
            }
            return View();
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