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
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BirthOfYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false),
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
                name: "ProductInstructors",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    InstructorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInstructors", x => new { x.ProductId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_ProductInstructors_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInstructors_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 6, 14, 31, 17, 154, DateTimeKind.Local).AddTicks(5769), "Bilim Kurgu Kitapları", true, false, new DateTime(2023, 7, 6, 14, 31, 17, 154, DateTimeKind.Local).AddTicks(5788), "Bilim Kurgu", "bilim-kurgu" },
                    { 2, new DateTime(2023, 7, 6, 14, 31, 17, 154, DateTimeKind.Local).AddTicks(5793), "Türkiye Tarihi Kitapları", true, false, new DateTime(2023, 7, 6, 14, 31, 17, 154, DateTimeKind.Local).AddTicks(5794), "Türkiye Tarihi", "turkiye-tarihi" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "About", "BirthOfYear", "CreatedDate", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, "İlber Ortaylı, Türk tarihçi, akademisyen ve yazar. Türk Tarih Kurumu Şeref Üyesidir. Ortaylı, Uluslararası Osmanlı Etütleri Komitesi yönetim kurulu üyesi ve Avrupa İranoloji Cemiyeti ve Avusturya-Türk Bilimler Forumu üyesidir.", 1950, new DateTime(2023, 7, 6, 14, 31, 17, 154, DateTimeKind.Local).AddTicks(9016), "İlber", true, false, "Ortaylı", new DateTime(2023, 7, 6, 14, 31, 17, 154, DateTimeKind.Local).AddTicks(9018), "ilber-ortayli.jpg", "ilber-ortayli-1" },
                    { 2, "Afşin Kum Kimdir? Afşin Kum, 1972 İzmir doğumlu. Boğaziçi Üniversitesinde bilgisayar mühendisliği, Bilgi Üniversitesinde sinema-televizyon öğrenimi gördü. 1997'den bu yana çeşitli kurumlarda yazılımcı ve yönetici olarak çalıştı.", 1960, new DateTime(2023, 7, 6, 14, 31, 17, 154, DateTimeKind.Local).AddTicks(9024), "Afşin", true, false, "Kum", new DateTime(2023, 7, 6, 14, 31, 17, 154, DateTimeKind.Local).AddTicks(9025), "afsin-kum.jpg", "afsin-kum-15" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "InstructorId", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Time", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 6, 14, 31, 17, 155, DateTimeKind.Local).AddTicks(3149), "test.", "ogrenci-kiz.jpg", 1, true, false, false, new DateTime(2023, 7, 6, 14, 31, 17, 155, DateTimeKind.Local).AddTicks(3153), "Öğrenci Kız", 100m, new DateTime(2023, 7, 6, 14, 31, 17, 155, DateTimeKind.Local).AddTicks(3162), "ogrenci-kiz-1" },
                    { 2, new DateTime(2023, 7, 6, 14, 31, 17, 155, DateTimeKind.Local).AddTicks(3167), "testtt.", "sicak-kafa.jpg", 2, true, false, true, new DateTime(2023, 7, 6, 14, 31, 17, 155, DateTimeKind.Local).AddTicks(3167), "Sıcak Kafa", 100m, new DateTime(2023, 7, 6, 14, 31, 17, 155, DateTimeKind.Local).AddTicks(3170), "sicak-kafa-20" }
                });

            migrationBuilder.InsertData(
                table: "ProductInstructors",
                columns: new[] { "InstructorId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInstructors_InstructorId",
                table: "ProductInstructors",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InstructorId",
                table: "Products",
                column: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductInstructors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
