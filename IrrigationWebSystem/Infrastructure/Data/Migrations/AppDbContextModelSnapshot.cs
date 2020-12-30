﻿// <auto-generated />
using System;
using IrrigationWebSystem.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IrrigationWebSystem.Infrastructure.Data.Migrations
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
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("IrrigationWebSystem.ApplicationCore.DomainEntities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AchievedClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("BasicSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CivilStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentlyWorkingStatus")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameWithInitial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalFileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeePositionId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeeContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeContact");
                });

            modelBuilder.Entity("IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeeLeave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LeaveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("leaveFullOrHalfDay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeLeave");
                });

            modelBuilder.Entity("IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeePosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeePosition");
                });

            modelBuilder.Entity("IrrigationWebSystem.ApplicationCore.DomainEntities.Employee", b =>
                {
                    b.HasOne("IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeePosition", "EmployeePosition")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeePositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeePosition");
                });

            modelBuilder.Entity("IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeeContact", b =>
                {
                    b.HasOne("IrrigationWebSystem.ApplicationCore.DomainEntities.Employee", "Employee")
                        .WithMany("GetEmployeeContacts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeeLeave", b =>
                {
                    b.HasOne("IrrigationWebSystem.ApplicationCore.DomainEntities.Employee", "Employee")
                        .WithMany("EmployeeLeaves")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("IrrigationWebSystem.ApplicationCore.DomainEntities.Employee", b =>
                {
                    b.Navigation("EmployeeLeaves");

                    b.Navigation("GetEmployeeContacts");
                });

            modelBuilder.Entity("IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeePosition", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
