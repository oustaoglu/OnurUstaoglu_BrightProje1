using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EducationApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OrderStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BirthOfYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    About = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 900, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 9000, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    InstructorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10d5ae64-a612-448f-b451-48da4d287d79", null, "Diğer tüm kullanıcıların rolü bu.", "User", "USER" },
                    { "56527636-ef68-4082-9244-497201a042d1", null, "Diğer tüm kullanıcıların rolü bu.", "Strict", "STRICT" },
                    { "a93c9e41-3de8-4c82-8580-aad0b98c62b3", null, "Yöneticilerin rolü bu.", "Admin", "ADMIN" },
                    { "ab1b7c4f-fa98-4443-bb7c-bf76ba4315d5", null, "Diğer tüm kullanıcıların rolü bu.", "Normal", "NORMAL" },
                    { "e14a4450-2164-4323-9046-3cf167d5fcd4", null, "Diğer tüm kullanıcıların rolü bu.", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1391b234-0ab8-40cc-a956-227ce74f6884", 0, "Ferit Sidal Sk No:13/19 Yenibosna", "İstanbul", "c7812d60-ac29-429d-8527-d4a9c22941f9", new DateTime(1995, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "serkanselek34@gmail.com", true, "Serkan", "ERKEK", "Selek", true, null, " ", "SERKANSELEK34@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEPmtu39PDLFPF6U4LZpXiOQ1DRDONki81ncaXdl0C/X4cMu+hiVC2x7yAuVlC3WH4w==", null, false, "", false, "user" },
                    { "e1a1d538-06e3-4e4c-a91d-0800a8eedb39", 0, "Göztepe Mh. 2366 Sk. No:7 D:56 Bağcılar", "İstanbul", "251aaac5-d1b2-42c1-84fc-2f38053cf20c", new DateTime(1995, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "onrustaoglu@gmail.com", true, "Onur", "ERKEK", "Ustaoğlu", true, null, " ", "ONRUSTAOGLU@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEDC/g9jNDflW4aEYRkSilzRiIuDlkF5sFwLY7kZ2XM+/ujmVI7U7IOehHZtmFncoug==", null, false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2097), "Yazılım geliştirme, bilgisayar programlarının tasarımı, oluşturulması ve sürdürülmesi sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, işlevsellik sağlamak ve teknolojik çözümler üretmek için kodlama, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2103), "Yazılım Geliştime", "yazilim-gelistirme" },
                    { 2, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2110), "Mobil uygulama geliştirme, mobil platformlarda çalışabilen kullanışlı ve etkileşimli yazılım uygulamalarının tasarımı, oluşturulması ve dağıtılması sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, sorunlara çözüm sunmak ve kullanıcı deneyimini geliştirmek için programlama, arayüz tasarımı, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2111), "Mobil Uygulama Geliştirme", "mobil-uygulama-gelistirme" },
                    { 3, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2112), "Oyun geliştirme, video oyunlarının tasarımı, programlaması ve oluşturulması sürecidir. Bu süreç, oyun kavramının belirlenmesi, hikaye yazımı, karakter tasarımı, dünya oluşturma, grafik ve ses tasarımı, oyun mekaniği ve kullanıcı arayüzü gibi aşamaları içerir.", true, false, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2112), "Oyun Geliştime", "oyun-gelistirme" },
                    { 4, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2113), "Web, dünya genelinde bilgilere erişim sağlayan ve kullanıcıların çeşitli hizmetlere bağlanmasını mümkün kılan bir ağdır. Web, HTML, CSS ve JavaScript gibi teknolojilerle oluşturulan web siteleri ve web uygulamaları aracılığıyla çalışır.", true, false, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2114), "Web", "web" },
                    { 5, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2115), "Veritabanı, yapılandırılmış verilerin depolandığı ve yönetildiği bir elektronik sistemdir. Veritabanları, bilgiyi organize etmek, erişmek, güncellemek ve analiz etmek için kullanılır. İşletmeler, kuruluşlar ve web uygulamaları gibi birçok alan veritabanlarını kullanır.", true, false, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2115), "Veritabanı", "veritabani" },
                    { 6, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2116), "DevOps, yazılım geliştirme ve işletim süreçlerini birleştirerek, yazılım projelerinin daha hızlı, güvenilir ve sürekli bir şekilde dağıtılmasını sağlayan bir yaklaşımdır. Bu metodoloji, geliştirme (Development) ve işletim (Operations) ekipleri arasında işbirliği ve iletişimi teşvik eder.", true, false, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2116), "DevOps", "devops" },
                    { 7, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2117), "Bulut, internet üzerinde sunulan paylaşımlı bilgi işlem kaynaklarını ifade eder. Bulut hizmetleri, sunucular, depolama, veritabanları, ağ altyapısı ve uygulama hizmetleri gibi kaynaklara erişimi kolaylaştırır. Kullanıcılar, istedikleri zaman istedikleri yerden bu kaynaklara güvenli bir şekilde erişebilir ve ihtiyaçlarına göre ölçeklendirebilir.", true, false, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(2118), "Bulut", "bulut" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "About", "BirthOfYear", "CreatedDate", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "ProductId", "ProductId1", "Url" },
                values: new object[,]
                {
                    { 1, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4517), "Dominic", true, false, "Harmon", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4518), "1.png", 1, null, null },
                    { 2, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4525), "Justina", true, false, "Burch", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4525), "1.png", 2, null, null },
                    { 3, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1985, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4527), "Madison", true, false, "Beard", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4528), "1.png", 3, null, null },
                    { 4, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4530), "Sara", true, false, "Wade", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4530), "1.png", 4, null, null },
                    { 5, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1988, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4532), "Jacob", true, false, "Hunt", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4532), "1.png", 5, null, null },
                    { 6, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1989, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4533), "Osamu", true, false, "Dazai", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4534), "1.png", 6, null, null },
                    { 7, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1983, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4535), "Zachery", true, false, "Salas", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4535), "1.png", 7, null, null },
                    { 8, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4536), "Matt", true, false, "Haig", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4537), "1.png", 8, null, null },
                    { 9, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4538), "William", true, false, "Hawkingan", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4538), "1.png", 9, null, null },
                    { 10, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4540), "Geraldine", true, false, "Richmond", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4540), "1.png", 10, null, null },
                    { 11, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1983, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4541), "Steffan", true, false, "Ros", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4542), "1.png", 11, null, null },
                    { 12, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1991, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4543), "Nichole", true, false, "Talley", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4543), "1.png", 12, null, null },
                    { 13, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1979, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4545), "Yetta", true, false, "Sheppard", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4545), "1.png", 13, null, null },
                    { 14, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1978, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4546), "Elijah", true, false, "Farley", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4546), "1.png", 14, null, null },
                    { 15, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1991, new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4548), "Neil", true, false, "Wooten", new DateTime(2023, 8, 14, 19, 30, 26, 638, DateTimeKind.Local).AddTicks(4548), "1.png", 15, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "10d5ae64-a612-448f-b451-48da4d287d79", "1391b234-0ab8-40cc-a956-227ce74f6884" },
                    { "a93c9e41-3de8-4c82-8580-aad0b98c62b3", "e1a1d538-06e3-4e4c-a91d-0800a8eedb39" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 14, 19, 30, 26, 637, DateTimeKind.Local).AddTicks(6034), true, false, new DateTime(2023, 8, 14, 19, 30, 26, 637, DateTimeKind.Local).AddTicks(6062), "e1a1d538-06e3-4e4c-a91d-0800a8eedb39" },
                    { 2, new DateTime(2023, 8, 14, 19, 30, 26, 637, DateTimeKind.Local).AddTicks(6070), true, false, new DateTime(2023, 8, 14, 19, 30, 26, 637, DateTimeKind.Local).AddTicks(6070), "1391b234-0ab8-40cc-a956-227ce74f6884" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "InstructorId", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Time", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9393), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "1.jpg", 1, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9396), ".NET (.NET Core, MVC, Web API)", 900m, 200, ".net-core-mvc" },
                    { 2, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9403), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "2.jpg", 2, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9403), "Java (Spring, Java SE, Java EE)", 900m, 200, "java" },
                    { 3, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9406), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "3.png", 3, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9406), "Python", 900m, 200, "python" },
                    { 4, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9408), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "4.jpeg", 4, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9408), "JavaScript", 900m, 200, "javascript" },
                    { 5, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9410), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "5.jpg", 5, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9410), "C/C++", 900m, 200, "c/c++	" },
                    { 6, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9412), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "6.png", 6, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9412), "iOS & Android", 900m, 200, "ios-android" },
                    { 7, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9413), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "7.png", 7, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9414), "React Native", 900m, 200, "react-native" },
                    { 8, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9415), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "8.png", 8, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9416), "Flutter", 900m, 200, "flutter" },
                    { 9, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9417), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "9.jpg", 9, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9417), "Ionic", 900m, 200, "ionic" },
                    { 10, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9419), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "10.jpeg", 10, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9419), "Unity", 900m, 200, "unity" },
                    { 11, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9421), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "11.png", 11, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9421), "Unreal Engine", 900m, 200, "unreal-engine" },
                    { 12, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9423), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "12.png", 12, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9423), "GameMaker Studio", 900m, 200, "gamemaker-studio" },
                    { 13, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9425), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "13.jpeg", 13, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9425), "Buildbox", 900m, 200, "buildbox" },
                    { 14, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9426), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "14.png", 14, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9427), "PHP", 900m, 200, "php" },
                    { 15, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9428), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "15.jpeg", 8, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9429), "React", 900m, 200, "react" },
                    { 16, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9430), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "16.png", 9, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9430), "Angular", 900m, 200, "angular" },
                    { 17, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9432), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "17.png", 10, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9432), "Node.js", 900m, 200, "nodejs" },
                    { 18, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9434), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "18.jpg", 11, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9434), "Microsoft SQL Server", 900m, 200, "microsoft-sql-server" },
                    { 19, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9436), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "19.png", 12, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9436), "MySQL", 900m, 200, "mysql" },
                    { 20, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9437), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "20.png", 13, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9438), "PostgreSQL", 900m, 200, "postgresql" },
                    { 21, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9439), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "21.png", 11, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9440), "SQLite", 900m, 200, "sqlite" },
                    { 22, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9441), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "22.png", 12, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9441), "Oracle", 900m, 200, "oracle" },
                    { 23, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9443), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "23.png", 13, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9443), "Docker", 900m, 200, "docker" },
                    { 24, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9445), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "24.png", 14, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9445), "Jenkins", 900m, 200, "jenkins" },
                    { 25, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9447), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "25.png", 8, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9447), "Ansible", 900m, 200, "ansible" },
                    { 26, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9448), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "26.jpeg", 9, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9449), "Sonarcube", 900m, 200, "sonarcube" },
                    { 27, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9450), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "27.png", 10, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9451), "AWS", 900m, 200, "aws" },
                    { 28, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9452), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "28.png", 11, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9452), "Azure", 900m, 200, "azure" },
                    { 29, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9454), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "29.png", 12, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9454), "Serverless", 900m, 200, "serverless" },
                    { 30, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9456), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "30.png", 12, true, false, true, new DateTime(2023, 8, 14, 19, 30, 26, 639, DateTimeKind.Local).AddTicks(9456), "Cloud Storage", 900m, 200, "cloudstorage" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 2, 8 },
                    { 2, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 5, 18 },
                    { 5, 19 },
                    { 5, 20 },
                    { 5, 21 },
                    { 5, 22 },
                    { 6, 23 },
                    { 6, 24 },
                    { 6, 25 },
                    { 6, 26 },
                    { 7, 27 },
                    { 7, 28 },
                    { 7, 29 },
                    { 7, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ProductId1",
                table: "Instructors",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InstructorId",
                table: "Products",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Products_ProductId1",
                table: "Instructors",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Products_ProductId1",
                table: "Instructors");

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
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
