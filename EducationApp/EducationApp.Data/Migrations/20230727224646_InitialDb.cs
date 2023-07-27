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
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    { "0fb7a860-63ec-478a-bc1d-ac9857a16ce6", null, "Diğer tüm kullanıcıların rolü bu.", "User", "USER" },
                    { "9836982d-6c1c-4e33-8a90-03f70b029031", null, "Yöneticilerin rolü bu.", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20aacc70-f2b6-4393-a1c0-0e4b350ab564", 0, "Barbaros Bulvarı Feda İş Hanı K:5 D:23 Beşiktaş", "İstanbul", "6d950686-5468-4ec1-bc69-13a4c39bf9bf", new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "muratkendirli@gmail.com", true, "Murat", "Erkek", "Kendirli", true, null, " ", "MURATKENDIRLI@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEGiqbk/yV0JHYuW+KS9Ft4dZ0iP6mGx2ehb8rKSKYeuqevB2mTPi+YHOufr3WEo0Cw==", null, false, "", false, "user" },
                    { "300b6f1f-4e38-4bec-87b2-f3debcc2b62f", 0, "Kemalpaşa Mh. Zühtübey Sk. No:12 D:3 Üsküdar", "İstanbul", "7203d510-8ba0-4711-8c49-00e31b0bf02f", new DateTime(1985, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Kadın", "Foça", true, null, " ", "DENIZFOCA@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEJAbJc6ptm2SU01S7v9TFKWNaaT6/HaBukgWctd/KvT4reVumQP9lSeMQUWiFSsP3Q==", null, false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7180), "Yazılım geliştirme, bilgisayar programlarının tasarımı, oluşturulması ve sürdürülmesi sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, işlevsellik sağlamak ve teknolojik çözümler üretmek için kodlama, test etme ve dağıtma adımlarını içerir. Yazılım geliştirme, bilgisayar, mobil cihazlar, web uygulamaları, oyunlar ve daha fazlası gibi çeşitli alanlarda kullanılır. Bu süreçte programlama dilleri, veritabanları, algoritmalar ve yazılım tasarım prensipleri gibi araçlar kullanılır. Yazılım geliştirme, hızlı teknolojik ilerlemelerle birlikte sürekli evrilen ve iyileşen bir disiplindir ve kullanıcıların ihtiyaçlarını karşılamak için yenilikçi ve güvenilir çözümler sunmayı hedefler.", true, false, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7187), "Yazılım Geliştime", "yazilim-gelistirme" },
                    { 2, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7192), "Mobil uygulama geliştirme, mobil platformlarda çalışabilen kullanışlı ve etkileşimli yazılım uygulamalarının tasarımı, oluşturulması ve dağıtılması sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, sorunlara çözüm sunmak ve kullanıcı deneyimini geliştirmek için programlama, arayüz tasarımı, test etme ve dağıtma adımlarını içerir. Mobil uygulama geliştiricileri, Android veya iOS gibi belirli platformlar için uygun programlama dilleri ve geliştirme araçları kullanır. Bu süreç, hızlı teknolojik değişimlerle birlikte sürekli gelişir ve kullanıcıların günlük yaşamlarını kolaylaştıran, eğlence sunan ve işlevsellik sağlayan yenilikçi uygulamaların ortaya çıkmasını sağlar. Mobil uygulama geliştirme, geniş bir kullanıcı tabanına erişmek ve büyüyen mobil pazarlardan yararlanmak isteyen işletmeler ve geliştiriciler için önemli bir stratejidir.", true, false, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7192), "Mobil Uygulama Geliştirme", "mobil-uygulama-gelistirme" },
                    { 3, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7195), "Oyun geliştirme, video oyunlarının tasarımı, programlaması ve oluşturulması sürecidir. Bu süreç, oyun kavramının belirlenmesi, hikaye yazımı, karakter tasarımı, dünya oluşturma, grafik ve ses tasarımı, oyun mekaniği ve kullanıcı arayüzü gibi aşamaları içerir. Oyun geliştirme ekipleri, oyun programcıları, sanatçılar, tasarımcılar ve ses mühendisleri gibi farklı disiplinlerden profesyonelleri içerir. Geliştiriciler, oyun motorları, programlama dilleri, grafik araçları ve geliştirme ortamları kullanarak oyunun yapısını oluştururlar. Oyun geliştirme, eğlence endüstrisinde önemli bir rol oynar ve oyunculara heyecan verici deneyimler sunmak için sürekli yenilikçilik ve yaratıcılık gerektirir.", true, false, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7195), "Oyun Geliştime", "oyun-gelistirme" },
                    { 4, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7197), "Web, dünya genelinde bilgilere erişim sağlayan ve kullanıcıların çeşitli hizmetlere bağlanmasını mümkün kılan bir ağdır. Web, HTML, CSS ve JavaScript gibi teknolojilerle oluşturulan web siteleri ve web uygulamaları aracılığıyla çalışır. Web, kullanıcıların arama yapma, e-posta gönderme, sosyal ağlarda etkileşimde bulunma, alışveriş yapma ve daha birçok işlemi gerçekleştirebilecekleri bir platform sunar. Web geliştirme, web sitelerinin ve uygulamalarının tasarımını, kodlamasını, testini ve dağıtımını içerir. Bu süreçte kullanıcı deneyimi, güvenlik, performans ve uyumluluk önemlidir. Web, küresel bağlantıyı sağlayan ve bilgiye kolay erişimi temsil eden önemli bir iletişim ve etkileşim aracıdır.", true, false, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7197), "Web", "web" },
                    { 5, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7199), "Veritabanı, yapılandırılmış verilerin depolandığı ve yönetildiği bir elektronik sistemdir. Veritabanları, bilgiyi organize etmek, erişmek, güncellemek ve analiz etmek için kullanılır. İşletmeler, kuruluşlar ve web uygulamaları gibi birçok alan veritabanlarını kullanır. Veritabanı yönetim sistemleri (DBMS), veritabanının oluşturulması, yapılandırılması, sorgulanması ve güncellenmesi için gereken araçları sağlar. Veritabanı tasarımı, veri bütünlüğü, performans optimizasyonu ve güvenlik gibi konular önemlidir. Veritabanları, büyük veri kümelerini işlemek, veri analizi yapmak ve karar verme süreçlerini desteklemek için önemli bir rol oynar. Veritabanları, verilerin etkili bir şekilde yönetilmesini ve bilgi tabanlı çözümler sunulmasını sağlar.", true, false, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7199), "Veritabanı", "veritabani" },
                    { 6, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7200), "DevOps, yazılım geliştirme ve işletim süreçlerini birleştirerek, yazılım projelerinin daha hızlı, güvenilir ve sürekli bir şekilde dağıtılmasını sağlayan bir yaklaşımdır. Bu metodoloji, geliştirme (Development) ve işletim (Operations) ekipleri arasında işbirliği ve iletişimi teşvik eder. DevOps, otomasyon, sürekli entegrasyon ve sürekli dağıtım gibi pratikleri kullanarak, yazılımın yaşam döngüsünü hızlandırır ve kaliteyi artırır. Ayrıca, altyapı yönetimi, hata izleme ve performans analizi gibi operasyonel süreçlere odaklanır. DevOps, esneklik, hızlı yanıt verme ve müşteri memnuniyetini artırma gibi faydalar sağlayarak yazılım projelerinin başarısını destekler.", true, false, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7201), "DevOps", "devops" },
                    { 7, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7202), "Bulut, internet üzerinde sunulan paylaşımlı bilgi işlem kaynaklarını ifade eder. Bulut hizmetleri, sunucular, depolama, veritabanları, ağ altyapısı ve uygulama hizmetleri gibi kaynaklara erişimi kolaylaştırır. Kullanıcılar, istedikleri zaman istedikleri yerden bu kaynaklara güvenli bir şekilde erişebilir ve ihtiyaçlarına göre ölçeklendirebilir. Bulut hizmetleri, esneklik, ölçeklenebilirlik, veri yedekleme, sürekli çalışma ve maliyet verimliliği gibi avantajlar sağlar. Bulut, işletmeler için altyapı maliyetlerini azaltırken, geliştiriciler için hızlı bir şekilde uygulama dağıtma imkanı sunar. Ayrıca, kullanıcılara mobil cihazlar ve web tarayıcıları aracılığıyla geniş bir hizmet yelpazesine erişme kolaylığı sağlar.", true, false, new DateTime(2023, 7, 28, 1, 46, 45, 978, DateTimeKind.Local).AddTicks(7203), "Bulut", "bulut" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "About", "BirthOfYear", "CreatedDate", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "ProductId", "ProductId1", "Url" },
                values: new object[,]
                {
                    { 1, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1990, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(808), "Dominic", true, false, "Harmon", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(812), "1.png", 1, null, null },
                    { 2, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1990, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(817), "Justina", true, false, "Burch", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(817), "1.png", 2, null, null },
                    { 3, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1985, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(820), "Madison", true, false, "Beard", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(821), "1.png", 3, null, null },
                    { 4, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1982, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(823), "Sara", true, false, "Wade", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(823), "1.png", 4, null, null },
                    { 5, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1988, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(825), "Jacob", true, false, "Hunt", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(826), "1.png", 5, null, null },
                    { 6, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1989, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(828), "Osamu", true, false, "Dazai", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(847), "1.png", 6, null, null },
                    { 7, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1983, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(861), "Zachery", true, false, "Salas", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(862), "1.png", 7, null, null },
                    { 8, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1982, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(864), "Matt", true, false, "Haig", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(864), "1.png", 8, null, null },
                    { 9, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1982, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(866), "William", true, false, "Hawkingan", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(867), "1.png", 9, null, null },
                    { 10, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1990, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(869), "Geraldine", true, false, "Richmond", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(869), "1.png", 10, null, null },
                    { 11, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1983, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(871), "Steffan", true, false, "Ros", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(872), "1.png", 11, null, null },
                    { 12, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1991, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(873), "Nichole", true, false, "Talley", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(874), "1.png", 12, null, null },
                    { 13, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1979, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(876), "Yetta", true, false, "Sheppard", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(876), "1.png", 13, null, null },
                    { 14, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1978, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(878), "Elijah", true, false, "Farley", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(879), "1.png", 14, null, null },
                    { 15, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır. Programlama dillerinin temel yapılarını öğreterek öğrencilerin mantıklı çözümler üretmelerine yardımcı olur. Nesne yönelimli programlama (OOP), veritabanı yönetimi, web ve mobil uygulama geliştirme gibi konulara odaklanabilir. Algoritma ve veri yapıları öğreterek analitik düşünme yeteneğini güçlendirir. Yazılım mühendisliği prensiplerini aktarırken, test ve hata ayıklama tekniklerini de vurgular. Proje tabanlı çalışmalarla pratik deneyim sağlayarak öğrencilerin gerçek dünya projelerinde başarılı olmalarını hedefler. Sürekli güncellenen teknolojilere uyum sağlayarak sektörde rekabetçi bireyler yetiştirir.", 1991, new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(881), "Neil", true, false, "Wooten", new DateTime(2023, 7, 28, 1, 46, 45, 979, DateTimeKind.Local).AddTicks(881), "1.png", 15, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0fb7a860-63ec-478a-bc1d-ac9857a16ce6", "20aacc70-f2b6-4393-a1c0-0e4b350ab564" },
                    { "9836982d-6c1c-4e33-8a90-03f70b029031", "300b6f1f-4e38-4bec-87b2-f3debcc2b62f" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 28, 1, 46, 45, 977, DateTimeKind.Local).AddTicks(9614), true, false, new DateTime(2023, 7, 28, 1, 46, 45, 977, DateTimeKind.Local).AddTicks(9634), "300b6f1f-4e38-4bec-87b2-f3debcc2b62f" },
                    { 2, new DateTime(2023, 7, 28, 1, 46, 45, 977, DateTimeKind.Local).AddTicks(9641), true, false, new DateTime(2023, 7, 28, 1, 46, 45, 977, DateTimeKind.Local).AddTicks(9641), "20aacc70-f2b6-4393-a1c0-0e4b350ab564" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "InstructorId", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Time", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7030), "test.", "1.jpg", 1, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7038), ".NET (.NET Core, MVC, Web API)", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7046), ".net-core-mvc" },
                    { 2, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7049), "testtt.", "2.jpg", 2, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7049), "Java (Spring, Java SE, Java EE)", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7052), "java" },
                    { 3, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7095), "test.", "3.png", 3, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7097), "Python", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7099), "python" },
                    { 4, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7100), "test.", "4.jpeg", 4, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7101), "JavaScript", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7103), "javascript" },
                    { 5, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7104), "test.", "5.jpg", 5, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7105), "C/C++", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7107), "c/c++	" },
                    { 6, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7108), "testtt.", "6.png", 6, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7109), "iOS & Android", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7110), "ios-android" },
                    { 7, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7111), "test.", "7.png", 7, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7112), "React Native", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7114), "react-native" },
                    { 8, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7116), "test.", "8.png", 8, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7117), "Flutter", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7119), "flutter" },
                    { 9, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7120), "test.", "9.jpg", 9, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7120), "Ionic", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7122), "ionic" },
                    { 10, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7123), "test.", "10.jpeg", 10, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7124), "Unity", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7126), "unity" },
                    { 11, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7127), "test.", "11.png", 11, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7127), "Unreal Engine", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7129), "unreal-engine" },
                    { 12, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7130), "testtt.", "12.png", 12, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7131), "GameMaker Studio", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7132), "gamemaker-studio" },
                    { 13, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7133), "test.", "13.jpeg", 13, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7134), "Buildbox", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7136), "buildbox" },
                    { 14, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7137), "test.", "14.png", 14, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7137), "PHP", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7139), "php" },
                    { 15, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7140), "test.", "15.jpeg", 8, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7140), "React", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7142), "react" },
                    { 16, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7143), "test.", "16.png", 9, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7144), "Angular", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7146), "angular" },
                    { 17, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7147), "test.", "17.png", 10, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7147), "Node.js", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7149), "nodejs" },
                    { 18, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7150), "test.", "18.jpg", 11, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7151), "Microsoft SQL Server", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7152), "microsoft-sql-server" },
                    { 19, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7155), "testtt.", "19.png", 12, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7155), "MySQL", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7157), "mysql" },
                    { 20, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7158), "test.", "20.png", 13, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7159), "PostgreSQL", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7160), "postgresql" },
                    { 21, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7162), "test.", "21.png", 11, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7162), "SQLite", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7164), "sqlite" },
                    { 22, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7165), "testtt.", "22.png", 12, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7165), "Oracle", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7167), "oracle" },
                    { 23, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7168), "test.", "23.png", 13, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7169), "Docker", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7170), "docker" },
                    { 24, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7172), "test.", "24.png", 14, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7172), "Jenkins", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7174), "jenkins" },
                    { 25, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7175), "test.", "25.png", 8, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7175), "Ansible", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7177), "ansible" },
                    { 26, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7178), "test.", "26.jpeg", 9, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7179), "Sonarcube", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7180), "sonarcube" },
                    { 27, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7182), "test.", "27.png", 10, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7182), "AWS", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7184), "aws" },
                    { 28, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7185), "test.", "28.png", 11, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7186), "Azure", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7187), "azure" },
                    { 29, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7188), "testtt.", "29.png", 12, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7189), "Serverless", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7191), "serverless" },
                    { 30, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7192), "testtt.", "30.png", 12, true, false, true, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7192), "Cloud Storage", 100m, new DateTime(2023, 7, 28, 1, 46, 45, 981, DateTimeKind.Local).AddTicks(7199), "cloudstorage" }
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
