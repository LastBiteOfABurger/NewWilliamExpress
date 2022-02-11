using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWilliamExpress.Server.Migrations
{
    public partial class sauce6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 841, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 2, 11, 11, 3, 35, 842, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 842, DateTimeKind.Local).AddTicks(3876), new DateTime(2022, 2, 11, 11, 3, 35, 842, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 842, DateTimeKind.Local).AddTicks(3882), new DateTime(2022, 2, 11, 11, 3, 35, 842, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 843, DateTimeKind.Local).AddTicks(6181), new DateTime(2022, 2, 11, 11, 3, 35, 843, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 843, DateTimeKind.Local).AddTicks(6194), new DateTime(2022, 2, 11, 11, 3, 35, 843, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 843, DateTimeKind.Local).AddTicks(6197), new DateTime(2022, 2, 11, 11, 3, 35, 843, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1764), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1782), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1785), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1788), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1791), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1795), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1798), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1802), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1805), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1808), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1811), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1815), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1818), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1821), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1825), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1828), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1831), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1834), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1837), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1841), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(8883), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(8895), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(8898), new DateTime(2022, 2, 11, 11, 3, 35, 845, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 846, DateTimeKind.Local).AddTicks(1412), new DateTime(2022, 2, 11, 11, 3, 35, 846, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 11, 3, 35, 846, DateTimeKind.Local).AddTicks(1421), new DateTime(2022, 2, 11, 11, 3, 35, 846, DateTimeKind.Local).AddTicks(1422) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4254), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4274), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4277), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4281), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4284), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4287), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4291), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4294), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4297), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4301), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4304), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4311), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4314), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4369), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4379), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4386), new DateTime(2022, 2, 11, 10, 27, 0, 707, DateTimeKind.Local).AddTicks(4387) });

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
        }
    }
}
