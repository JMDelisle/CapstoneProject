//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using TownOfStettler.Data;
//using TownOfStettler.Models;
//using TownOfStettler.Models.Exceptions;
//using Newtonsoft.Json;
//using System.ComponentModel.DataAnnotations;
//using MessagePack;
//using ValidationException = TownOfStettler.Models.Exceptions.ValidationException;

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

//        public IActionResult EnterNewHardwareDevice()
//        {

        }
    }
}
