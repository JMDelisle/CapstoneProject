using Microsoft.AspNetCore.Mvc;
using TownOfStettler.Data;
using TownOfStettler.Models;
using Newtonsoft.Json;
using ValidationException = TownOfStettler.Models.Exceptions.ValidationException;

namespace TownOfStettler.Controllers
{
    public class AddNewDeviceController : Controller
    {
        private readonly DatabaseContext _context;
        public AddNewDeviceController(DatabaseContext context)
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

        public IActionResult EnterNewDevice(string hardwareDevice, string monitorSize, string monitorType, string monitorResolution,
                                            string monitorRefreshRate, string monitorSerialNumber, string monitorOutput, string networkCardSpeed,
                                            string networkCardWireless, string networkCardBluetooth, string hardDriveType, string hardDriveSize,
                                            string ownerLocationName, string ownerAddress, string ownerPhoneNumber, string processorType,
                                            string processorSpeed, string processorGeneration, string processorCoreCount, string ramType,
                                            string RamSize, string ramSpeed, string MiscellaneousDriveType, string MiscellaneousDriveRemoveable,
                                            string soundCardBrand, string videoCardBrand, string videoCardRamSize, string videoCardOutputType,
                                            string videoCardOutputNumber, string warrantyType, string warrantyLength, string warrantyExpiryDate,
                                            string TOSnumber, string cpuSerNumber, string cpuModel, string store, string price, string date,
                                            string cpuOS, string notes, string monTOSNum, string monOutNum, string networkCardSerNum,
                                            string HDDserNum, string hrdwreTOSnum, string hrdwreType, string pwrSupply, string processorSerNum,
                                            string ramSerNum, string miscDriveSerNum, string vidCardSerNum, string printerType, string connectionType)
        {
            ValidationException validationState = new ValidationException();

            
            if (string.IsNullOrEmpty(monitorSize))
            {
                validationState.SubExceptions.Add(new Exception("Please choose a Monitor Size."));
            }
            if (string.IsNullOrEmpty(monitorType))
            {
                validationState.SubExceptions.Add(new Exception("Please choose a Monitor Type."));
            }
            if (string.IsNullOrEmpty(monitorResolution))
            {
                validationState.SubExceptions.Add(new Exception("Please choose a Monitor Resolution."));
            }
            if (string.IsNullOrEmpty(monitorRefreshRate))
            {
                validationState.SubExceptions.Add(new Exception("Please choose a Monitor Refresh Rate."));
            }
            if (string.IsNullOrEmpty(monitorSerialNumber))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(monitorOutput))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(networkCardSpeed))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(networkCardWireless))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(networkCardBluetooth))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(hardDriveType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(hardDriveSize))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }

            if (string.IsNullOrEmpty(processorType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(processorSpeed))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(processorGeneration))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(processorCoreCount))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(ramType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(RamSize))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(ramSpeed))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(MiscellaneousDriveType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(MiscellaneousDriveRemoveable))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(soundCardBrand))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(videoCardBrand))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(videoCardRamSize))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(videoCardOutputType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(videoCardOutputNumber))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(warrantyType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(warrantyLength))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(warrantyExpiryDate))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(TOSnumber))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(cpuSerNumber))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(cpuModel))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(store))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(price))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(date))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(cpuOS))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(monTOSNum))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(monOutNum))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(networkCardSerNum))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(HDDserNum))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(hrdwreTOSnum))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(hrdwreType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(pwrSupply))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(processorSerNum))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(ramSerNum))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(miscDriveSerNum))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(vidCardSerNum))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(printerType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(connectionType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }

            //int convertedLocation = int.Parse(ownerLocationName);
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

            int convertedHardwareDevice = int.Parse(hardwareDevice);

            if (convertedHardwareDevice == 1 || convertedHardwareDevice == 2 || convertedHardwareDevice == 3 || convertedHardwareDevice == 6)
            {
                DeviceInformation deviceInformation = new DeviceInformation()
                {
                    DeviceTypeId = convertedHardwareDevice,
                    OwnerLocation = ownerLocation.Id,
                    TosNumber = TOSnumber,
                    SerialNumber = cpuSerNumber,
                    ModelNumber = cpuModel,
                    PowerSupply = pwrSupply,
                    PurchaseStore = store,
                    PurchasePrice = Math.Round(Decimal.Parse(price), 2),
                    PurchaseDate = DateOnly.Parse(date),
                    OperatingSystem = cpuOS,
                    Destroyed = false,
                    Notes = notes,
                };

                _context.DeviceInformations.Add(deviceInformation);
                _context.SaveChanges();

                // if statement to allow for laptop monitor goes here to make the Monitor TOS number the same as the Device TOS Number
                
                
            }
            
           

                if (monitorSize != null || monTOSNum != null || monitorType != null || monitorResolution != null || monitorSerialNumber != null)
                {
                    DisplayMonitor displayMonitor = new DisplayMonitor()
                    {
                        TosNumber = monTOSNum, //varchar(25)
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
            

            if (warrantyType != null || warrantyLength != null)
            {
                Warranty warranty = new Warranty()
                {
                    DeviceId = deviceInformation.Id,  //int FK
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
