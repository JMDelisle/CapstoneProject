using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TownOfStettler.Migrations
{
    public partial class migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hardware device",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeofHardware = table.Column<string>(name: "Type of Hardware", type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hardware device", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "software",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(50)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductKey = table.Column<string>(name: "Product Key", type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SoftwareName = table.Column<string>(name: "Software Name", type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AssociatedAccount = table.Column<string>(name: "Associated Account", type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subscription = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SubscriptionEndDate = table.Column<DateOnly>(name: "Subscription End Date", type: "date", nullable: true),
                    PurchaseDate = table.Column<DateOnly>(name: "Purchase Date", type: "date", nullable: true),
                    PurchasePrice = table.Column<decimal>(name: "Purchase Price", type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    DevicesAllowed = table.Column<int>(name: "Devices Allowed", type: "int(11)", nullable: false),
                    EndofSupportDate = table.Column<DateOnly>(name: "End of Support Date", type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_software", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "device information",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceTypeID = table.Column<int>(name: "Device Type ID", type: "int(11)", nullable: false),
                    OwnerLocation = table.Column<int>(name: "Owner/Location", type: "int(11)", nullable: false),
                    TOSNumber = table.Column<string>(name: "TOS Number", type: "varchar(25)", maxLength: 25, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SerialNumber = table.Column<string>(name: "Serial Number", type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModelNumber = table.Column<string>(name: "Model Number", type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PowerSupply = table.Column<string>(name: "Power Supply", type: "varchar(75)", maxLength: 75, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PurchaseStore = table.Column<string>(name: "Purchase Store", type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PurchasePrice = table.Column<decimal>(name: "Purchase Price", type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    PurchaseDate = table.Column<DateOnly>(name: "Purchase Date", type: "date", nullable: false),
                    OperatingSystem = table.Column<string>(name: "Operating System", type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destroyed = table.Column<double>(type: "double", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InstalledSoftware01 = table.Column<int>(name: "Installed Software (01)", type: "int(11)", nullable: true),
                    InstalledSoftware02 = table.Column<int>(name: "Installed Software (02)", type: "int(11)", nullable: true),
                    InstalledSoftware03 = table.Column<int>(name: "Installed Software (03)", type: "int(11)", nullable: true),
                    InstalledSoftware04 = table.Column<int>(name: "Installed Software (04)", type: "int(11)", nullable: true),
                    InstalledSoftware05 = table.Column<int>(name: "Installed Software (05)", type: "int(11)", nullable: true),
                    InstalledSoftware06 = table.Column<int>(name: "Installed Software (06)", type: "int(11)", nullable: true),
                    InstalledSoftware07 = table.Column<int>(name: "Installed Software (07)", type: "int(11)", nullable: true),
                    InstalledSoftware08 = table.Column<int>(name: "Installed Software (08)", type: "int(11)", nullable: true),
                    InstalledSoftware09 = table.Column<int>(name: "Installed Software (09)", type: "int(11)", nullable: true),
                    InstalledSoftware10 = table.Column<int>(name: "Installed Software (10)", type: "int(11)", nullable: true),
                    InstalledSoftware11 = table.Column<int>(name: "Installed Software (11)", type: "int(11)", nullable: true),
                    InstalledSoftware12 = table.Column<int>(name: "Installed Software (12)", type: "int(11)", nullable: true),
                    InstalledSoftware13 = table.Column<int>(name: "Installed Software (13)", type: "int(11)", nullable: true),
                    InstalledSoftware14 = table.Column<int>(name: "Installed Software (14)", type: "int(11)", nullable: true),
                    InstalledSoftware15 = table.Column<int>(name: "Installed Software (15)", type: "int(11)", nullable: true),
                    InstalledSoftware16 = table.Column<int>(name: "Installed Software (16)", type: "int(11)", nullable: true),
                    InstalledSoftware17 = table.Column<int>(name: "Installed Software (17)", type: "int(11)", nullable: true),
                    InstalledSoftware18 = table.Column<int>(name: "Installed Software (18)", type: "int(11)", nullable: true),
                    InstalledSoftware19 = table.Column<int>(name: "Installed Software (19)", type: "int(11)", nullable: true),
                    InstalledSoftware20 = table.Column<int>(name: "Installed Software (20)", type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_device information", x => x.ID);
                    table.ForeignKey(
                        name: "device information_ibfk_1",
                        column: x => x.DeviceTypeID,
                        principalTable: "hardware device",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_10",
                        column: x => x.InstalledSoftware08,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_11",
                        column: x => x.InstalledSoftware09,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_12",
                        column: x => x.InstalledSoftware10,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_13",
                        column: x => x.InstalledSoftware11,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_14",
                        column: x => x.InstalledSoftware12,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_15",
                        column: x => x.InstalledSoftware13,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_16",
                        column: x => x.InstalledSoftware14,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_17",
                        column: x => x.InstalledSoftware15,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_18",
                        column: x => x.InstalledSoftware16,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_19",
                        column: x => x.InstalledSoftware17,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_20",
                        column: x => x.InstalledSoftware18,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_21",
                        column: x => x.InstalledSoftware19,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_22",
                        column: x => x.InstalledSoftware20,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_3",
                        column: x => x.InstalledSoftware01,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_4",
                        column: x => x.InstalledSoftware02,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_5",
                        column: x => x.InstalledSoftware03,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_6",
                        column: x => x.InstalledSoftware04,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_7",
                        column: x => x.InstalledSoftware05,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_8",
                        column: x => x.InstalledSoftware06,
                        principalTable: "software",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "device information_ibfk_9",
                        column: x => x.InstalledSoftware07,
                        principalTable: "software",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "display monitors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    ViewSizeInches = table.Column<int>(name: "View Size (Inches)", type: "int(3)", nullable: false),
                    ViewType = table.Column<string>(name: "View Type", type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolution = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefreshRateHz = table.Column<int>(name: "Refresh Rate (Hz)", type: "int(3)", nullable: true),
                    SerialNumber = table.Column<string>(name: "Serial Number", type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OutputType = table.Column<string>(name: "Output Type", type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberofOutputs = table.Column<int>(name: "Number of Outputs", type: "int(11)", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_display monitors", x => x.ID);
                    table.ForeignKey(
                        name: "display monitors_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "ethernet/network",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    Speed = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Wireless = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Bluetooth = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    SerialNumber = table.Column<string>(name: "Serial Number", type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destroyed = table.Column<double>(type: "double", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ethernet/network", x => x.ID);
                    table.ForeignKey(
                        name: "ethernet/network_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "hard drive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    Type = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SizeGb = table.Column<string>(name: "Size (Gb)", type: "varchar(7)", maxLength: 7, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SerialNumber = table.Column<string>(name: "Serial Number", type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destroyed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hard drive", x => x.ID);
                    table.ForeignKey(
                        name: "hard drive_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "owner/location",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(75)", maxLength: 75, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(name: "Phone Number", type: "varchar(14)", maxLength: 14, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owner/location", x => x.ID);
                    table.ForeignKey(
                        name: "owner/location_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "printers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    Type = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConnectionType = table.Column<string>(name: "Connection Type", type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_printers", x => x.ID);
                    table.ForeignKey(
                        name: "printers_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "processsor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    Type = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpeedGHz = table.Column<decimal>(name: "Speed (GHz)", type: "decimal(3,3)", precision: 3, scale: 3, nullable: false),
                    SerialNumber = table.Column<string>(name: "Serial Number", type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Generation = table.Column<int>(type: "int(11)", nullable: false),
                    CoreCount = table.Column<int>(name: "Core Count", type: "int(11)", nullable: false),
                    Destroyed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processsor", x => x.ID);
                    table.ForeignKey(
                        name: "processsor_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "ram",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    Type = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Size = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpeedMHz = table.Column<int>(name: "Speed (MHz)", type: "int(5)", nullable: false),
                    SerialNumber = table.Column<string>(name: "Serial Number", type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destroyed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ram", x => x.ID);
                    table.ForeignKey(
                        name: "ram_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "secondary drives",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    Type = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Removable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SerialNumber = table.Column<string>(name: "Serial Number", type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destroyed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_secondary drives", x => x.ID);
                    table.ForeignKey(
                        name: "secondary drives_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "sound card",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    Brand = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destroyed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sound card", x => x.ID);
                    table.ForeignKey(
                        name: "sound card_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "video card",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    Brand = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RamSizeGB = table.Column<int>(name: "Ram Size (GB)", type: "int(11)", nullable: false),
                    SerialNumber = table.Column<string>(name: "Serial Number", type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destroyed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_video card", x => x.ID);
                    table.ForeignKey(
                        name: "video card_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "warranty",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    TypeofWarranty = table.Column<string>(name: "Type of Warranty", type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LengthofWarranty = table.Column<string>(name: "Length of Warranty", type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WarrantyExpiryDate = table.Column<DateOnly>(name: "Warranty Expiry Date", type: "date", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warranty", x => x.ID);
                    table.ForeignKey(
                        name: "warranty_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "history",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(name: "Device ID", type: "int(11)", nullable: false),
                    PartsChanged = table.Column<int>(name: "Parts Changed", type: "int(11)", nullable: false),
                    PastOwners = table.Column<int>(name: "Past Owner(s)", type: "int(11)", nullable: false),
                    Wiped = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PartsRemoved = table.Column<bool>(name: "Parts Removed", type: "tinyint(1)", nullable: false),
                    DateofChanges = table.Column<DateOnly>(name: "Date of Changes", type: "date", nullable: false),
                    OutofServiceDate = table.Column<DateOnly>(name: "Out of Service Date", type: "date", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_history", x => x.ID);
                    table.ForeignKey(
                        name: "history_ibfk_1",
                        column: x => x.DeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "history_ibfk_2",
                        column: x => x.PastOwners,
                        principalTable: "owner/location",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "other hardware",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OwnerLocation = table.Column<int>(name: "Owner/Location", type: "int(11)", nullable: false),
                    TOSNumber = table.Column<string>(name: "TOS Number", type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<int>(type: "int(11)", nullable: false),
                    Destroyed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_other hardware", x => x.ID);
                    table.ForeignKey(
                        name: "other hardware_ibfk_1",
                        column: x => x.OwnerLocation,
                        principalTable: "owner/location",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "modifications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProcessorID = table.Column<int>(name: "Processor ID", type: "int(11)", nullable: true),
                    RAMID = table.Column<int>(name: "RAM ID", type: "int(11)", nullable: true),
                    HardDriveID = table.Column<int>(name: "Hard Drive ID", type: "int(11)", nullable: true),
                    SecondaryDriveID = table.Column<int>(name: "Secondary Drive ID", type: "int(11)", nullable: true),
                    SoundCardID = table.Column<int>(name: "Sound Card ID", type: "int(11)", nullable: true),
                    VideoCardID = table.Column<int>(name: "Video Card ID", type: "int(11)", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modifications", x => x.ID);
                    table.ForeignKey(
                        name: "modifications_ibfk_1",
                        column: x => x.HardDriveID,
                        principalTable: "hard drive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "modifications_ibfk_2",
                        column: x => x.ProcessorID,
                        principalTable: "processsor",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "modifications_ibfk_3",
                        column: x => x.RAMID,
                        principalTable: "ram",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "modifications_ibfk_4",
                        column: x => x.SecondaryDriveID,
                        principalTable: "secondary drives",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "modifications_ibfk_5",
                        column: x => x.SoundCardID,
                        principalTable: "sound card",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "modifications_ibfk_6",
                        column: x => x.VideoCardID,
                        principalTable: "video card",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "outputs",
                columns: table => new
                {
                    Type = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VideoCardID = table.Column<int>(name: "Video Card ID", type: "int(11)", nullable: false),
                    NumberofOutputs = table.Column<int>(name: "Number of Outputs", type: "int(2)", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Type);
                    table.ForeignKey(
                        name: "outputs_ibfk_1",
                        column: x => x.VideoCardID,
                        principalTable: "video card",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "parts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OriginalDeviceID = table.Column<int>(name: "Original Device ID", type: "int(11)", nullable: false),
                    DeviceHistoryID = table.Column<int>(name: "Device History ID", type: "int(11)", nullable: false),
                    RAMID = table.Column<int>(name: "RAM ID", type: "int(11)", nullable: true),
                    HardDriveID = table.Column<int>(name: "Hard Drive ID", type: "int(11)", nullable: true),
                    SecondaryDriveID = table.Column<int>(name: "Secondary Drive ID", type: "int(11)", nullable: true),
                    VideoCardID = table.Column<int>(name: "Video Card ID", type: "int(11)", nullable: true),
                    SoundCardID = table.Column<int>(name: "Sound Card ID", type: "int(11)", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parts", x => x.ID);
                    table.ForeignKey(
                        name: "parts_ibfk_2",
                        column: x => x.HardDriveID,
                        principalTable: "hard drive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "parts_ibfk_3",
                        column: x => x.RAMID,
                        principalTable: "ram",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "parts_ibfk_4",
                        column: x => x.SecondaryDriveID,
                        principalTable: "secondary drives",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "parts_ibfk_5",
                        column: x => x.SoundCardID,
                        principalTable: "sound card",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "parts_ibfk_6",
                        column: x => x.VideoCardID,
                        principalTable: "video card",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "parts_ibfk_7",
                        column: x => x.DeviceHistoryID,
                        principalTable: "history",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "parts_ibfk_8",
                        column: x => x.OriginalDeviceID,
                        principalTable: "device information",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateIndex(
                name: "device information_ibfk_3",
                table: "device information",
                column: "Installed Software (01)");

            migrationBuilder.CreateIndex(
                name: "Device Type ID",
                table: "device information",
                column: "Device Type ID");

            migrationBuilder.CreateIndex(
                name: "Installed Software (02)",
                table: "device information",
                column: "Installed Software (02)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (03)",
                table: "device information",
                column: "Installed Software (03)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (04)",
                table: "device information",
                column: "Installed Software (04)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (05)",
                table: "device information",
                column: "Installed Software (05)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (06)",
                table: "device information",
                column: "Installed Software (06)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (07)",
                table: "device information",
                column: "Installed Software (07)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (08)",
                table: "device information",
                column: "Installed Software (08)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (09)",
                table: "device information",
                column: "Installed Software (09)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (10)",
                table: "device information",
                column: "Installed Software (10)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (11)",
                table: "device information",
                column: "Installed Software (11)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (12)",
                table: "device information",
                column: "Installed Software (12)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (13)",
                table: "device information",
                column: "Installed Software (13)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (14)",
                table: "device information",
                column: "Installed Software (14)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (15)",
                table: "device information",
                column: "Installed Software (15)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (16)",
                table: "device information",
                column: "Installed Software (16)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (17)",
                table: "device information",
                column: "Installed Software (17)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (18)",
                table: "device information",
                column: "Installed Software (18)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (19)",
                table: "device information",
                column: "Installed Software (19)");

            migrationBuilder.CreateIndex(
                name: "Installed Software (20)",
                table: "device information",
                column: "Installed Software (20)");

            migrationBuilder.CreateIndex(
                name: "Owner/Location",
                table: "device information",
                column: "Owner/Location");

            migrationBuilder.CreateIndex(
                name: "Device ID",
                table: "display monitors",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device ID1",
                table: "ethernet/network",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device ID2",
                table: "hard drive",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device ID3",
                table: "history",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Owner",
                table: "history",
                column: "Past Owner(s)");

            migrationBuilder.CreateIndex(
                name: "Hard Drive ID",
                table: "modifications",
                column: "Hard Drive ID");

            migrationBuilder.CreateIndex(
                name: "Processor ID",
                table: "modifications",
                column: "Processor ID");

            migrationBuilder.CreateIndex(
                name: "RAM ID",
                table: "modifications",
                column: "RAM ID");

            migrationBuilder.CreateIndex(
                name: "Secondary Drive ID",
                table: "modifications",
                column: "Secondary Drive ID");

            migrationBuilder.CreateIndex(
                name: "Sound Card ID",
                table: "modifications",
                column: "Sound Card ID");

            migrationBuilder.CreateIndex(
                name: "Video Card ID",
                table: "modifications",
                column: "Video Card ID");

            migrationBuilder.CreateIndex(
                name: "Owner/Location1",
                table: "other hardware",
                column: "Owner/Location");

            migrationBuilder.CreateIndex(
                name: "Video Card ID1",
                table: "outputs",
                column: "Video Card ID");

            migrationBuilder.CreateIndex(
                name: "Device ID5",
                table: "owner/location",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device History ID",
                table: "parts",
                column: "Device History ID");

            migrationBuilder.CreateIndex(
                name: "Hard Drive ID1",
                table: "parts",
                column: "Hard Drive ID");

            migrationBuilder.CreateIndex(
                name: "Original Device ID",
                table: "parts",
                column: "Original Device ID");

            migrationBuilder.CreateIndex(
                name: "RAM ID1",
                table: "parts",
                column: "RAM ID");

            migrationBuilder.CreateIndex(
                name: "Secondary y Drive ID",
                table: "parts",
                column: "Secondary Drive ID");

            migrationBuilder.CreateIndex(
                name: "Sound Card ID1",
                table: "parts",
                column: "Sound Card ID");

            migrationBuilder.CreateIndex(
                name: "Video Card ID2",
                table: "parts",
                column: "Video Card ID");

            migrationBuilder.CreateIndex(
                name: "Device ID4",
                table: "printers",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device ID6",
                table: "processsor",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device ID7",
                table: "ram",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device ID8",
                table: "secondary drives",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device ID9",
                table: "sound card",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device ID10",
                table: "video card",
                column: "Device ID");

            migrationBuilder.CreateIndex(
                name: "Device ID11",
                table: "warranty",
                column: "Device ID");

            migrationBuilder.AddForeignKey(
                name: "device information_ibfk_2",
                table: "device information",
                column: "Owner/Location",
                principalTable: "owner/location",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_1",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_10",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_11",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_12",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_13",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_14",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_15",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_16",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_17",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_18",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_19",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_20",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_21",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_22",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_3",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_4",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_5",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_6",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_7",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_8",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_9",
                table: "device information");

            migrationBuilder.DropForeignKey(
                name: "device information_ibfk_2",
                table: "device information");

            migrationBuilder.DropTable(
                name: "display monitors");

            migrationBuilder.DropTable(
                name: "ethernet/network");

            migrationBuilder.DropTable(
                name: "modifications");

            migrationBuilder.DropTable(
                name: "other hardware");

            migrationBuilder.DropTable(
                name: "outputs");

            migrationBuilder.DropTable(
                name: "parts");

            migrationBuilder.DropTable(
                name: "printers");

            migrationBuilder.DropTable(
                name: "warranty");

            migrationBuilder.DropTable(
                name: "processsor");

            migrationBuilder.DropTable(
                name: "hard drive");

            migrationBuilder.DropTable(
                name: "ram");

            migrationBuilder.DropTable(
                name: "secondary drives");

            migrationBuilder.DropTable(
                name: "sound card");

            migrationBuilder.DropTable(
                name: "video card");

            migrationBuilder.DropTable(
                name: "history");

            migrationBuilder.DropTable(
                name: "hardware device");

            migrationBuilder.DropTable(
                name: "software");

            migrationBuilder.DropTable(
                name: "owner/location");

            migrationBuilder.DropTable(
                name: "device information");
        }
    }
}
