using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Storage.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeedDataWithMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: new Guid("b852a0d3-7051-4109-ba7a-850d483896d1"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: new Guid("411eb0e7-a369-48a1-b60e-542781126882"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: new Guid("261230e5-4079-4abe-9bfd-df1a37c875ba"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: new Guid("15995e4c-dde8-4489-9e25-efac2cb553f9"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: new Guid("8efddfd5-734e-4d14-89a7-48c83661aee8"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: new Guid("292ae322-532d-426b-b765-9ea97a2b47e6"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uid",
                value: new Guid("f7176ed9-924e-4f9b-8879-fa2b53aed3e5"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                column: "Uid",
                value: new Guid("7061f141-ed24-4b4c-af2f-cbce97e8aae9"));

            migrationBuilder.InsertData(
                schema: "Shop",
                table: "Order",
                columns: new[] { "Id", "CreatedOn", "CustomerFk", "DeletedOn", "Status", "Uid" },
                values: new object[] { 7, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1, new Guid("1c0752cc-fb3c-4878-a13d-69b601f793c9") });

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: new Guid("bf8b66ac-c701-4117-b73c-3c231f1d73a0"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: new Guid("e5993fa1-4999-455b-8af9-c665340bc0c2"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: new Guid("fff28a7f-d481-496d-96e0-917a1ef7f24d"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: new Guid("31e9d67e-f7c4-478b-b280-9a96da9e9804"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uid",
                value: new Guid("657e62cf-dfdc-4daf-9075-a6f5053d4361"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "Uid",
                value: new Guid("7a369ae8-29fb-4e88-ac01-b00cebdd3a10"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "Uid",
                value: new Guid("7e8be5e0-c1f2-44fc-b530-59d893407c31"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "Uid",
                value: new Guid("e1fbf861-3d6b-4208-9730-e11a4d8a10b1"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 9,
                column: "Uid",
                value: new Guid("781abe5d-d197-409e-ae82-56b5b7d4d3ad"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: new Guid("2b4ef0b3-8fe5-46f6-ad73-979b2036481d"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: new Guid("17b6e705-9dd0-44f8-a3a0-73865f93c3cc"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: new Guid("80f16508-4180-4498-81d6-a630bff4a4b5"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: new Guid("01007967-7b47-47fc-9e3d-d54af30df201"));

            migrationBuilder.InsertData(
                schema: "Shop",
                table: "Product",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Name", "Price", "Uid" },
                values: new object[,]
                {
                    { 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Patike", 9999.99m, new Guid("f94b3625-d49a-4ac4-baf3-5c554d35283f") },
                    { 6, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pantalone", 4499.99m, new Guid("3dfe09c1-e497-4833-94eb-ac171ad95e5a") },
                    { 7, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Majica", 1199.99m, new Guid("ffda6fd2-11a1-4cf0-8f35-195a813332b9") },
                    { 8, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tanjir", 299.99m, new Guid("ad1efbd0-c5a2-42ff-b129-156f3065d25c") },
                    { 9, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jakna", 8999.99m, new Guid("71bb50cd-63e2-4cb2-ab69-5c7c3c56efe8") },
                    { 10, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stolica", 11999.99m, new Guid("0fa7f9db-8990-4eed-bab7-3f2184b99c55") },
                    { 11, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Televizor", 54999.99m, new Guid("461d8e13-3f11-44f5-a678-6d86b55d6377") },
                    { 12, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Krevet", 39999.99m, new Guid("8046aaa7-b16f-47bd-9350-bf308c173375") }
                });

            migrationBuilder.InsertData(
                schema: "Shop",
                table: "OrderItem",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "OrderFk", "Price", "ProductFk", "Quantity", "Uid" },
                values: new object[,]
                {
                    { 10, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 9999.99m, 5, 1, new Guid("ba857fbe-fff0-48fb-bae8-81ab3dbdfd75") },
                    { 11, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 3499.99m, 6, 2, new Guid("6a6eb388-4b2f-4ab8-8813-404212c55e55") },
                    { 12, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 1199.99m, 7, 4, new Guid("85e10880-0b87-417d-a30e-fc66f18f8e1e") },
                    { 13, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 199.99m, 8, 4, new Guid("c756a242-a91f-4fc9-8062-c557f165c1ab") },
                    { 14, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 8999.99m, 9, 1, new Guid("27a2f51b-bd57-44af-8984-47d0f27ed8e4") },
                    { 15, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 12999.99m, 10, 1, new Guid("c24fa34b-71f8-4a15-b344-c15af876a951") },
                    { 16, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 49999.99m, 11, 1, new Guid("5e12c4d7-2e9a-4fd5-aec9-4ef7614f1f98") },
                    { 17, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 39999.99m, 12, 1, new Guid("036440a5-2b83-4f41-96f8-7b7c85bb9d40") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: new Guid("03cd14e0-0fcf-40d5-8c09-14f045f2199c"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: new Guid("7234d4a4-eb61-43a0-ada7-061f3aa7b482"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: new Guid("041b7c64-cda8-443d-abe2-623db850789b"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: new Guid("8906e152-40e2-4f3c-8a16-1232d9fcceb7"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: new Guid("c0177445-a2e6-4883-a378-7d227edc7758"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: new Guid("d8e2fcaa-c774-47ab-8f27-c526aa9a7a6c"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uid",
                value: new Guid("513c1ca0-6c62-4126-8d76-58ba231f5412"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                column: "Uid",
                value: new Guid("87a85d45-9aa8-405e-9a16-c443819f14b0"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: new Guid("0a4ddebb-72b6-433a-aa6e-06a19f6fc9fb"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: new Guid("415d1c0d-304d-42e2-9aa0-0f582913238a"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: new Guid("e5a4d129-6694-4d1b-a438-5000960c9e8e"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: new Guid("5a0c6f64-400d-4e76-a35c-caeebfbd8989"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uid",
                value: new Guid("dc41cf2a-6baf-4f16-a418-6a480f268bae"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 6,
                column: "Uid",
                value: new Guid("e4d4f16c-3374-4e08-911a-6a9240b1de3d"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 7,
                column: "Uid",
                value: new Guid("4007a55e-fff8-4f78-bedb-787da3475a23"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 8,
                column: "Uid",
                value: new Guid("27590886-b01a-4895-8e1e-f00567d0383c"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 9,
                column: "Uid",
                value: new Guid("899aa8ea-7e02-4e6a-ad79-86b24e962b76"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: new Guid("9a5dbacd-111d-44b4-ab30-2d8a48d8feb7"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: new Guid("51ccb483-5d77-4aea-a0df-2bf42a1b122e"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: new Guid("33f4c890-dd02-4843-9897-b55594ccd64d"));

            migrationBuilder.UpdateData(
                schema: "Shop",
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: new Guid("96044c8a-1bc7-4c40-80d4-f9a3de4eea9e"));
        }
    }
}
