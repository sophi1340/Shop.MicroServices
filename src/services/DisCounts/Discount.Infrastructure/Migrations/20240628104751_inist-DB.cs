using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Discount.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class inistDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTitle = table.Column<string>(type: "Nvarchar(300)", maxLength: 300, nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false, comment: " Percent = 1,Amount = 2"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 6, 28, 10, 47, 50, 726, DateTimeKind.Utc).AddTicks(8357)),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 6, 28, 10, 47, 50, 726, DateTimeKind.Utc).AddTicks(8913)),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 6, 28, 10, 47, 50, 726, DateTimeKind.Utc).AddTicks(9288)),
                    ModificationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 6, 28, 10, 47, 50, 726, DateTimeKind.Utc).AddTicks(9669))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupons");
        }
    }
}
