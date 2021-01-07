using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyMash.Migrations
{
    public partial class AddedSeedDataForMake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Hero Honda" });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Harly Devidson" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
