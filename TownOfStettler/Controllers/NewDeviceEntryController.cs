using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TownOfStettler.Data;
using TownOfStettler.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using MessagePack;

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

        public IActionResult EnterNewDevice(string hardwareDevice, string monitorSize, string monitorType, string monitorResolution, string monitorRefreshRate, string monitorSerialNumber, string monitorOutput, string networkCardSpeed, string networkCardWireless, string networkCardBluetooth, string hardDriveType, string hardDriveSize, string ownerLocationName, string ownerAddress, string ownerPhoneNumber, string processorType, string processorSpeed, string processorGeneration, string processorCoreCount, string ramType, string RamSize, string ramSpeed, string secondaryDriveType, string secondaryDriveRemoveable, string soundCardBrand, string videoCardBrand, string videoCardRamSize, string videoCardOutputType, string videoCardOutputNumber, string warrantyType, string warrantyLength, string warrantyExpiryDate, string TOSnumber, string cpuSerNumber, string cpuModel, string store, string price, string date, string cpuOS, string notes, string monTOSNum, string monSerNum, string monOutNum, string networkCardSerNum, string HDDserNum, string hrdwreTOSnum, string hrdwreType, string pwrSupply, string processorSerNum, string ramSerNum, string miscDriveSerNum, string vidCardSerNum)
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

            int convertedLocation = int.Parse(ownerLocationName);

            if (_context.OwnerLocations.Id != convertedLocation)
            {
                OwnerLocation ownerLocation = new OwnerLocation()
                {
                    Name = ownerLocationName,  //varchar(60)
                    Address = ownerAddress,  //varchar(75)
                    PhoneNumber = ownerPhoneNumber,  //text (nullable)
                };

                _context.OwnerLocations.Add(ownerLocation);
                _context.SaveChanges();
            }
            

                DeviceInformation deviceInformation = new DeviceInformation()
            {
                DeviceTypeId = int.Parse(hardwareDevice),
                OwnerLocation = convertedLocation,                
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

            if (monitorSize != null || monTOSNum != null || monitorType != null || monitorResolution != null || monSerNum != null) 
            {            
                DisplayMonitor displayMonitor = new DisplayMonitor()
                {
                    TosNumber = monTOSNum, //varchar(25)
                    ViewSizeInches = int.Parse(monitorSize),  //decimal (3,2)
                    ViewType = monitorType,  //varchar (30)
                    Resolution = monitorResolution,  //varchar(20)
                    RefreshRateHz = int.Parse(monitorRefreshRate),  //int(3) (nullable)
                    SerialNumber = monSerNum,  //varchar(50)
                    OutputType = monitorOutput,  //varchar(10) (nullable)
                    NumberOfOutputs = int.Parse(monOutNum),  //int (nullable)
                };
                _context.DisplayMonitors.Add(displayMonitor);
                _context.SaveChanges();
            }

            if (networkCardSpeed != null || networkCardBluetooth != null || networkCardWireless != null || networkCardSerNum != null || networkCardSerNum != null)
            {   
                EthernetNetwork ethernetNetwork = new EthernetNetwork()
                {
                    DeviceId = _context.DeviceInformations.Id,  //int FK
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
                    DeviceId = _context.DeviceInformations.Id,  //int FK
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
                    OwnerLocation = _context.OwnerLocations.Id,  //int FK
                    TosNumber = hrdwreTOSnum,  //varchar(20)
                    TypeOfDevice = hrdwreType,  //varchar(40)
                    Destroyed = false,  //bool
                };
                _context.OtherHardwares.Add(hardware);
                _context.SaveChanges();
            }
            
            if (processorType != null || processorSpeed != null || processorGeneration != null ||)
            {
                Processor processor = new Processor()
                {
                    DeviceId = _context.DeviceInformations.Id,  //int FK
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
                    DeviceId = _context.DeviceInformations.Id,  //int FK
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
                    DeviceId = _context.DeviceInformations.Id,  //int FK
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
                    DeviceId = _context.DeviceInformations.Id,  //int FK
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
                        DeviceId = _context.DeviceInformations.Id,  //int FK
                        Brand = videoCardBrand,  //varchar(20) (nullable)
                        RamSizeGb = int.Parse(videoCardRamSize),  //int(11)
                        SerialNumber = vidCardSerNum,  //varchar(30)
                        Destroyed = false,  //bool
                    };

                }
            }

        }
    }
}
