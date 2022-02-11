using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWilliamExpress.Server.Migrations
{
    public partial class sauce1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 314, DateTimeKind.Local).AddTicks(7091), new DateTime(2022, 2, 11, 6, 50, 33, 315, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 315, DateTimeKind.Local).AddTicks(5915), new DateTime(2022, 2, 11, 6, 50, 33, 315, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 315, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 2, 11, 6, 50, 33, 315, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 316, DateTimeKind.Local).AddTicks(8883), new DateTime(2022, 2, 11, 6, 50, 33, 316, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 316, DateTimeKind.Local).AddTicks(8898), new DateTime(2022, 2, 11, 6, 50, 33, 316, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 316, DateTimeKind.Local).AddTicks(8901), new DateTime(2022, 2, 11, 6, 50, 33, 316, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4663), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4675), "https://localhost:44376/StaticFiles/Images/shorts1.jfif" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4680), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4682), "https://localhost:44376/StaticFiles/Images/jean1.png" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4684), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4687), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4691), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4695), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4699), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4703), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4706), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4710), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4713), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4717), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4720), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4724), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4727), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4731), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4735), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4738), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4742), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4745), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(2213), new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(2227), new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(4571), new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(4579), new DateTime(2022, 2, 11, 6, 50, 33, 319, DateTimeKind.Local).AddTicks(4580) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 515, DateTimeKind.Local).AddTicks(9593), new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(8112), new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(8117), new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(417), new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(433), new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(436), new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6132), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6144), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6149), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6151), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6154), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6158), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6163), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6167), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6172), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6176), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6181), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6191), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6195), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6200), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6204), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6209), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6213), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6217), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6220), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6224), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3739), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3749), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3753), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(6163), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(6172), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(6173) });
        }
    }
}
