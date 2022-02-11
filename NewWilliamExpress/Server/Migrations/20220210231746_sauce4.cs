using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWilliamExpress.Server.Migrations
{
    public partial class sauce4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8197), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8200), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8204), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8208), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8211), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8215), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8218), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8222), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8225), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8228), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8232), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8235), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8239), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8242), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8243), "https://localhost:44376/StaticFiles/Images/longs3.webp" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8245), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8246), "https://localhost:44376/StaticFiles/Images/shorts4.jfif" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8249), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8252), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8256), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8259), new DateTime(2022, 2, 11, 7, 17, 46, 126, DateTimeKind.Local).AddTicks(8260), "https://localhost:44376/StaticFiles/Images/longs4.jfif" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 404, DateTimeKind.Local).AddTicks(5966), new DateTime(2022, 2, 11, 7, 14, 20, 405, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 405, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 2, 11, 7, 14, 20, 405, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 405, DateTimeKind.Local).AddTicks(4389), new DateTime(2022, 2, 11, 7, 14, 20, 405, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 406, DateTimeKind.Local).AddTicks(6667), new DateTime(2022, 2, 11, 7, 14, 20, 406, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 406, DateTimeKind.Local).AddTicks(6684), new DateTime(2022, 2, 11, 7, 14, 20, 406, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 406, DateTimeKind.Local).AddTicks(6687), new DateTime(2022, 2, 11, 7, 14, 20, 406, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2137), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2161), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2164), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2167), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2171), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2174), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2177), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2181), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2184), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2188), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2191), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2194), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2197), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2201), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2204), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2205), "https://localhost:44376/StaticFiles/Images/long3.webp" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2208), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2209), "https://localhost:44376/StaticFiles/Images/short4.jfif" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2211), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2214), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2218), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2221), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2222), "https://localhost:44376/StaticFiles/Images/longs4.png" });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(9303), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(9314), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(9318), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 409, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 2, 11, 7, 14, 20, 409, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 409, DateTimeKind.Local).AddTicks(1644), new DateTime(2022, 2, 11, 7, 14, 20, 409, DateTimeKind.Local).AddTicks(1645) });
        }
    }
}
