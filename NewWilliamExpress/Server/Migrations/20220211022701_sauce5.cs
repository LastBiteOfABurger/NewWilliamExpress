using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWilliamExpress.Server.Migrations
{
    public partial class sauce5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Customer_CustomerId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 703, DateTimeKind.Local).AddTicks(7512), new DateTime(2022, 2, 11, 10, 27, 0, 704, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 704, DateTimeKind.Local).AddTicks(6286), new DateTime(2022, 2, 11, 10, 27, 0, 704, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 704, DateTimeKind.Local).AddTicks(6292), new DateTime(2022, 2, 11, 10, 27, 0, 704, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 705, DateTimeKind.Local).AddTicks(9397), new DateTime(2022, 2, 11, 10, 27, 0, 705, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 705, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 2, 11, 10, 27, 0, 705, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 705, DateTimeKind.Local).AddTicks(9414), new DateTime(2022, 2, 11, 10, 27, 0, 705, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4254), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4274), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4277), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4281), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4284), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4287), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4291), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4294), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4297), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4301), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4304), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4311), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4314), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4369), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4379), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4386), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(1751), new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(1763), new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(1766), new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(4275), new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(4283), new DateTime(2022, 2, 11, 10, 27, 0, 708, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Customer_CustomerId",
                table: "Items",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Customer_CustomerId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 123, DateTimeKind.Local).AddTicks(1259), new DateTime(2022, 2, 11, 7, 17, 46, 123, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 124, DateTimeKind.Local).AddTicks(17), new DateTime(2022, 2, 11, 7, 17, 46, 124, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 124, DateTimeKind.Local).AddTicks(22), new DateTime(2022, 2, 11, 7, 17, 46, 124, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 125, DateTimeKind.Local).AddTicks(2748), new DateTime(2022, 2, 11, 7, 17, 46, 125, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 125, DateTimeKind.Local).AddTicks(2763), new DateTime(2022, 2, 11, 7, 17, 46, 125, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 125, DateTimeKind.Local).AddTicks(2766), new DateTime(2022, 2, 11, 7, 17, 46, 125, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 2, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8197), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 3, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8200), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8204), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 3, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8208), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8211), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 2, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8215), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 2, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8218), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 2, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8222), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8225), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 3, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8228), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8232), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 3, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8235), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8239), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 3, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8242), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 2, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8245), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8249), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 3, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8252), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8256), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated" },
                values: new object[] { 2, new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8259), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(5307), new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(5321), new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(5324), new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(7684), new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 2, 11, 7, 17, 46, 127, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Customer_CustomerId",
                table: "Items",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
