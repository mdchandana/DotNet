using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IrrigationWebSystem.Data.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeePosition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePosition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WmDailyWaterLevelAndissue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterIssuingConsiderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarterLevelAtSluice = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    EffectiveHead = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    GateOpenedSize = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    WaterIssuedDurationFromDateWithTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WaterIssuedDurationToDateWithTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoOfHours = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    WaterIssuedInAcft = table.Column<decimal>(type: "decimal(13,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WmDailyWaterLevelAndissue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WmRainFall",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RainFallArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RainFallDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RainFallAmount = table.Column<decimal>(type: "decimal(13,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WmRainFall", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WmScheme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WmScheme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WmWaterLevelCapacityMuruthawelaTank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaterLevel = table.Column<decimal>(type: "decimal(13,1)", nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WmWaterLevelCapacityMuruthawelaTank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalFileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameWithInitial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    CivilStatus = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClassMnGrade = table.Column<int>(type: "int", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(13,2)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentlyWorkingStatus = table.Column<int>(type: "int", nullable: false),
                    EmployeePositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeePosition_EmployeePositionId",
                        column: x => x.EmployeePositionId,
                        principalTable: "EmployeePosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WmCultivationSeasonInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CultivationSeason = table.Column<int>(type: "int", nullable: false),
                    CultivationSeasonYear = table.Column<int>(type: "int", nullable: false),
                    WmSchemeId = table.Column<int>(type: "int", nullable: false),
                    WaterIssueStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WaterIssueEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WmCultivationSeasonInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WmCultivationSeasonInformation_WmScheme_WmSchemeId",
                        column: x => x.WmSchemeId,
                        principalTable: "WmScheme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeave",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LeaveType = table.Column<int>(type: "int", nullable: false),
                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HalfFullLeaveType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeLeave_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeePositionId",
                table: "Employee",
                column: "EmployeePositionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeave_EmployeeId",
                table: "EmployeeLeave",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WmCultivationSeasonInformation_WmSchemeId",
                table: "WmCultivationSeasonInformation",
                column: "WmSchemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLeave");

            migrationBuilder.DropTable(
                name: "WmCultivationSeasonInformation");

            migrationBuilder.DropTable(
                name: "WmDailyWaterLevelAndissue");

            migrationBuilder.DropTable(
                name: "WmRainFall");

            migrationBuilder.DropTable(
                name: "WmWaterLevelCapacityMuruthawelaTank");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "WmScheme");

            migrationBuilder.DropTable(
                name: "EmployeePosition");
        }
    }
}
