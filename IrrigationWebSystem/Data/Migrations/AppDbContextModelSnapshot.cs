﻿// <auto-generated />
using System;
using IrrigationWebSystem.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IrrigationWebSystem.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("BasicSalary")
                        .HasColumnType("decimal(13,2)");

                    b.Property<int>("CivilStatus")
                        .HasColumnType("int");

                    b.Property<int>("ClassMnGrade")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentlyWorkingStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeePositionId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameWithInitial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalFileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmployeePositionId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.EmployeeLeave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("HalfFullLeaveType")
                        .HasColumnType("int");

                    b.Property<DateTime>("LeaveDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeaveType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeLeave");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.EmployeePosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeePosition");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmCannel", b =>
                {
                    b.Property<string>("CannelName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Track")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WmSchemeId")
                        .HasColumnType("int");

                    b.HasKey("CannelName");

                    b.HasIndex("WmSchemeId");

                    b.ToTable("WmCannel");

                    b.HasData(
                        new
                        {
                            CannelName = "LB-Main-Cannel",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-01-D2",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-02-D4",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-02-D6",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-02-D8",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-02-D9",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-02-FC-01",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-03-D2",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-03-D3",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-03-D5",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-03-D6",
                            Track = "",
                            WmSchemeId = 1
                        },
                        new
                        {
                            CannelName = "Track-03-D9",
                            Track = "",
                            WmSchemeId = 1
                        });
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmCannelsWaterIssue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(13,2)");

                    b.Property<DateTime>("WaterIssuedDurationFromDateWithTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WaterIssuedDurationToDateWithTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("WaterIssuedInAcft")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("WaterIssuedInCumecs")
                        .HasColumnType("decimal(13,2)");

                    b.Property<string>("WmCannelCannelName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WmCannelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WmCannelCannelName");

                    b.ToTable("WmCannelsWaterIssue");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmCultivationSeasonInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CultivationYalaMaha")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WaterIssueEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WaterIssueStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WmSchemeId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WmSchemeId");

                    b.ToTable("WmCultivationSeasonInformation");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmDailyWaterLevelAndissue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<decimal>("EffectiveHead")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("GateOpenedSize")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("NoOfHours")
                        .HasColumnType("decimal(13,2)");

                    b.Property<string>("TankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("WarterLevelAtSluice")
                        .HasColumnType("decimal(13,2)");

                    b.Property<DateTime>("WaterIssuedDurationFromDateWithTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WaterIssuedDurationToDateWithTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("WaterIssuedInAcft")
                        .HasColumnType("decimal(13,2)");

                    b.Property<DateTime>("WaterIssuingConsiderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WmDailyWaterLevelAndissue");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmRainFall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("RainFallAmount")
                        .HasColumnType("decimal(13,2)");

                    b.Property<string>("RainFallArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RainFallDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WmRainFall");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmScheme", b =>
                {
                    b.Property<int>("WmSchemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WmSchemeId");

                    b.ToTable("WmScheme");

                    b.HasData(
                        new
                        {
                            WmSchemeId = 1,
                            Name = "Muruthawela"
                        },
                        new
                        {
                            WmSchemeId = 2,
                            Name = "UrubokuOya"
                        },
                        new
                        {
                            WmSchemeId = 3,
                            Name = "KiramaOya"
                        });
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmWaterLevelCapacityMuruthawelaTank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("WaterLevel")
                        .HasColumnType("decimal(13,1)");

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WmWaterLevelCapacityMuruthawelaTank");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.Employee", b =>
                {
                    b.HasOne("IrrigationWebSystem.Models.DomainEntities.EmployeePosition", "EmployeePosition")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeePositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeePosition");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.EmployeeLeave", b =>
                {
                    b.HasOne("IrrigationWebSystem.Models.DomainEntities.Employee", "Employee")
                        .WithMany("EmployeeLeaves")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmCannel", b =>
                {
                    b.HasOne("IrrigationWebSystem.Models.DomainEntities.WmScheme", "WmScheme")
                        .WithMany("WmCannels")
                        .HasForeignKey("WmSchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WmScheme");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmCannelsWaterIssue", b =>
                {
                    b.HasOne("IrrigationWebSystem.Models.DomainEntities.WmCannel", "WmCannel")
                        .WithMany()
                        .HasForeignKey("WmCannelCannelName");

                    b.Navigation("WmCannel");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmCultivationSeasonInformation", b =>
                {
                    b.HasOne("IrrigationWebSystem.Models.DomainEntities.WmScheme", "WmScheme")
                        .WithMany("WmCultivationSeasonInformations")
                        .HasForeignKey("WmSchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WmScheme");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.Employee", b =>
                {
                    b.Navigation("EmployeeLeaves");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.EmployeePosition", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("IrrigationWebSystem.Models.DomainEntities.WmScheme", b =>
                {
                    b.Navigation("WmCannels");

                    b.Navigation("WmCultivationSeasonInformations");
                });
#pragma warning restore 612, 618
        }
    }
}
