using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyMash.Migrations
{
    public partial class AddedSeedDataVehicleModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Toyota");

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Nissan" });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "MakeId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Fit" },
                    { 2, 2, "Aqua" },
                    { 3, 2, "Vits" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Harly Devidson");
        }
    }
}
