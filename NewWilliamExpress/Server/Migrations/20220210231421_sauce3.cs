using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWilliamExpress.Server.Migrations
{
    public partial class sauce3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2188), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2189), "https://localhost:44376/StaticFiles/Images/longs2.jpg" });

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
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2194), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2195), "https://localhost:44376/StaticFiles/Images/jean3.jpg" });

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2204), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2208), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2211), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2212), "https://localhost:44376/StaticFiles/Images/jean4.png" });

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2221), new DateTime(2022, 2, 11, 7, 14, 20, 408, DateTimeKind.Local).AddTicks(2222) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 878, DateTimeKind.Local).AddTicks(5085), new DateTime(2022, 2, 11, 7, 6, 33, 879, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 879, DateTimeKind.Local).AddTicks(5455), new DateTime(2022, 2, 11, 7, 6, 33, 879, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 879, DateTimeKind.Local).AddTicks(5462), new DateTime(2022, 2, 11, 7, 6, 33, 879, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 881, DateTimeKind.Local).AddTicks(36), new DateTime(2022, 2, 11, 7, 6, 33, 881, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 881, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 2, 11, 7, 6, 33, 881, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 881, DateTimeKind.Local).AddTicks(58), new DateTime(2022, 2, 11, 7, 6, 33, 881, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7858), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7892), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7896), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7899), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7903), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7907), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7910), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7914), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7918), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7921), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7923), "https://localhost:44376/StaticFiles/Images/longs2.png" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7925), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7929), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7930), "https://localhost:44376/StaticFiles/Images/jean.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7933), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7936), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7940), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7944), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7948), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7949), "https://localhost:44376/StaticFiles/Images/jean4.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7952), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7955), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7959), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(6773), new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Shippingaddress",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(6793), new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(9412), new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(9421), new DateTime(2022, 2, 11, 7, 6, 33, 883, DateTimeKind.Local).AddTicks(9422) });
        }
    }
}
