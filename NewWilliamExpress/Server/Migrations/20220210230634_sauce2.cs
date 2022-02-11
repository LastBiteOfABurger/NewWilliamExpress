using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWilliamExpress.Server.Migrations
{
    public partial class sauce2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7896), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7897), "https://localhost:44376/StaticFiles/Images/tshirt1.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7899), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7900), "https://localhost:44376/StaticFiles/Images/polot1.png" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7903), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7904), "https://localhost:44376/StaticFiles/Images/longs1jpg.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7907), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7908), "https://localhost:44376/StaticFiles/Images/shorts1.jfif" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7910), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7912), "https://localhost:44376/StaticFiles/Images/jean2.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7914), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7915), "https://localhost:44376/StaticFiles/Images/tshirt2.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7918), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7919), "https://localhost:44376/StaticFiles/Images/polot2.jpg" });

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
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7925), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7926), "https://localhost:44376/StaticFiles/Images/polot3.jpg" });

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
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7933), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7934), "https://localhost:44376/StaticFiles/Images/tshirt3.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7936), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7937), "https://localhost:44376/StaticFiles/Images/polot3.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7940), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7941), "https://localhost:44376/StaticFiles/Images/long3.webp" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7944), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7945), "https://localhost:44376/StaticFiles/Images/short4.jfif" });

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
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7952), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7953), "https://localhost:44376/StaticFiles/Images/tshirt4.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7955), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7956), "https://localhost:44376/StaticFiles/Images/polot4.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7959), new DateTime(2022, 2, 11, 7, 6, 33, 882, DateTimeKind.Local).AddTicks(7960), "https://localhost:44376/StaticFiles/Images/longs4.png" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4663), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4680), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4684), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4685), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4687), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4689), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4691), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4692), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4695), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4696), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4699), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4700), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4703), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4704), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4706), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4707), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4710), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4711), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4713), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4715), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4717), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4718), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4720), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4722), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4724), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4725), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4727), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4729), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4731), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4732), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4735), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4736), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4738), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4739), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4742), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4743), "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4745), new DateTime(2022, 2, 11, 6, 50, 33, 318, DateTimeKind.Local).AddTicks(4746), "" });

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
    }
}
