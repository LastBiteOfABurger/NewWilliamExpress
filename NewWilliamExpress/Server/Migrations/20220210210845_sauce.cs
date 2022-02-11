using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWilliamExpress.Server.Migrations
{
    public partial class sauce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Itemtype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itemtype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Shippingaddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippingaddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staffpassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Itemname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Wear = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ItemtypeId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Itemtype_ItemtypeId",
                        column: x => x.ItemtypeId,
                        principalTable: "Itemtype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ShippingaddressId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Shippingaddress_ShippingaddressId",
                        column: x => x.ShippingaddressId,
                        principalTable: "Shippingaddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 2, 11, 5, 8, 44, 515, DateTimeKind.Local).AddTicks(9593), new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(7529), "Uniqlo", "System" },
                    { 2, "System", new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(8112), new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(8116), "CottonOn", "System" },
                    { 3, "System", new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(8117), new DateTime(2022, 2, 11, 5, 8, 44, 516, DateTimeKind.Local).AddTicks(8119), "Zara", "System" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "ContactNumber", "CreatedBy", "DateCreated", "DateUpdated", "EmailAddress", "Password", "Rating", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { 1, "90909090", "System", new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(417), new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(429), "Joe@gmail.com", "Joe1", "3", "System", "Joe" },
                    { 2, "80808080", "System", new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(433), new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(434), "Dan@gmail.com", "Dan1", "4", "System", "Dan" },
                    { 3, "81818181", "System", new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(436), new DateTime(2022, 2, 11, 5, 8, 44, 518, DateTimeKind.Local).AddTicks(437), "Sally@gmail.com", "Sally1", "5", "System", "Sally" }
                });

            migrationBuilder.InsertData(
                table: "Itemtype",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Short pants denim", null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "long jeans denim", null },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Short sleeve polo", null },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "long sleeve polo", null },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tshirt", null }
                });

            migrationBuilder.InsertData(
                table: "Shippingaddress",
                columns: new[] { "Id", "Address", "Apartment", "City", "Country", "CreatedBy", "DateCreated", "DateUpdated", "FirstName", "LastName", "PhoneNumber", "PostalCode", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Pasir ris", "HDB", "Singapore", "Singapore", "System", new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3739), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3745), "Joe", "Lim", "989898989", "342", "System" },
                    { 2, "Bedok st", "HDB", "Singapore", "Singapore", "System", new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3749), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3750), "Joe", "Mama", "989898989", "342", "System" },
                    { 3, "Tampines", "HDB", "Singapore", "Singapore", "System", new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3753), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(3754), "Joe", "Dad", "989898989", "342", "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "StaffEmailAddress", "StaffName", "Staffpassword", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(6163), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(6169), null, "Danniel", null, "System" },
                    { 2, "System", new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(6172), new DateTime(2022, 2, 11, 5, 8, 44, 520, DateTimeKind.Local).AddTicks(6173), null, "William", null, "System" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "BrandId", "CreatedBy", "CustomerId", "DateCreated", "DateUpdated", "Description", "Image", "Itemname", "ItemtypeId", "OrderId", "Price", "Quantity", "UpdatedBy", "Wear" },
                values: new object[,]
                {
                    { 1, 1, "System", 2, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6132), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6144), "very nice please buy", "", "Shorts denim pants medium", 3, null, 200.0, 35, "System", "new" },
                    { 18, 1, "System", 3, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6220), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6221), "very good", "", "TShirt Small", 3, null, 250.0, 35, "System", "new" },
                    { 17, 1, "System", 1, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6217), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6218), "Best quality", "", "long denium jeans large", 3, null, 300.0, 35, "System", "new" },
                    { 16, 1, "System", 2, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6213), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6214), "very nice please buy", "", "Shorts denim pants medium", 3, null, 200.0, 35, "System", "new" },
                    { 15, 1, "System", 3, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6209), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6210), "need to feed family", "", "long sleeve Tshirt", 3, null, 200.0, 35, "System", "new" },
                    { 14, 1, "System", 1, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6204), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6206), "give me money", "", "long sleeve Polo T", 3, null, 400.0, 35, "System", "new" },
                    { 13, 1, "System", 3, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6200), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6201), "very good", "", "TShirt Small", 3, null, 250.0, 35, "System", "new" },
                    { 12, 1, "System", 1, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6195), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6197), "Best quality", "", "long denium jeans large", 3, null, 300.0, 35, "System", "new" },
                    { 11, 1, "System", 3, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6191), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6192), "very nice please buy", "", "Shorts denim pants medium", 3, null, 200.0, 35, "System", "new" },
                    { 10, 1, "System", 1, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6188), "need to feed family", "", "long sleeve Tshirt", 3, null, 200.0, 35, "System", "new" },
                    { 9, 1, "System", 2, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6181), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6183), "give me money", "", "long sleeve Polo T", 3, null, 400.0, 35, "System", "new" },
                    { 8, 1, "System", 2, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6176), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6177), "very good", "", "TShirt Small", 3, null, 250.0, 35, "System", "new" },
                    { 7, 1, "System", 2, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6172), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6173), "Best quality", "", "long denium jeans large", 3, null, 300.0, 35, "System", "new" },
                    { 6, 1, "System", 1, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6167), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6169), "very nice please buy", "", "Shorts denim pants medium", 3, null, 200.0, 35, "System", "new" },
                    { 5, 1, "System", 3, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6163), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6164), "need to feed family", "", "long sleeve Tshirt", 3, null, 200.0, 35, "System", "new" },
                    { 4, 1, "System", 1, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6158), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6160), "give me money", "", "long sleeve Polo T", 3, null, 400.0, 35, "System", "new" },
                    { 3, 1, "System", 3, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6154), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6155), "very good", "", "TShirt Small", 3, null, 250.0, 35, "System", "new" },
                    { 2, 1, "System", 1, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6149), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6151), "Best quality", "", "long denium jeans large", 3, null, 300.0, 35, "System", "new" },
                    { 19, 1, "System", 1, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6224), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6225), "give me money", "", "long sleeve Polo T", 3, null, 400.0, 35, "System", "new" },
                    { 20, 1, "System", 2, new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 2, 11, 5, 8, 44, 519, DateTimeKind.Local).AddTicks(6228), "need to feed family", "", "long sleeve Tshirt", 3, null, 200.0, 35, "System", "new" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BrandId",
                table: "Items",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CustomerId",
                table: "Items",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemtypeId",
                table: "Items",
                column: "ItemtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrderId",
                table: "Items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ItemId",
                table: "Orders",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingaddressId",
                table: "Orders",
                column: "ShippingaddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_OrderId",
                table: "Items",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Brand_BrandId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Customer_CustomerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Itemtype_ItemtypeId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Orders_OrderId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Itemtype");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Shippingaddress");
        }
    }
}
