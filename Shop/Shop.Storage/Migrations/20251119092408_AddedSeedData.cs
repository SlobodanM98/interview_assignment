using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Storage.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Shop",
                table: "Customer",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Email", "FirstName", "LastName", "Uid" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "nikola@gmail.com", "Nikola", "Nikolic", new Guid("03cd14e0-0fcf-40d5-8c09-14f045f2199c") },
                    { 2, new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "stefan@gmail.com", "Stefan", "Stefanovic", new Guid("7234d4a4-eb61-43a0-ada7-061f3aa7b482") }
                });

            migrationBuilder.InsertData(
                schema: "Shop",
                table: "Product",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Name", "Price", "Uid" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Knjiga", 499.99m, new Guid("9a5dbacd-111d-44b4-ab30-2d8a48d8feb7") },
                    { 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lampa", 1499.99m, new Guid("51ccb483-5d77-4aea-a0df-2bf42a1b122e") },
                    { 3, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Slusalice", 2999.99m, new Guid("33f4c890-dd02-4843-9897-b55594ccd64d") },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Telefon", 31049.99m, new Guid("96044c8a-1bc7-4c40-80d4-f9a3de4eea9e") }
                });

            migrationBuilder.InsertData(
                schema: "Shop",
                table: "Order",
                columns: new[] { "Id", "CreatedOn", "CustomerFk", "DeletedOn", "Status", "Uid" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, new Guid("041b7c64-cda8-443d-abe2-623db850789b") },
                    { 2, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0, new Guid("8906e152-40e2-4f3c-8a16-1232d9fcceb7") },
                    { 3, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0, new Guid("c0177445-a2e6-4883-a378-7d227edc7758") },
                    { 4, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 2, new Guid("d8e2fcaa-c774-47ab-8f27-c526aa9a7a6c") },
                    { 5, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("513c1ca0-6c62-4126-8d76-58ba231f5412") },
                    { 6, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0, new Guid("87a85d45-9aa8-405e-9a16-c443819f14b0") }
                });

            migrationBuilder.InsertData(
                schema: "Shop",
                table: "OrderItem",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "OrderFk", "Price", "ProductFk", "Quantity", "Uid" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 499.99m, 1, 2, new Guid("0a4ddebb-72b6-433a-aa6e-06a19f6fc9fb") },
                    { 2, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 999.99m, 2, 1, new Guid("415d1c0d-304d-42e2-9aa0-0f582913238a") },
                    { 3, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2999.99m, 3, 1, new Guid("e5a4d129-6694-4d1b-a438-5000960c9e8e") },
                    { 4, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 399.99m, 1, 3, new Guid("5a0c6f64-400d-4e76-a35c-caeebfbd8989") },
                    { 5, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1499.99m, 2, 1, new Guid("dc41cf2a-6baf-4f16-a418-6a480f268bae") },
                    { 6, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 31049.99m, 4, 1, new Guid("e4d4f16c-3374-4e08-911a-6a9240b1de3d") },
                    { 7, new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 34999.99m, 4, 1, new Guid("4007a55e-fff8-4f78-bedb-787da3475a23") },
                    { 8, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 34999.99m, 4, 2, new Guid("27590886-b01a-4895-8e1e-f00567d0383c") },
                    { 9, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 3499.99m, 3, 1, new Guid("899aa8ea-7e02-4e6a-ad79-86b24e962b76") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
