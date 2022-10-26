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

namespace TownOfStettler.Controllers
{
    public class NewDeviceEntryController : Controller
    {
        private readonly DatabaseContext _context;
        public NewDeviceEntryController(DatabaseContext context)
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
                                            string RamSize, string ramSpeed, string secondaryDriveType, string secondaryDriveRemoveable,
                                            string soundCardBrand, string videoCardBrand, string videoCardRamSize, string videoCardOutputType,
                                            string videoCardOutputNumber, string warrantyType, string warrantyLength, string warrantyExpiryDate,
                                            string TOSnumber, string cpuSerNumber, string cpuModel, string store, string price, string date,
                                            string cpuOS, string notes, string monTOSNum, string monOutNum, string networkCardSerNum,
                                            string HDDserNum, string hrdwreTOSnum, string hrdwreType, string pwrSupply, string processorSerNum,
                                            string ramSerNum, string miscDriveSerNum, string vidCardSerNum, string printerType, string connectionType)
        {
            ValidationException validationState = new ValidationException();

            if (string.IsNullOrEmpty(hardwareDevice))
            {
                validationState.SubExceptions.Add(new Exception("Please choose a Device Hardware Type."));
            }
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
            if (string.IsNullOrEmpty(ownerLocationName))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(ownerAddress))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(ownerPhoneNumber))
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
            if (string.IsNullOrEmpty(secondaryDriveType))
            {
                validationState.SubExceptions.Add(new Exception("Error Message Here."));
            }
            if (string.IsNullOrEmpty(secondaryDriveRemoveable))
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

            if (convertedHardwareDevice == 1 || convertedHardwareDevice == 2 || convertedHardwareDevice == 3)
            {
                if (networkCardSpeed != null || networkCardBluetooth != null || networkCardWireless != null || networkCardSerNum != null || networkCardSerNum != null)
                {
                    EthernetNetwork ethernetNetwork = new EthernetNetwork()
                    {
                        DeviceId = deviceInformation.Id,  //int FK
                        Speed = networkCardSpeed,  //varchar (30)
                        Wireless = bool.Parse(networkCardWireless),  //bool
                        Bluetooth = bool.Parse(networkCardBluetooth),  //bool
                        SerialNumber = networkCardSerNum,  //varchar(30)
                        Destroyed = false,
                    };
                    _context.EthernetNetworks.Add(ethernetNetwork);
                    _context.SaveChanges();

                }
                if (hardDriveType != null || hardDriveSize != null || HDDserNum != null)
                {
                    HardDrive hardDrive = new HardDrive()
                    {
                        DeviceId = deviceInformation.Id,  //int FK
                        Type = hardDriveType,  //varchar(20)
                        SizeGb = int.Parse(hardDriveSize),  //int(7)
                        SerialNumber = HDDserNum,  //varchar(30)
                        Destroyed = false,
                    };
                    _context.HardDrives.Add(hardDrive);
                    _context.SaveChanges();
                }

                if (hrdwreTOSnum != null || hrdwreType != null)
                {
                    OtherHardware hardware = new OtherHardware()
                    {
                        OwnerLocation = ownerLocation.Id,  //int FK
                        TosNumber = hrdwreTOSnum,  //varchar(20)
                        TypeOfDevice = hrdwreType,  //varchar(40)
                        Destroyed = false,  //bool
                    };
                    _context.OtherHardwares.Add(hardware);
                    _context.SaveChanges();
                }

                if (processorType != null || processorSpeed != null || processorGeneration != null)
                {
                    Processor processor = new Processor()
                    {
                        DeviceId = deviceInformation.Id,  //int FK
                        Type = processorType,  //varchar(25)
                        SpeedGhz = Math.Round(Decimal.Parse(processorSpeed), 2),  //decimal(5,3)
                        SerialNumber = processorSerNum,  //varchar(30)
                        Generation = int.Parse(processorGeneration),  //int(11) (nullable)
                        CoreCount = int.Parse(processorCoreCount),  //int(11) (nullable)
                        Destroyed = false,  //bool
                    };
                    _context.Processors.Add(processor);
                    _context.SaveChanges();
                }

                if (ramType != null || RamSize != null || ramSpeed != null || ramSerNum != null)
                {
                    Ram ram = new Ram()
                    {
                        DeviceId = deviceInformation.Id,  //int FK
                        Type = ramType,  //varchar(15)
                        SizeGb = int.Parse(RamSize),  //int(11)
                        SpeedMhz = int.Parse(ramSpeed),  //int(5) (nullable)
                        SerialNumber = ramSerNum,  //varchar(30)
                        Destroyed = false,  //bool
                    };
                    _context.Rams.Add(ram);
                    _context.SaveChanges();
                }

                if (secondaryDriveType != null || secondaryDriveRemoveable != null)
                {
                    SecondaryDrive secondaryDrive = new SecondaryDrive()
                    {
                        DeviceId = deviceInformation.Id,  //int FK
                        Type = secondaryDriveType,  //varchar(30)
                        Removable = bool.Parse(secondaryDriveRemoveable),  //bool
                        SerialNumber = miscDriveSerNum,  //varchar(30)
                        Destroyed = false,  //bool
                    };
                    _context.SecondaryDrives.Add(secondaryDrive);
                    _context.SaveChanges();
                }

                if (soundCardBrand != null)
                {
                    SoundCard soundCard = new SoundCard()
                    {
                        DeviceId = deviceInformation.Id,  //int FK
                        Brand = soundCardBrand,  //varchar(20) (nullable)
                        Destroyed = false, //bool
                    };
                    _context.SoundCards.Add(soundCard);
                    _context.SaveChanges();
                }

                while (videoCardRamSize != null)
                {
                    if (videoCardBrand != null || videoCardRamSize != null || vidCardSerNum != null)
                    {
                        VideoCard videoCard = new VideoCard()
                        {
                            DeviceId = deviceInformation.Id,  //int FK
                            Brand = videoCardBrand,  //varchar(20) (nullable)
                            RamSizeGb = int.Parse(videoCardRamSize),  //int(11)
                            SerialNumber = vidCardSerNum,  //varchar(30)
                            Destroyed = false,  //bool
                        };
                        _context.VideoCards.Add(videoCard);
                        _context.SaveChanges();

                        if (videoCardOutputNumber != null)
                        {
                            Output output = new Output()
                            {
                                Type = videoCardOutputType,  //varchar(10) PK
                                VideoCardId = videoCard.Id,  //_context.VideoCards.Id,  //int FK
                                NumberOfOutputs = int.Parse(videoCardOutputNumber),  //int(2)
                            };
                            _context.Outputs.Add(output);
                            _context.SaveChanges();
                        }
                    }

                }
            }

            if (convertedHardwareDevice == 3 || convertedHardwareDevice == 4 || convertedHardwareDevice == 5)
            {

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
            }

            if (convertedHardwareDevice == 5)
            {
                Printer printer = new Printer()
                {
                    OwnerLocation = ownerLocation.Id,  //int FK
                    DeviceId = deviceInformation.Id,  //int FK (nullable)
                    Type = printerType,  //varchar(20)
                    ConnectionType = connectionType,  //varchar(15)
                };
                _context.Printers.Add(printer);
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
