using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCartBasicsMVC.Migrations
{
    public partial class QtyAddedForOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "OrderDetail",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qty",
                table: "OrderDetail");
        }
    }
}
