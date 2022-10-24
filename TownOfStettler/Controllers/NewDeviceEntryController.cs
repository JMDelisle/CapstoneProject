using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TownOfStettler.Data;
using TownOfStettler.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TownOfStettler.Controllers
{
    public class NewDeviceEntryController : Controller
    {
        private readonly DatabaseContext _context; 
        public NewDeviceEntryController(DatabaseContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {

            return View();
        }

        public IActionResult EnterNewDevice(string hardwareDevice, string monitorSize, string monitorType, string monitorResolution, string monitorRefreshRate, string monitorSerialNumber, string monitorOutput, string networkCardSpeed, string networkCardWireless, string networkCardBluetooth, string hardDriveType, string hardDriveSize, string ownerLocationName, string ownerAddress, string ownerPhoneNumber, string processorType, string processorSpeed, string processorGeneration, string processorCoreCount, string ramType, string RamSize, string ramSpeed, string secondaryDriveType, string secondaryDriveRemoveable, string soundCardBrand, string videoCardBrand, string videoCardRamSize, string videoCardOutputType, string videoCardOutputNumber, string warrantyType, string warrantyLength, string warrantyExpiryDate, string TOSnumber, string cpuSerNumber, string cpuModel, string store, string price, string date, string cpuOS, string notes)
        {
            //ValidationException validationState = new ValidationException();

            //if (string.IsNullOrEmpty(hardwareDevice))
            //{
            //    validationState.SubExceptions.Add(new Exception("Please choose a Device Hardware Type."));
            //}
            //if (string.IsNullOrEmpty(monitorSize))
            //{
            //    validationState.SubExceptions.Add(new Exception("Please choose a Monitor Size."));
            //}
            //if (string.IsNullOrEmpty(monitorType,))
            //{
            //    validationState.SubExceptions.Add(new Exception("Please choose a Monitor Type."));
            //}
            //if (string.IsNullOrEmpty(monitorResolution))
            //{
            //    validationState.SubExceptions.Add(new Exception("Please choose a Monitor Resolution."));
            //}
            //if (string.IsNullOrEmpty(monitorRefreshRate))
            //{
            //    validationState.SubExceptions.Add(new Exception("Please choose a Monitor Refresh Rate."));
            //}
            //if (string.IsNullOrEmpty(monitorType,))
            //{
            //    validationState.SubExceptions.Add(new Exception("Please choose a Monitor Type."));
            //}

            DeviceInformation deviceInformation = new DeviceInformation()
            {
                DeviceTypeId = int.Parse(hardwareDevice),
                TosNumber = TOSnumber,
                SerialNumber = cpuSerNumber,
                ModelNumber = cpuModel,
                PurchaseStore = store,
                PurchasePrice = Math.Round(Decimal.Parse(price), 2),
                PurchaseDate = DateOnly.Parse(date),
                OperatingSystem = cpuOS,
                Destroyed = false,
                Notes = notes,
            };





        }
    }
}
