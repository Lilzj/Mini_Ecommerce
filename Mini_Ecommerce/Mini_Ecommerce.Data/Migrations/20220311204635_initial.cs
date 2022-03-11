using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_Ecommerce.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    Postcode = table.Column<string>(type: "TEXT", nullable: false),
                    HouseNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "DateCreated", "Gender", "Name" },
                values: new object[] { 1, 30, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(4802), 0, "Joshua Gbogodor" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "DateCreated", "Gender", "Name" },
                values: new object[] { 2, 30, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(4818), 1, "Diana Minna" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "DateCreated", "Gender", "Name" },
                values: new object[] { 3, 43, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(4819), 0, "Obinna John" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "DateCreated", "Gender", "Name" },
                values: new object[] { 4, 30, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(4820), 1, "Chizaram Beauty" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "DateCreated", "Gender", "Name" },
                values: new object[] { 5, 45, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(4821), 1, "Ngozi Nneka" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "DateCreated", "Gender", "Name" },
                values: new object[] { 6, 27, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(4823), 0, "Matthew Drone" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "DateCreated", "Gender", "Name" },
                values: new object[] { 7, 36, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(4824), 0, "Hope Osarobo" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "0390c15b-62b7-454f-9c92-c2d8461cd6cd", 1, 12, "EA3454", "Adeoye street, Ikeja" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "28c6c0cc-7aed-4368-b8f3-86f98debd00a", 2, 12, "33455", "Abidjo way, Ajah" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "5269b468-2a13-4e08-bb3d-b2ef6868a14f", 6, 16, "76523", "Alonshe close, Benin" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "601898df-70dc-4404-b1c0-86c11a092d92", 2, 6, "37632", "Bodija-Badoo, Ajah" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "66b6af22-86c6-4f8e-838f-513fb826d025", 1, 27, "76523", "Femi street, Ajah" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "695a40e1-012e-4df4-a394-f34315337d8b", 3, 2, "EA3454", "Wfurun street, Ijaiye" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "6a338737-aec9-46dc-848a-2d9a5ba289b4", 7, 2, "FT2563", "University Road, Yaba" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "7257850d-9fc2-40b8-9448-097c51d7f3ed", 6, 10, "44556", "Akenbor sokponba Rd" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "73205b08-9896-4c4f-8f78-f89f3769f027", 5, 12, "EA3454", "Eleganza, Ikeja" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "79c569dd-c393-48de-bbd3-f7a99b9ef010", 4, 23, "RT45322", "Bush close, UK" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "94e8d9c0-6999-456b-b036-9e229410db4a", 7, 17, "88733", "Asanjo way, Ajah" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "97dc4858-f3bc-4a6f-a534-1ad990a194f2", 5, 27, "76523", "Admiraty way, Island" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "a98ca8a0-78e8-4e9e-ac21-f1ed7c367890", 4, 12, "EA3454", "Nzumba way, UK" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "CustomerId", "HouseNumber", "Postcode", "Street" },
                values: new object[] { "e0693dfb-933a-4cc0-b980-c0485d5b3ab9", 3, 13, "76523", "Shoprite way, Sangotedo" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "08086e70-4014-4f2e-80b8-a835d301363f", 4000m, 6, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "166df9e4-8942-41e6-92d2-bf1640d89650", 1500m, 7, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "1871b989-d24b-4711-be89-123617ba4001", 4000m, 4, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "2e732db6-1710-46c9-8102-14292c09ccfd", 1450m, 7, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "43230069-d4c8-4568-a1c5-9436b5d15ed8", 8700m, 7, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "543e9a40-c3a7-4e16-b932-f715a62f7ae4", 1000m, 5, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "54c7e83b-a55d-456c-abb5-9812cdfc9a04", 300m, 2, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "626df4d0-82f5-413d-85c1-3dd2902aba3f", 6000m, 4, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "7ea43bef-97dd-4335-9c38-f5c88066cd85", 4000m, 2, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "89f09e75-8f6a-4c7a-9dcc-d9b4b2ec4270", 7500m, 1, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "8e17e8c6-4d58-407b-87c8-d7961c3657a6", 7500m, 3, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "91663ae9-c2f5-4457-b76e-81b4ce5e0127", 300m, 3, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "9b700a98-92db-49bd-9315-9b012db646bd", 450m, 5, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "ac0cfe31-e43c-4d69-b6c8-0abe941255ba", 4000m, 3, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "b9a72b04-f647-400b-a6a1-06a05ccecd2a", 300m, 6, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "bf329811-282a-4f11-96d0-7a91d4f5c34f", 7500m, 2, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "c2e7542e-3566-46d5-a0b7-5bafb2d64478", 4000m, 1, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "c5a1a710-f761-41ea-a417-a2abf7705539", 300m, 1, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "c9f75d31-a184-4d36-b361-0f809ec1cf61", 800m, 5, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "df62508f-1e0a-4ad2-9ed3-edb926d84811", 300m, 4, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Amount", "CustomerId", "OrderDate" },
                values: new object[] { "e7c5fe0e-83f5-4c84-b31b-cd64ec18c70f", 7500m, 6, new DateTime(2022, 3, 11, 21, 46, 35, 572, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
