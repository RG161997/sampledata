using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample.Migrations
{
    public partial class categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 100, nullable: false),
                    picture = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    companyName = table.Column<string>(maxLength: 50, nullable: false),
                    contactName = table.Column<string>(maxLength: 50, nullable: false),
                    contactTitle = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    city = table.Column<string>(maxLength: 100, nullable: false),
                    region = table.Column<string>(maxLength: 100, nullable: false),
                    postalCode = table.Column<int>(nullable: false),
                    country = table.Column<string>(maxLength: 100, nullable: false),
                    phone = table.Column<int>(nullable: false),
                    fax = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customerId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    lastName = table.Column<string>(maxLength: 50, nullable: false),
                    firstName = table.Column<string>(maxLength: 50, nullable: false),
                    title = table.Column<string>(maxLength: 50, nullable: false),
                    titleOfCourtesy = table.Column<string>(maxLength: 50, nullable: false),
                    birthDate = table.Column<DateTime>(nullable: false),
                    hireDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    city = table.Column<string>(maxLength: 100, nullable: false),
                    region = table.Column<string>(maxLength: 100, nullable: false),
                    postalCode = table.Column<int>(nullable: false),
                    country = table.Column<string>(maxLength: 100, nullable: false),
                    homePhone = table.Column<int>(nullable: false),
                    extension = table.Column<int>(nullable: false),
                    photo = table.Column<string>(maxLength: 500, nullable: true),
                    notes = table.Column<string>(maxLength: 500, nullable: true),
                    reportsTo = table.Column<int>(nullable: false),
                    photoPath = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.employeeId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    regionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    regionDescription = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.regionId);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    shipperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    companyName = table.Column<string>(maxLength: 50, nullable: false),
                    phone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.shipperId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    supplierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    companyName = table.Column<string>(maxLength: 50, nullable: false),
                    contactName = table.Column<string>(maxLength: 50, nullable: false),
                    contactTitle = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    city = table.Column<string>(maxLength: 100, nullable: false),
                    region = table.Column<string>(maxLength: 100, nullable: false),
                    postalCode = table.Column<int>(nullable: false),
                    country = table.Column<string>(maxLength: 100, nullable: false),
                    phone = table.Column<int>(nullable: false),
                    fax = table.Column<int>(nullable: false),
                    homepage = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.supplierId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customerId = table.Column<int>(nullable: true),
                    employeeId = table.Column<int>(nullable: true),
                    orderDate = table.Column<DateTime>(nullable: false),
                    requiredDate = table.Column<DateTime>(nullable: false),
                    shippedDate = table.Column<DateTime>(nullable: false),
                    shipVia = table.Column<string>(maxLength: 100, nullable: true),
                    freight = table.Column<string>(maxLength: 50, nullable: true),
                    shipName = table.Column<string>(maxLength: 50, nullable: true),
                    shipAddress = table.Column<string>(maxLength: 100, nullable: false),
                    shipCity = table.Column<string>(maxLength: 100, nullable: false),
                    shipRegion = table.Column<string>(maxLength: 100, nullable: false),
                    shipPostalCode = table.Column<int>(nullable: false),
                    shipCountry = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "customerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Territories",
                columns: table => new
                {
                    territoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    territoryDescription = table.Column<string>(maxLength: 100, nullable: false),
                    regionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.territoryId);
                    table.ForeignKey(
                        name: "FK_Territories_Regions_regionId",
                        column: x => x.regionId,
                        principalTable: "Regions",
                        principalColumn: "regionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    productName = table.Column<string>(maxLength: 100, nullable: false),
                    categoryId = table.Column<int>(nullable: true),
                    supplierID = table.Column<int>(nullable: true),
                    quantityPerLabel = table.Column<int>(nullable: false),
                    unitPrice = table.Column<int>(nullable: false),
                    unitsInStock = table.Column<int>(nullable: false),
                    unitsOnOrder = table.Column<int>(nullable: false),
                    reorderLevel = table.Column<int>(nullable: false),
                    discontinued = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_supplierID",
                        column: x => x.supplierID,
                        principalTable: "Suppliers",
                        principalColumn: "supplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customerId",
                table: "Orders",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_employeeId",
                table: "Orders",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_supplierID",
                table: "Products",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Territories_regionId",
                table: "Territories",
                column: "regionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "Territories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
