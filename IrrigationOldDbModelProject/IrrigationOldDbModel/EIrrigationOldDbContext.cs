using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    public partial class EIrrigationOldDbContext : DbContext
    {
        public EIrrigationOldDbContext()
        {
        }

        public EIrrigationOldDbContext(DbContextOptions<EIrrigationOldDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeFileAttachement> EmployeeFileAttachements { get; set; }
        public virtual DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public virtual DbSet<FarmerOrganization> FarmerOrganizations { get; set; }
        public virtual DbSet<FarmerOrganizationPosiiton> FarmerOrganizationPosiitons { get; set; }
        public virtual DbSet<FarmerOrganizationsMember> FarmerOrganizationsMembers { get; set; }
        public virtual DbSet<IssueOrder> IssueOrders { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemsMain> ItemsMains { get; set; }
        public virtual DbSet<ItemsSub> ItemsSubs { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PurchaseMainInfo> PurchaseMainInfos { get; set; }
        public virtual DbSet<Scheme> Schemes { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<ViewAllEmployee> ViewAllEmployees { get; set; }
        public virtual DbSet<WmCultivationSeasonWithWaterIssueStartEnd> WmCultivationSeasonWithWaterIssueStartEnds { get; set; }
        public virtual DbSet<WmDailyWaterLevelAndissue> WmDailyWaterLevelAndissues { get; set; }
        public virtual DbSet<WmRainFall> WmRainFalls { get; set; }
        public virtual DbSet<WmWaterLevelCapacityMuruthawelaTank> WmWaterLevelCapacityMuruthawelaTanks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=CHANDANA\\SQLEXPRESS2012;Initial Catalog=E-IRRIGATION;Integrated Security=True;ConnectRetryCount=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.HasKey(e => e.BysId)
                    .HasName("PK__Buyers__A22E9499000AF8CF");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpNumber)
                    .HasName("PK__Employee__EF25626C542C7691");

                entity.Property(e => e.EmpNumber).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeFileAttachement>(entity =>
            {
                entity.HasKey(e => e.EmfaId)
                    .HasName("PK__Employee__53823A652AF556D4");

                entity.Property(e => e.EmpNumber).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeLeave>(entity =>
            {
                entity.HasKey(e => e.EmplId)
                    .HasName("PK__Employee__614707A957FD0775");

                entity.Property(e => e.EmpNumber).IsUnicode(false);

                entity.Property(e => e.EmplLeaveFullOrHalfDay).IsUnicode(false);

                entity.Property(e => e.EmplType).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeePosition>(entity =>
            {
                entity.HasKey(e => e.EmppId)
                    .HasName("PK__Employee__99C254B0668030F6");

                entity.Property(e => e.EmppId).IsUnicode(false);

                entity.Property(e => e.EmppPositionCode).IsUnicode(false);
            });

            modelBuilder.Entity<FarmerOrganization>(entity =>
            {
                entity.HasKey(e => e.FoId)
                    .HasName("PK__FarmerOr__E5275D2E0F4D3C5F");

                entity.Property(e => e.FoRelevantYear).IsUnicode(false);

                entity.Property(e => e.ScId).IsUnicode(false);
            });

            modelBuilder.Entity<FarmerOrganizationPosiiton>(entity =>
            {
                entity.HasKey(e => e.FopPositions)
                    .HasName("PK__FarmerOr__22BB861E77DFC722");
            });

            modelBuilder.Entity<FarmerOrganizationsMember>(entity =>
            {
                entity.HasKey(e => e.FomId)
                    .HasName("PK__FarmerOr__FBCD3D8C131DCD43");

                entity.Property(e => e.FomRelevantYear).IsUnicode(false);
            });

            modelBuilder.Entity<IssueOrder>(entity =>
            {
                entity.HasKey(e => e.IomId)
                    .HasName("PK__IssueOrd__A373AFBD68336F3E");

                entity.Property(e => e.IomId).IsUnicode(false);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.ItemsId)
                    .HasName("PK__Items__F180B1C70B7CAB7B");
            });

            modelBuilder.Entity<ItemsSub>(entity =>
            {
                entity.HasKey(e => e.ItemSubId)
                    .HasName("PK__ItemsSub__A36A06AB07AC1A97");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PmId)
                    .HasName("PK__Payments__8E8EC76B6FD49106");

                entity.Property(e => e.PcmId).IsUnicode(false);

                entity.Property(e => e.PmChequeNumber).IsUnicode(false);

                entity.Property(e => e.PmPaymentMethod).IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseMainInfo>(entity =>
            {
                entity.HasKey(e => e.PcmId)
                    .HasName("PK__Purchase__9E3ECFE2636EBA21");

                entity.Property(e => e.PcmId).IsUnicode(false);

                entity.Property(e => e.PcmPaymentStatus).IsUnicode(false);
            });

            modelBuilder.Entity<Scheme>(entity =>
            {
                entity.HasKey(e => e.ScId)
                    .HasName("PK__Schemes__C402E57E703EA55A");

                entity.Property(e => e.ScId).IsUnicode(false);
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK__Stock__EBDB13CF6C040022");

                entity.Property(e => e.IomId).IsUnicode(false);

                entity.Property(e => e.PcmId).IsUnicode(false);

                entity.Property(e => e.StFlag).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UsersName)
                    .HasName("PK__Users__BAC224CC73A521EA");

                entity.Property(e => e.EmpNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleNumbers)
                    .HasName("PK__Vehicles__F2BA1D807993056A");

                entity.Property(e => e.VehicleNumbers).IsUnicode(false);
            });

            modelBuilder.Entity<ViewAllEmployee>(entity =>
            {
                entity.ToView("View_AllEmployees", "e-irrigation");

                entity.Property(e => e.EmpNumber).IsUnicode(false);
            });

            modelBuilder.Entity<WmCultivationSeasonWithWaterIssueStartEnd>(entity =>
            {
                entity.HasKey(e => e.WmcsCultivationSeasonIdId)
                    .HasName("PK__WM_Culti__2A9E5806226010D3");
            });

            modelBuilder.Entity<WmDailyWaterLevelAndissue>(entity =>
            {
                entity.HasKey(e => e.DwlId)
                    .HasName("PK__WM_Daily__F4F43E067775B2CE");

                entity.Property(e => e.DwlTankName).IsUnicode(false);
            });

            modelBuilder.Entity<WmRainFall>(entity =>
            {
                entity.HasKey(e => e.WrfRainFallId)
                    .HasName("PK__WM_RainF__98BA27A87B4643B2");

                entity.Property(e => e.WrfRainFallArea).IsUnicode(false);
            });

            modelBuilder.Entity<WmWaterLevelCapacityMuruthawelaTank>(entity =>
            {
                entity.HasKey(e => e.WlcmId)
                    .HasName("PK__WM_Water__B1C77C654242D080");

                entity.Property(e => e.WlcmId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
