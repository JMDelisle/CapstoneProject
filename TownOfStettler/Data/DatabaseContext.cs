using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TownOfStettler.Models;

namespace TownOfStettler.Data
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DeviceInformation> DeviceInformations { get; set; } = null!;
        public virtual DbSet<DisplayMonitor> DisplayMonitors { get; set; } = null!;
        public virtual DbSet<EthernetNetwork> EthernetNetworks { get; set; } = null!;
        public virtual DbSet<HardDrive> HardDrives { get; set; } = null!;
        public virtual DbSet<HardwareDevice> HardwareDevices { get; set; } = null!;
        public virtual DbSet<History> Histories { get; set; } = null!;
        public virtual DbSet<Modification> Modifications { get; set; } = null!;
        public virtual DbSet<OtherHardware> OtherHardwares { get; set; } = null!;
        public virtual DbSet<Output> Outputs { get; set; } = null!;
        public virtual DbSet<OwnerLocation> OwnerLocations { get; set; } = null!;
        public virtual DbSet<Part> Parts { get; set; } = null!;
        public virtual DbSet<Printer> Printers { get; set; } = null!;
        public virtual DbSet<Processsor> Processsors { get; set; } = null!;
        public virtual DbSet<Ram> Rams { get; set; } = null!;
        public virtual DbSet<SecondaryDrive> SecondaryDrives { get; set; } = null!;
        public virtual DbSet<Software> Softwares { get; set; } = null!;
        public virtual DbSet<SoundCard> SoundCards { get; set; } = null!;
        public virtual DbSet<VideoCard> VideoCards { get; set; } = null!;
        public virtual DbSet<Warranty> Warranties { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;database=town_of_stettler_computer_inventory", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<DeviceInformation>(entity =>
            {
                entity.ToTable("device information");

                entity.HasIndex(e => e.DeviceTypeId, "Device Type ID");

                entity.HasIndex(e => e.InstalledSoftware02, "Installed Software (02)");

                entity.HasIndex(e => e.InstalledSoftware03, "Installed Software (03)");

                entity.HasIndex(e => e.InstalledSoftware04, "Installed Software (04)");

                entity.HasIndex(e => e.InstalledSoftware05, "Installed Software (05)");

                entity.HasIndex(e => e.InstalledSoftware06, "Installed Software (06)");

                entity.HasIndex(e => e.InstalledSoftware07, "Installed Software (07)");

                entity.HasIndex(e => e.InstalledSoftware08, "Installed Software (08)");

                entity.HasIndex(e => e.InstalledSoftware09, "Installed Software (09)");

                entity.HasIndex(e => e.InstalledSoftware10, "Installed Software (10)");

                entity.HasIndex(e => e.InstalledSoftware11, "Installed Software (11)");

                entity.HasIndex(e => e.InstalledSoftware12, "Installed Software (12)");

                entity.HasIndex(e => e.InstalledSoftware13, "Installed Software (13)");

                entity.HasIndex(e => e.InstalledSoftware14, "Installed Software (14)");

                entity.HasIndex(e => e.InstalledSoftware15, "Installed Software (15)");

                entity.HasIndex(e => e.InstalledSoftware16, "Installed Software (16)");

                entity.HasIndex(e => e.InstalledSoftware17, "Installed Software (17)");

                entity.HasIndex(e => e.InstalledSoftware18, "Installed Software (18)");

                entity.HasIndex(e => e.InstalledSoftware19, "Installed Software (19)");

                entity.HasIndex(e => e.InstalledSoftware20, "Installed Software (20)");

                entity.HasIndex(e => e.OwnerLocation, "Owner/Location");

                entity.HasIndex(e => e.InstalledSoftware01, "device information_ibfk_3");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Device Type ID");

                entity.Property(e => e.InstalledSoftware01)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (01)");

                entity.Property(e => e.InstalledSoftware02)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (02)");

                entity.Property(e => e.InstalledSoftware03)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (03)");

                entity.Property(e => e.InstalledSoftware04)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (04)");

                entity.Property(e => e.InstalledSoftware05)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (05)");

                entity.Property(e => e.InstalledSoftware06)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (06)");

                entity.Property(e => e.InstalledSoftware07)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (07)");

                entity.Property(e => e.InstalledSoftware08)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (08)");

                entity.Property(e => e.InstalledSoftware09)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (09)");

                entity.Property(e => e.InstalledSoftware10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (10)");

                entity.Property(e => e.InstalledSoftware11)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (11)");

                entity.Property(e => e.InstalledSoftware12)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (12)");

                entity.Property(e => e.InstalledSoftware13)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (13)");

                entity.Property(e => e.InstalledSoftware14)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (14)");

                entity.Property(e => e.InstalledSoftware15)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (15)");

                entity.Property(e => e.InstalledSoftware16)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (16)");

                entity.Property(e => e.InstalledSoftware17)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (17)");

                entity.Property(e => e.InstalledSoftware18)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (18)");

                entity.Property(e => e.InstalledSoftware19)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (19)");

                entity.Property(e => e.InstalledSoftware20)
                    .HasColumnType("int(11)")
                    .HasColumnName("Installed Software (20)");

                entity.Property(e => e.ModelNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Model Number");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OperatingSystem)
                    .HasMaxLength(30)
                    .HasColumnName("Operating System");

                entity.Property(e => e.OwnerLocation)
                    .HasColumnType("int(11)")
                    .HasColumnName("Owner/Location");

                entity.Property(e => e.PowerSupply)
                    .HasMaxLength(75)
                    .HasColumnName("Power Supply");

                entity.Property(e => e.PurchaseDate).HasColumnName("Purchase Date");

                entity.Property(e => e.PurchasePrice)
                    .HasPrecision(6, 2)
                    .HasColumnName("Purchase Price");

                entity.Property(e => e.PurchaseStore)
                    .HasMaxLength(30)
                    .HasColumnName("Purchase Store");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(30)
                    .HasColumnName("Serial Number");

                entity.Property(e => e.TosNumber)
                    .HasMaxLength(25)
                    .HasColumnName("TOS Number");

                entity.HasOne(d => d.DeviceType)
                    .WithMany(p => p.DeviceInformations)
                    .HasForeignKey(d => d.DeviceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("device information_ibfk_1");

                entity.HasOne(d => d.InstalledSoftware01Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware01Navigations)
                    .HasForeignKey(d => d.InstalledSoftware01)
                    .HasConstraintName("device information_ibfk_3");

                entity.HasOne(d => d.InstalledSoftware02Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware02Navigations)
                    .HasForeignKey(d => d.InstalledSoftware02)
                    .HasConstraintName("device information_ibfk_4");

                entity.HasOne(d => d.InstalledSoftware03Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware03Navigations)
                    .HasForeignKey(d => d.InstalledSoftware03)
                    .HasConstraintName("device information_ibfk_5");

                entity.HasOne(d => d.InstalledSoftware04Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware04Navigations)
                    .HasForeignKey(d => d.InstalledSoftware04)
                    .HasConstraintName("device information_ibfk_6");

                entity.HasOne(d => d.InstalledSoftware05Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware05Navigations)
                    .HasForeignKey(d => d.InstalledSoftware05)
                    .HasConstraintName("device information_ibfk_7");

                entity.HasOne(d => d.InstalledSoftware06Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware06Navigations)
                    .HasForeignKey(d => d.InstalledSoftware06)
                    .HasConstraintName("device information_ibfk_8");

                entity.HasOne(d => d.InstalledSoftware07Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware07Navigations)
                    .HasForeignKey(d => d.InstalledSoftware07)
                    .HasConstraintName("device information_ibfk_9");

                entity.HasOne(d => d.InstalledSoftware08Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware08Navigations)
                    .HasForeignKey(d => d.InstalledSoftware08)
                    .HasConstraintName("device information_ibfk_10");

                entity.HasOne(d => d.InstalledSoftware09Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware09Navigations)
                    .HasForeignKey(d => d.InstalledSoftware09)
                    .HasConstraintName("device information_ibfk_11");

                entity.HasOne(d => d.InstalledSoftware10Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware10Navigations)
                    .HasForeignKey(d => d.InstalledSoftware10)
                    .HasConstraintName("device information_ibfk_12");

                entity.HasOne(d => d.InstalledSoftware11Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware11Navigations)
                    .HasForeignKey(d => d.InstalledSoftware11)
                    .HasConstraintName("device information_ibfk_13");

                entity.HasOne(d => d.InstalledSoftware12Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware12Navigations)
                    .HasForeignKey(d => d.InstalledSoftware12)
                    .HasConstraintName("device information_ibfk_14");

                entity.HasOne(d => d.InstalledSoftware13Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware13Navigations)
                    .HasForeignKey(d => d.InstalledSoftware13)
                    .HasConstraintName("device information_ibfk_15");

                entity.HasOne(d => d.InstalledSoftware14Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware14Navigations)
                    .HasForeignKey(d => d.InstalledSoftware14)
                    .HasConstraintName("device information_ibfk_16");

                entity.HasOne(d => d.InstalledSoftware15Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware15Navigations)
                    .HasForeignKey(d => d.InstalledSoftware15)
                    .HasConstraintName("device information_ibfk_17");

                entity.HasOne(d => d.InstalledSoftware16Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware16Navigations)
                    .HasForeignKey(d => d.InstalledSoftware16)
                    .HasConstraintName("device information_ibfk_18");

                entity.HasOne(d => d.InstalledSoftware17Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware17Navigations)
                    .HasForeignKey(d => d.InstalledSoftware17)
                    .HasConstraintName("device information_ibfk_19");

                entity.HasOne(d => d.InstalledSoftware18Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware18Navigations)
                    .HasForeignKey(d => d.InstalledSoftware18)
                    .HasConstraintName("device information_ibfk_20");

                entity.HasOne(d => d.InstalledSoftware19Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware19Navigations)
                    .HasForeignKey(d => d.InstalledSoftware19)
                    .HasConstraintName("device information_ibfk_21");

                entity.HasOne(d => d.InstalledSoftware20Navigation)
                    .WithMany(p => p.DeviceInformationInstalledSoftware20Navigations)
                    .HasForeignKey(d => d.InstalledSoftware20)
                    .HasConstraintName("device information_ibfk_22");

                entity.HasOne(d => d.OwnerLocationNavigation)
                    .WithMany(p => p.DeviceInformations)
                    .HasForeignKey(d => d.OwnerLocation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("device information_ibfk_2");
            });

            //  modelBuilder.Entity<DeviceInformation>().HasData(
            //new DeviceInformation
            //{
            //    Id = 1,
            //    DeviceTypeId = 1,
            //    OwnerLocation = 1,
            //    TosNumber = " TOS0705C",
            //    SerialNumber = "NA",
            //    ModelNumber = "NA",
            //    PurchaseStore = "NA",
            //    PurchasePrice = 3594,
            //    PurchaseDate = 2007,
            //    OperatingSystem = "Windows 2003 Server - Standard",
            //    Destroyed = 0,
            //    Notes = "NA",
            //    InstalledSoftware01 = 0

            //},
            //    new DeviceInformation
            //    {
            //        Id = 2,
            //        DeviceTypeId = 2,
            //        OwnerLocation = 2,
            //        TosNumber = "TOS0805D",
            //        SerialNumber = "NA",
            //        ModelNumber = "NA",
            //        PurchaseStore = "NA",
            //        PurchasePrice = 7085,
            //        PurchaseDate = "May 2008",
            //        OperatingSystem = "Microsoft Windows 2008 Server w/downgrade Windows Server 2003 SP2 32 BIT X64, Microsoft Excel 2007",
            //        Destroyed = 0,
            //        Notes = "NA",


            //    },
            //    new DeviceInformation
            //    {
            //        Id = 3,
            //        DeviceTypeId = 3,
            //        OwnerLocation = 3,
            //        TosNumber = "TOSL0907B",
            //        SerialNumber = "NA",
            //        ModelNumber = "NA",
            //        PurchaseStore = "NA",
            //        PurchasePrice = 964,
            //        PurchaseDate = "July 2009",
            //        OperatingSystem = "Windows Vista Business, Microsoft Office 2007 Small Business",
            //        Destroyed = 1,
            //        Notes = "NA",

            //    },
            //    new DeviceInformation
            //    {
            //        Id = 4,
            //        DeviceTypeId = 4,
            //        OwnerLocation = 4,
            //        TosNumber = "  TOSL0907C",
            //        SerialNumber = "NA",
            //        ModelNumber = "NA",
            //        PurchaseStore = "NA",
            //        PurchasePrice = 964,
            //        PurchaseDate = "July 2009",
            //        OperatingSystem = "",
            //        Destroyed = 1,
            //        Notes = "NA",

            //    });




            modelBuilder.Entity<DisplayMonitor>(entity =>
            {
                entity.ToTable("display monitors");

                entity.HasIndex(e => e.DeviceId, "Device ID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Device ID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.NumberOfOutputs)
                    .HasColumnType("int(11)")
                    .HasColumnName("Number of Outputs");

                entity.Property(e => e.OutputType)
                    .HasMaxLength(10)
                    .HasColumnName("Output Type");

                entity.Property(e => e.RefreshRateHz)
                    .HasColumnType("int(3)")
                    .HasColumnName("Refresh Rate (Hz)");

                entity.Property(e => e.Resolution).HasMaxLength(15);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Serial Number");

                entity.Property(e => e.ViewSizeInches)
                    .HasColumnType("int(3)")
                    .HasColumnName("View Size (Inches)");

                entity.Property(e => e.ViewType)
                    .HasMaxLength(10)
                    .HasColumnName("View Type");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.DisplayMonitors)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("display monitors_ibfk_1");
            });

            //modelBuilder.Entity<DisplayMonitor>().HasData(
            //   new DisplayMonitor
            //   {
            //       Id = 1,
            //       DeviceId = 1,
            //       ViewSizeInches = 15,
            //       ViewType = "LG L15105",
            //       Resolution = "NA",
            //       RefreshRateHz = ,
            //       SerialNumber = "410MXFV0S379",
            //       OutputType = "NA",
            //       NumberOfOutputs = 1,
            //       Notes = "NA",
            //   },
            //    new DisplayMonitor
            //    {
            //        Id = 2,
            //        DeviceId = 2,
            //        ViewSizeInches = 19,
            //        ViewType = "Samsung 940B",
            //        Resolution = "NA",
            //        RefreshRateHz = ,
            //        SerialNumber = "HA19HVEL211011M",
            //        OutputType = "DVI 8ms 700:1",
            //        NumberOfOutputs = 1,
            //        Notes = "NA",
            //    },
            //     new DisplayMonitor
            //     {
            //         Id = 3,
            //         DeviceId = 3,
            //         ViewSizeInches = 17,
            //         ViewType = "Dell",
            //         Resolution = "NA",
            //         RefreshRateHz = ,
            //         SerialNumber = "CN-0FJ181-64180-67D-7GNS",
            //         OutputType = "",
            //         NumberOfOutputs = 1,
            //         Notes = "NA",
            //     },
            //     new DisplayMonitor
            //     {
            //         Id = 4,
            //         DeviceId = 4,
            //         ViewSizeInches = 20,
            //         ViewType = "Dell",
            //         Resolution = "",
            //         RefreshRateHz = ,
            //         SerialNumber = "MX-OHF730-46634-73F-1VCL",
            //         OutputType = "2007WFP Wide Digital Flat",
            //         NumberOfOutputs = 1,
            //         Notes = "NA"
            //     });

            modelBuilder.Entity<EthernetNetwork>(entity =>
            {
                entity.ToTable("ethernet/network");

                entity.HasIndex(e => e.DeviceId, "Device ID1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Device ID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(30)
                    .HasColumnName("Serial Number");

                entity.Property(e => e.Speed).HasMaxLength(20);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.EthernetNetworks)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ethernet/network_ibfk_1");
            });

            //modelBuilder.Entity<EthernetNetwork>().HasData(
            //   new EthernetNetwork
            //   {
            //       Id = 1,
            //       DeviceId = 5,
            //       Speed = ,
            //       Wireless = ,
            //       SerialNumber = "",
            //       Destroyed = ,
            //       Notes = "NA",
            //   },
            //    new EthernetNetwork
            //    {
            //        Id = 2,
            //        DeviceId = 5,
            //        Speed = ,
            //        Wireless = ,
            //        SerialNumber = "",
            //        Destroyed = ,
            //        Notes = "NA",
            //    },
            //     new EthernetNetwork
            //     {
            //         Id = 3,
            //         DeviceId = 5,
            //         SerialNumber = "",
            //         Speed = ,
            //         Wireless = ,
            //         Destroyed = ,
            //         Notes = "NA",
            //     },
            //     new EthernetNetwork
            //     {
            //         Id = 4,
            //         DeviceId = 5,
            //         Speed = ,
            //         Wireless = ,
            //         SerialNumber = "",
            //         Destroyed = ,
            //         Notes = "NA"
            //     });

            modelBuilder.Entity<HardDrive>(entity =>
            {
                entity.ToTable("hard drive");

                entity.HasIndex(e => e.DeviceId, "Device ID2");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Device ID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(30)
                    .HasColumnName("Serial Number");

                entity.Property(e => e.SizeGb)
                    .HasMaxLength(7)
                    .HasColumnName("Size (Gb)");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.HardDrives)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("hard drive_ibfk_1");
            });

            //modelBuilder.Entity<HardDrive>().HasData(
            //new HardDrive
            //{
            //    Id = 1,
            //    DeviceId = ,
            //    Type = ,
            //    SizeGb = ,
            //    SerialNumber = "",
            //    Destroyed = ,
            //    Notes = "NA"

            //},
            //new HardDrive
            //{
            //    Id = 1,
            //    DeviceId = ,
            //    Type = ,
            //    SizeGb = ,
            //    SerialNumber = "",
            //    Destroyed = ,
            //    Notes = "NA"

            //},
            //new HardDrive
            //{
            //    Id = 1,
            //    DeviceId = ,
            //    Type = ,
            //    SizeGb = ,
            //    SerialNumber = "",
            //    Destroyed = ,
            //    Notes = "NA"

            //},
            //new HardDrive
            //{
            //    Id = 1,
            //    DeviceId = ,
            //    Type = ,
            //    SizeGb = ,
            //    SerialNumber = "",
            //    Destroyed = ,
            //    Notes = "NA"

            //});



            modelBuilder.Entity<HardwareDevice>(entity =>
            {
                entity.ToTable("hardware device");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.TypeOfHardware)
                    .HasMaxLength(10)
                    .HasColumnName("Type of Hardware");
            });

            // modelBuilder.Entity<HardwareDevice>().HasData(
            //new HardwareDevice
            //{
            //    Id = 1,
            //    TypeOfHardware = ,

            //},
            //new HardwareDevice
            //{
            //    Id = 1,
            //    TypeOfHardware = ,

            //},
            //new HardwareDevice
            //{
            //    Id = 1,
            //    TypeOfHardware = ,

            //},
            //new HardwareDevice
            //{
            //    Id = 1,
            //    TypeOfHardware = ,

            //});

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("history");

                entity.HasIndex(e => e.DeviceId, "Device ID3");

                entity.HasIndex(e => e.PastOwnerS, "Owner");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.DateOfChanges).HasColumnName("Date of Changes");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Device ID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OutOfServiceDate).HasColumnName("Out of Service Date");

                entity.Property(e => e.PartsChanged)
                    .HasColumnType("int(11)")
                    .HasColumnName("Parts Changed");

                entity.Property(e => e.PartsRemoved).HasColumnName("Parts Removed");

                entity.Property(e => e.PastOwnerS)
                    .HasColumnType("int(11)")
                    .HasColumnName("Past Owner(s)");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("history_ibfk_1");

                entity.HasOne(d => d.PastOwnerSNavigation)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.PastOwnerS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("history_ibfk_2");
            });

            //modelBuilder.Entity<History>().HasData(
            //new History
            //{
            //    Id = 1,
            //    DeviceId = ,
            //    PartsChanged = ,
            //    PastOwnerS = ,
            //    Wiped = ,
            //    PartsRemoved = ,
            //    DateOfChanges = ,
            //    OutOfServiceDate = ,
            //    Notes = ,
            //},
            //new History
            //{
            //    Id = 1,
            //    DeviceId = ,
            //    PartsChanged = ,
            //    PastOwnerS = ,
            //    Wiped = ,
            //    PartsRemoved = ,
            //    DateOfChanges = ,
            //    OutOfServiceDate = ,
            //    Notes = ,
            //},
            //new History
            //{
            //    Id = 1,
            //    DeviceId = ,
            //    PartsChanged = ,
            //    PastOwnerS = ,
            //    Wiped = ,
            //    PartsRemoved = ,
            //    DateOfChanges = ,
            //    OutOfServiceDate = ,
            //    Notes = ,
            //},
            //new History
            //{
            //    Id = 1,
            //    DeviceId = ,
            //    PartsChanged = ,
            //    PastOwnerS = ,
            //    Wiped = ,
            //    PartsRemoved = ,
            //    DateOfChanges = ,
            //    OutOfServiceDate = ,
            //    Notes = ,
            //});


            modelBuilder.Entity<Modification>(entity =>
             {
                 entity.ToTable("modifications");

                 entity.HasIndex(e => e.HardDriveId, "Hard Drive ID");

                 entity.HasIndex(e => e.ProcessorId, "Processor ID");

                 entity.HasIndex(e => e.RamId, "RAM ID");

                 entity.HasIndex(e => e.SecondaryDriveId, "Secondary Drive ID");

                 entity.HasIndex(e => e.SoundCardId, "Sound Card ID");

                 entity.HasIndex(e => e.VideoCardId, "Video Card ID");

                 entity.Property(e => e.Id)
                     .HasColumnType("int(11)")
                     .HasColumnName("ID");

                 entity.Property(e => e.HardDriveId)
                     .HasColumnType("int(11)")
                     .HasColumnName("Hard Drive ID");

                 entity.Property(e => e.Notes).HasColumnType("text");

                 entity.Property(e => e.ProcessorId)
                     .HasColumnType("int(11)")
                     .HasColumnName("Processor ID");

                 entity.Property(e => e.RamId)
                     .HasColumnType("int(11)")
                     .HasColumnName("RAM ID");

                 entity.Property(e => e.SecondaryDriveId)
                     .HasColumnType("int(11)")
                     .HasColumnName("Secondary Drive ID");

                 entity.Property(e => e.SoundCardId)
                     .HasColumnType("int(11)")
                     .HasColumnName("Sound Card ID");

                 entity.Property(e => e.VideoCardId)
                     .HasColumnType("int(11)")
                     .HasColumnName("Video Card ID");

                 entity.HasOne(d => d.HardDrive)
                     .WithMany(p => p.Modifications)
                     .HasForeignKey(d => d.HardDriveId)
                     .HasConstraintName("modifications_ibfk_1");

                 entity.HasOne(d => d.Processor)
                     .WithMany(p => p.Modifications)
                     .HasForeignKey(d => d.ProcessorId)
                     .HasConstraintName("modifications_ibfk_2");

                 entity.HasOne(d => d.Ram)
                     .WithMany(p => p.Modifications)
                     .HasForeignKey(d => d.RamId)
                     .HasConstraintName("modifications_ibfk_3");

                 entity.HasOne(d => d.SecondaryDrive)
                     .WithMany(p => p.Modifications)
                     .HasForeignKey(d => d.SecondaryDriveId)
                     .HasConstraintName("modifications_ibfk_4");

                 entity.HasOne(d => d.SoundCard)
                     .WithMany(p => p.Modifications)
                     .HasForeignKey(d => d.SoundCardId)
                     .HasConstraintName("modifications_ibfk_5");

                 entity.HasOne(d => d.VideoCard)
                     .WithMany(p => p.Modifications)
                     .HasForeignKey(d => d.VideoCardId)
                     .HasConstraintName("modifications_ibfk_6");
             });

            // modelBuilder.Entity<Modification>().HasData(
            //new Modification
            //{
            //    Id = 1,
            //    ProcessorId = ,
            //    RamId = ,
            //    HardDriveId = ,
            //    SecondaryDriveId = ,
            //    SoundCardId = ,
            //    VideoCardId  = ,
            //    Notes = ,

            //},
            //   new Modification
            //   {
            //       Id = 1,
            //       ProcessorId = ,
            //       RamId = ,
            //       HardDriveId = ,
            //       SecondaryDriveId = ,
            //       SoundCardId = ,
            //       VideoCardId = ,
            //       Notes = ,

            //   },
            //      new Modification
            //      {
            //          Id = 1,
            //          ProcessorId = ,
            //          RamId = ,
            //          HardDriveId = ,
            //          SecondaryDriveId = ,
            //          SoundCardId = ,
            //          VideoCardId = ,
            //          Notes = ,

            //      },
            //         new Modification
            //         {
            //             Id = 1,
            //             ProcessorId = ,
            //             RamId = ,
            //             HardDriveId = ,
            //             SecondaryDriveId = ,
            //             SoundCardId = ,
            //             VideoCardId = ,
            //             Notes = ,

            //         });


            modelBuilder.Entity<OtherHardware>(entity =>
             {
                 entity.ToTable("other hardware");

                 entity.HasIndex(e => e.OwnerLocation, "Owner/Location1");

                 entity.Property(e => e.Id)
                     .HasColumnType("int(11)")
                     .HasColumnName("ID");

                 entity.Property(e => e.Notes).HasColumnType("text");

                 entity.Property(e => e.OwnerLocation)
                     .HasColumnType("int(11)")
                     .HasColumnName("Owner/Location");

                 entity.Property(e => e.TosNumber)
                     .HasMaxLength(20)
                     .HasColumnName("TOS Number");

                 entity.Property(e => e.Type).HasColumnType("int(11)");

                 entity.HasOne(d => d.OwnerLocationNavigation)
                     .WithMany(p => p.OtherHardwares)
                     .HasForeignKey(d => d.OwnerLocation)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("other hardware_ibfk_1");
             });

            // modelBuilder.Entity<OtherHardware>().HasData(
            //new OtherHardware
            //{ 
            //    Id = 1,
            //    OwnerLocation = "",
            //    TosNumber = "",
            //    Type = "",
            //    Destroyed = ,
            //    Notes = ,
            //},
            //    new OtherHardware
            //    {
            //        Id = 1,
            //        OwnerLocation = "",
            //        TosNumber = "",
            //        Type = "",
            //        Destroyed = ,
            //        Notes = ,
            //    },
            //        new OtherHardware
            //        {
            //            Id = 1,
            //            OwnerLocation = "",
            //            TosNumber = "",
            //            Type = "",
            //            Destroyed = ,
            //            Notes = ,
            //        },
            //            new OtherHardware
            //            {
            //                Id = 1,
            //                OwnerLocation = "",
            //                TosNumber = "",
            //                Type = "",
            //                Destroyed = ,
            //                Notes = ,
            //            });


            modelBuilder.Entity<Output>(entity =>
            {
                entity.HasKey(e => e.Type)
                    .HasName("PRIMARY");

                entity.ToTable("outputs");

                entity.HasIndex(e => e.VideoCardId, "Video Card ID1");

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.NumberOfOutputs)
                    .HasColumnType("int(2)")
                    .HasColumnName("Number of Outputs");

                entity.Property(e => e.VideoCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Video Card ID");

                entity.HasOne(d => d.VideoCard)
                    .WithMany(p => p.Outputs)
                    .HasForeignKey(d => d.VideoCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("outputs_ibfk_1");
            });

        //    modelBuilder.Entity<Output>().HasData(
        //new Output
        //{
        //    Type = "",
        //    VideoCardId = ,
        //    NumberOfOutputs = ,
        //    Notes = "",
        //},
        //  new Output
        //  {
        //      Type = "",
        //      VideoCardId = ,
        //      NumberOfOutputs = ,
        //      Notes = "",
        //  },
        //    new Output
        //    {
        //        Type = "",
        //        VideoCardId = ,
        //        NumberOfOutputs = ,
        //        Notes = "",
        //    },
        //      new Output
        //      {
        //          Type = "",
        //          VideoCardId = ,
        //          NumberOfOutputs = ,
        //          Notes = "",
        //      });



            modelBuilder.Entity<OwnerLocation>(entity =>
               {
                   entity.ToTable("owner/location");

                   entity.HasIndex(e => e.DeviceId, "Device ID5");

                   entity.Property(e => e.Id)
                       .HasColumnType("int(11)")
                       .HasColumnName("ID");

                   entity.Property(e => e.Address).HasMaxLength(75);

                   entity.Property(e => e.DeviceId)
                       .HasColumnType("int(11)")
                       .HasColumnName("Device ID");

                   entity.Property(e => e.Name).HasMaxLength(60);

                   entity.Property(e => e.Notes).HasColumnType("text");

                   entity.Property(e => e.PhoneNumber)
                       .HasMaxLength(14)
                       .HasColumnName("Phone Number");

                   entity.HasOne(d => d.Device)
                       .WithMany(p => p.OwnerLocations)
                       .HasForeignKey(d => d.DeviceId)
                       .OnDelete(DeleteBehavior.ClientSetNull)
                       .HasConstraintName("owner/location_ibfk_1");
               });

      //      modelBuilder.Entity<OwnerLocation>().HasData(
      //new OwnerLocation
      //{
      //    Id = 1,
      //    DeviceId = ,
      //    Name = "",
      //    Address = "",
      //    PhoneNumber = ,
      //    Notes = "",

      //},
      //   new OwnerLocation
      //   {
      //       Id = 1,
      //       DeviceId = ,
      //       Name = "",
      //       Address = "",
      //       PhoneNumber = ,
      //       Notes = "",

      //   },
      //      new OwnerLocation
      //      {
      //          Id = 1,
      //          DeviceId = ,
      //          Name = "",
      //          Address = "",
      //          PhoneNumber = ,
      //          Notes = "",

      //      },
      //       new OwnerLocation
      //       {
      //           Id = 1,
      //           DeviceId = ,
      //           Name = "",
      //           Address = "",
      //           PhoneNumber = ,
      //           Notes = "",
      //       });

            modelBuilder.Entity<Part>(entity =>
              {
                  entity.ToTable("parts");

                  entity.HasIndex(e => e.DeviceHistoryId, "Device History ID");

                  entity.HasIndex(e => e.HardDriveId, "Hard Drive ID1");

                  entity.HasIndex(e => e.OriginalDeviceId, "Original Device ID");

                  entity.HasIndex(e => e.RamId, "RAM ID1");

                  entity.HasIndex(e => e.SecondaryDriveId, "Secondary y Drive ID");

                  entity.HasIndex(e => e.SoundCardId, "Sound Card ID1");

                  entity.HasIndex(e => e.VideoCardId, "Video Card ID2");

                  entity.Property(e => e.Id)
                      .HasColumnType("int(11)")
                      .HasColumnName("ID");

                  entity.Property(e => e.DeviceHistoryId)
                      .HasColumnType("int(11)")
                      .HasColumnName("Device History ID");

                  entity.Property(e => e.HardDriveId)
                      .HasColumnType("int(11)")
                      .HasColumnName("Hard Drive ID");

                  entity.Property(e => e.Notes).HasColumnType("text");

                  entity.Property(e => e.OriginalDeviceId)
                      .HasColumnType("int(11)")
                      .HasColumnName("Original Device ID");

                  entity.Property(e => e.RamId)
                      .HasColumnType("int(11)")
                      .HasColumnName("RAM ID");

                  entity.Property(e => e.SecondaryDriveId)
                      .HasColumnType("int(11)")
                      .HasColumnName("Secondary Drive ID");

                  entity.Property(e => e.SoundCardId)
                      .HasColumnType("int(11)")
                      .HasColumnName("Sound Card ID");

                  entity.Property(e => e.VideoCardId)
                      .HasColumnType("int(11)")
                      .HasColumnName("Video Card ID");

                  entity.HasOne(d => d.DeviceHistory)
                      .WithMany(p => p.Parts)
                      .HasForeignKey(d => d.DeviceHistoryId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("parts_ibfk_7");

                  entity.HasOne(d => d.HardDrive)
                      .WithMany(p => p.Parts)
                      .HasForeignKey(d => d.HardDriveId)
                      .HasConstraintName("parts_ibfk_2");

                  entity.HasOne(d => d.OriginalDevice)
                      .WithMany(p => p.Parts)
                      .HasForeignKey(d => d.OriginalDeviceId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("parts_ibfk_8");

                  entity.HasOne(d => d.Ram)
                      .WithMany(p => p.Parts)
                      .HasForeignKey(d => d.RamId)
                      .HasConstraintName("parts_ibfk_3");

                  entity.HasOne(d => d.SecondaryDrive)
                      .WithMany(p => p.Parts)
                      .HasForeignKey(d => d.SecondaryDriveId)
                      .HasConstraintName("parts_ibfk_4");

                  entity.HasOne(d => d.SoundCard)
                      .WithMany(p => p.Parts)
                      .HasForeignKey(d => d.SoundCardId)
                      .HasConstraintName("parts_ibfk_5");

                  entity.HasOne(d => d.VideoCard)
                      .WithMany(p => p.Parts)
                      .HasForeignKey(d => d.VideoCardId)
                      .HasConstraintName("parts_ibfk_6");
              });

            //modelBuilder.Entity<Part>().HasData(
            //    new Part
            //    {
            //        Id = 1,
            //        OriginalDeviceId = ,
            //        DeviceHistoryId = ,
            //        RamId = ,
            //        HardDriveId = ,
            //        SecondaryDriveId = ,
            //        VideoCardId = ,
            //        SoundCardId = ,
            //        Notes = "",
            //    },
            //     new Part
            //     {
            //         Id = 2,
            //         OriginalDeviceId = ,
            //         DeviceHistoryId = ,
            //         RamId = ,
            //         HardDriveId = ,
            //         SecondaryDriveId = ,
            //         VideoCardId = ,
            //         SoundCardId = ,
            //         Notes = "",
            //     },
            //     new Part
            //     {
            //         Id = 3,
            //         OriginalDeviceId = ,
            //         DeviceHistoryId = ,
            //         RamId = ,
            //         HardDriveId = ,
            //         SecondaryDriveId = ,
            //         VideoCardId = ,
            //         SoundCardId = ,
            //         Notes = "",
            //     },
            //     new Part
            //     {
            //         Id = 4,
            //         OriginalDeviceId = ,
            //         DeviceHistoryId = ,
            //         RamId = ,
            //         HardDriveId = ,
            //         SecondaryDriveId = ,
            //         VideoCardId = ,
            //         SoundCardId = ,
            //         Notes = "",
            //     });




            modelBuilder.Entity<Printer>(entity =>
            {
                entity.ToTable("printers");

                entity.HasIndex(e => e.DeviceId, "Device ID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.ConnectionType)
                    .HasMaxLength(15)
                    .HasColumnName("Connection Type");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Device ID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.Type).HasMaxLength(15);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Printers)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("printers_ibfk_1");
            });

            //modelBuilder.Entity<Printer>().HasData(
            //    new Printer
            //    {
            //        Id = 1,
            //        DeviceId = ,
            //        Type = "",
            //        ConnectionType = "",
            //        Notes = "",
            //    },
            //       new Printer
            //       {
            //           Id = 2,
            //           DeviceId = ,
            //           Type = "",
            //           ConnectionType = "",
            //           Notes = "",
            //       },
            //        new Printer
            //        {
            //            Id = 3,
            //            DeviceId = ,
            //            Type = "",
            //            ConnectionType = "",
            //            Notes = "",
            //        },
            //          new Printer
            //          {
            //              Id = 4,
            //              DeviceId = ,
            //              Type = "",
            //              ConnectionType = "",
            //              Notes = "",
            //          });





            modelBuilder.Entity<Processsor>(entity =>
            {
                entity.ToTable("processsor");

                entity.HasIndex(e => e.DeviceId, "Device ID6");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.CoreCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("Core Count");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Device ID");

                entity.Property(e => e.Generation).HasColumnType("int(11)");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(30)
                    .HasColumnName("Serial Number");

                entity.Property(e => e.SpeedGhz)
                    .HasPrecision(3, 3)
                    .HasColumnName("Speed (GHz)");

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Processsors)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("processsor_ibfk_1");
            });

           // modelBuilder.Entity<Processsor>().HasData(
           //new Processsor
           //{
           //    Id = 1,
           //    DeviceId = ,
           //    Type = "",
           //    SpeedGhz = ,
           //    SerialNumber = ,
           //    Generation = ,
           //    CoreCount = ,
           //    Destroyed = ,
           //    Notes = "",
           //},
           //new Processsor
           //{
           //    Id = 2,
           //    DeviceId = ,
           //    Type = "",
           //    SpeedGhz = ,
           //    SerialNumber = ,
           //    Generation = ,
           //    CoreCount = ,
           //    Destroyed = ,
           //    Notes = "",
           //},
           //new Processsor
           //{
           //    Id = 3,
           //    DeviceId = ,
           //    Type = "",
           //    SpeedGhz = ,
           //    SerialNumber = ,
           //    Generation = ,
           //    CoreCount = ,
           //    Destroyed = ,
           //    Notes = "",
           //},
           // new Processsor
           // {
           //     Id = 4,
           //     DeviceId = ,
           //     Type = "",
           //     SpeedGhz = ,
           //     SerialNumber = ,
           //     Generation = ,
           //     CoreCount = ,
           //     Destroyed = ,
           //     Notes = "",
           // });




            modelBuilder.Entity<Ram>(entity =>
            {
                entity.ToTable("ram");

                entity.HasIndex(e => e.DeviceId, "Device ID7");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Device ID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(30)
                    .HasColumnName("Serial Number");

                entity.Property(e => e.Size).HasMaxLength(10);

                entity.Property(e => e.SpeedMhz)
                    .HasColumnType("int(5)")
                    .HasColumnName("Speed (MHz)");

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Rams)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ram_ibfk_1");
            });

          //  modelBuilder.Entity<Ram>().HasData(
          //new Ram
          //{
          //    Id = 1,
          //    DeviceId = ,
          //    Type = "",
          //    Size = ,
          //    SpeedMhz = ,
          //    SerialNumber = ,
          //    Destroyed = ,
          //    Notes = "",
          //},
          //new Ram
          //{
          //    Id = 2,
          //    DeviceId = ,
          //    Type = "",
          //    Size = ,
          //    SpeedMhz = ,
          //    SerialNumber = ,
          //    Destroyed = ,
          //    Notes = "",
          //},
          // new Ram
          // {
          //     Id = 3,
          //     DeviceId = ,
          //     Type = "",
          //     Size = ,
          //     SpeedMhz = ,
          //     SerialNumber = ,
          //     Destroyed = ,
          //     Notes = "",
          // },
          //  new Ram
          //  {
          //      Id = 4,
          //      DeviceId = ,
          //      Type = "",
          //      Size = ,
          //      SpeedMhz = ,
          //      SerialNumber = ,
          //      Destroyed = ,
          //      Notes = "",
          //  });

            modelBuilder.Entity<SecondaryDrive>(entity =>
              {
                  entity.ToTable("secondary drives");

                  entity.HasIndex(e => e.DeviceId, "Device ID8");

                  entity.Property(e => e.Id)
                      .HasColumnType("int(11)")
                      .HasColumnName("ID");

                  entity.Property(e => e.DeviceId)
                      .HasColumnType("int(11)")
                      .HasColumnName("Device ID");

                  entity.Property(e => e.Notes).HasColumnType("text");

                  entity.Property(e => e.SerialNumber)
                      .HasMaxLength(30)
                      .HasColumnName("Serial Number");

                  entity.Property(e => e.Type).HasMaxLength(30);

                  entity.HasOne(d => d.Device)
                      .WithMany(p => p.SecondaryDrives)
                      .HasForeignKey(d => d.DeviceId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("secondary drives_ibfk_1");
              });

          //  modelBuilder.Entity<SecondaryDrive>().HasData(
          //new SecondaryDrive
          //{
          //    Id = 1,
          //    DeviceId = ,
          //    Type = "",
          //    Removable = ,
          //    SerialNumber = "",
          //    Destroyed = ,
          //    Notes = "",
          //},
          // new SecondaryDrive
          // {
          //     Id = 2,
          //     DeviceId = ,
          //     Type = "",
          //     Removable = ,
          //     SerialNumber = "",
          //     Destroyed = ,
          //     Notes = "",
          // },
          //  new SecondaryDrive
          //  {
          //      Id = 3,
          //      DeviceId = ,
          //      Type = "",
          //      Removable = ,
          //      SerialNumber = "",
          //      Destroyed = ,
          //      Notes = "",
          //  },
          //   new SecondaryDrive
          //   {
          //       Id = 4,
          //       DeviceId = ,
          //       Type = "",
          //       Removable = ,
          //       SerialNumber = "",
          //       Destroyed = ,
          //       Notes = "",
          //   });

            modelBuilder.Entity<Software>(entity =>
            {
                entity.ToTable("software");

                entity.Property(e => e.Id)
                    .HasColumnType("int(50)")
                    .HasColumnName("ID");

                entity.Property(e => e.AssociatedAccount)
                    .HasMaxLength(50)
                    .HasColumnName("Associated Account");

                entity.Property(e => e.DevicesAllowed)
                    .HasColumnType("int(11)")
                    .HasColumnName("Devices Allowed");

                entity.Property(e => e.EndOfSupportDate).HasColumnName("End of Support Date");

                entity.Property(e => e.ProductKey)
                    .HasMaxLength(60)
                    .HasColumnName("Product Key");

                entity.Property(e => e.PurchaseDate).HasColumnName("Purchase Date");

                entity.Property(e => e.PurchasePrice)
                    .HasPrecision(5, 2)
                    .HasColumnName("Purchase Price");

                entity.Property(e => e.SoftwareName)
                    .HasMaxLength(50)
                    .HasColumnName("Software Name");

                entity.Property(e => e.SubscriptionEndDate).HasColumnName("Subscription End Date");
            });

        //    modelBuilder.Entity<Software>().HasData(
        //new Software
        //{
        //    Id = 1,
        //    ProductKey = ,
        //    SoftwareName = "",
        //    AssociatedAccount = ,
        //    Subscription = ,
        //    SubscriptionEndDate = ,
        //    PurchaseDate = ,
        //    PurchasePrice = ,
        //    DevicesAllowed = ,
        //    EndOfSupportDate = ,
        //},
        //  new Software
        //  {
        //      Id = 2,
        //      ProductKey = ,
        //      SoftwareName = "",
        //      AssociatedAccount = ,
        //      Subscription = ,
        //      SubscriptionEndDate = ,
        //      PurchaseDate = ,
        //      PurchasePrice = ,
        //      DevicesAllowed = ,
        //      EndOfSupportDate = ,
        //  }, new Software
        //  {
        //      Id = 3,
        //      ProductKey = ,
        //      SoftwareName = "",
        //      AssociatedAccount = ,
        //      Subscription = ,
        //      SubscriptionEndDate = ,
        //      PurchaseDate = ,
        //      PurchasePrice = ,
        //      DevicesAllowed = ,
        //      EndOfSupportDate = ,
        //  },
        //    new Software
        //    {
        //        Id = 4,
        //        ProductKey = ,
        //        SoftwareName = "",
        //        AssociatedAccount = ,
        //        Subscription = ,
        //        SubscriptionEndDate = ,
        //        PurchaseDate = ,
        //        PurchasePrice = ,
        //        DevicesAllowed = ,
        //        EndOfSupportDate = ,
        //    });

            modelBuilder.Entity<SoundCard>(entity =>
              {
                  entity.ToTable("sound card");

                  entity.HasIndex(e => e.DeviceId, "Device ID9");

                  entity.Property(e => e.Id)
                      .HasColumnType("int(11)")
                      .HasColumnName("ID");

                  entity.Property(e => e.Brand).HasMaxLength(20);

                  entity.Property(e => e.DeviceId)
                      .HasColumnType("int(11)")
                      .HasColumnName("Device ID");

                  entity.Property(e => e.Notes).HasColumnType("text");

                  entity.HasOne(d => d.Device)
                      .WithMany(p => p.SoundCards)
                      .HasForeignKey(d => d.DeviceId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("sound card_ibfk_1");
              });

            //modelBuilder.Entity<SoundCard>().HasData(
            //new SoundCard
            //{
            //    Id = 1,
            //    DeviceId = ,
            //    Brand = "",
            //    Destroyed = ,
            //    Notes = "",
            //},
            //   new SoundCard
            //   {
            //       Id = 2,
            //       DeviceId = ,
            //       Brand = "",
            //       Destroyed = ,
            //       Notes = "",
            //   },
            //      new SoundCard
            //      {
            //          Id = 3,
            //          DeviceId = ,
            //          Brand = "",
            //          Destroyed = ,
            //          Notes = "",
            //      },
            //            new SoundCard
            //            {
            //                Id = 4,
            //                DeviceId = ,
            //                Brand = "",
            //                Destroyed = ,
            //                Notes = "",
            //            });

            modelBuilder.Entity<VideoCard>(entity =>
               {
                   entity.ToTable("video card");

                   entity.HasIndex(e => e.DeviceId, "Device ID10");

                   entity.Property(e => e.Id)
                       .HasColumnType("int(11)")
                       .HasColumnName("ID");

                   entity.Property(e => e.Brand).HasMaxLength(20);

                   entity.Property(e => e.DeviceId)
                       .HasColumnType("int(11)")
                       .HasColumnName("Device ID");

                   entity.Property(e => e.Notes).HasColumnType("text");

                   entity.Property(e => e.RamSizeGb)
                       .HasColumnType("int(11)")
                       .HasColumnName("Ram Size (GB)");

                   entity.Property(e => e.SerialNumber)
                       .HasMaxLength(30)
                       .HasColumnName("Serial Number");

                   entity.HasOne(d => d.Device)
                       .WithMany(p => p.VideoCards)
                       .HasForeignKey(d => d.DeviceId)
                       .OnDelete(DeleteBehavior.ClientSetNull)
                       .HasConstraintName("video card_ibfk_1");
               });

           // modelBuilder.Entity<VideoCard>().HasData(
           //new VideoCard
           //{
           //    Id = 1,
           //    DeviceId = ,
           //    Brand = ,
           //    RamSizeGb = ,
           //    SerialNumber = ,
           //    Destroyed = ,
           //    Notes = "",
           //},
           //   new VideoCard
           //   {
           //       Id = 2,
           //       DeviceId = ,
           //       Brand = ,
           //       RamSizeGb = ,
           //       SerialNumber = ,
           //       Destroyed = ,
           //       Notes = "",
           //   },
           //      new VideoCard
           //      {
           //          Id = 3,
           //          DeviceId = ,
           //          Brand = ,
           //          RamSizeGb = ,
           //          SerialNumber = ,
           //          Destroyed = ,
           //          Notes = "",
           //      },
           //         new VideoCard
           //         {
           //             Id = 4,
           //             DeviceId = ,
           //             Brand = ,
           //             RamSizeGb = ,
           //             SerialNumber = ,
           //             Destroyed = ,
           //             Notes = "",
           //         });

            modelBuilder.Entity<Warranty>(entity =>
             {
                 entity.ToTable("warranty");

                 entity.HasIndex(e => e.DeviceId, "Device ID11");

                 entity.Property(e => e.Id)
                     .HasColumnType("int(11)")
                     .HasColumnName("ID");

                 entity.Property(e => e.DeviceId)
                     .HasColumnType("int(11)")
                     .HasColumnName("Device ID");

                 entity.Property(e => e.LengthOfWarranty)
                     .HasMaxLength(15)
                     .HasColumnName("Length of Warranty");

                 entity.Property(e => e.Notes).HasColumnType("text");

                 entity.Property(e => e.TypeOfWarranty)
                     .HasMaxLength(100)
                     .HasColumnName("Type of Warranty");

                 entity.Property(e => e.WarrantyExpiryDate).HasColumnName("Warranty Expiry Date");

                 entity.HasOne(d => d.Device)
                     .WithMany(p => p.Warranties)
                     .HasForeignKey(d => d.DeviceId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("warranty_ibfk_1");
             });

           // modelBuilder.Entity<Warranty>().HasData(
           //new Warranty
           //{
           //    Id = 1,
           //    DeviceId = ,
           //    TypeOfWarranty = ,
           //    LengthOfWarranty = ,
           //    WarrantyExpiryDate = ,
           //    Notes = "",
           //},
           //   new Warranty
           //   {
           //       Id = 2,
           //       DeviceId = ,
           //       TypeOfWarranty = ,
           //       LengthOfWarranty = ,
           //       WarrantyExpiryDate = ,
           //       Notes = "",
           //   },
           //      new Warranty
           //      {
           //          Id = 3,
           //          DeviceId = ,
           //          TypeOfWarranty = ,
           //          LengthOfWarranty = ,
           //          WarrantyExpiryDate = ,
           //          Notes = "",
           //      },
           //         new Warranty
           //         {
           //             Id = 4,
           //             DeviceId = ,
           //             TypeOfWarranty = ,
           //             LengthOfWarranty = ,
           //             WarrantyExpiryDate = ,
           //             Notes = "",
           //         }
           //);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
