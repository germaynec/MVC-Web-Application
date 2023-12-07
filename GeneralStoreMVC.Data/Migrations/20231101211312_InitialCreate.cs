using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeneralStoreMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateOfTransaction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1001, "LouietheDog@indy.gov", "Louie" },
                    { 1002, "mowglithecat@yahoo.com", "Mowgli" },
                    { 1003, "lionelthecat@indy.gov", "Lionel" },
                    { 1004, "Miltonthecat@indy.gov", "Milton" },
                    { 1005, "germayne.curry@yahoo.com", "Germayne" },
                    { 1006, "Demetrius.sass@hotmail.com", "Dj" },
                    { 1007, "Mikeward62@gmail.com", "Mike Ward" },
                    { 1008, "Testemail@yahoo.com", "Test" },
                    { 1009, "Jackson5@yahoo.com", "Michael Jackson" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { 1001, "Glock 19", 499.99000000000001, 98 },
                    { 1002, "Duty Belt", 199.99000000000001, 48 },
                    { 1003, "Police Car", 1999.99, 61 },
                    { 1004, "X26 Taser", 1299.99, 78 },
                    { 1005, "OCSC", 499.99000000000001, 50 },
                    { 1006, "Glock 17", 499.99000000000001, 55 },
                    { 1007, "Baton", 69.989999999999995, 35 },
                    { 1008, "Mag Pouch", 69.989999999999995, 42 },
                    { 1009, "Nylon Mag Pouch", 69.989999999999995, 101 },
                    { 1010, "Radio Holster", 69.989999999999995, 108 },
                    { 1011, "Body Camera", 299.99000000000001, 104 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "CustomerId", "DateOfTransaction", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1001, 1001, new DateTime(2023, 11, 1, 17, 13, 12, 706, DateTimeKind.Local).AddTicks(2190), 1004, 3 },
                    { 1002, 1004, new DateTime(2023, 11, 1, 17, 13, 12, 706, DateTimeKind.Local).AddTicks(2260), 1001, 1 },
                    { 1003, 1002, new DateTime(2023, 11, 1, 17, 13, 12, 706, DateTimeKind.Local).AddTicks(2260), 1011, 3 },
                    { 1004, 1008, new DateTime(2023, 11, 1, 17, 13, 12, 706, DateTimeKind.Local).AddTicks(2260), 1010, 2 },
                    { 1005, 1008, new DateTime(2023, 11, 1, 17, 13, 12, 706, DateTimeKind.Local).AddTicks(2270), 1003, 8 },
                    { 1006, 1002, new DateTime(2023, 11, 1, 17, 13, 12, 706, DateTimeKind.Local).AddTicks(2270), 1007, 6 },
                    { 1007, 1006, new DateTime(2023, 11, 1, 17, 13, 12, 706, DateTimeKind.Local).AddTicks(2270), 1009, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CustomerId",
                table: "Transactions",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ProductId",
                table: "Transactions",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
