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
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2882), "sadafsffddsavb", true, false, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2892), "Yazılım Geliştime", "yazilim-gelistirme" },
                    { 2, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2896), "asdasfdsffsdf", true, false, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2896), "Mobil", "mobil" },
                    { 3, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2897), "asdasfdsffsdf", true, false, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2898), "Web", "web" },
                    { 4, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2898), "asdasfdsffsdf", true, false, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2899), "Veri Tabanı", "veri-tabanı" },
                    { 5, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2900), "asdasfdsffsdf", true, false, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2900), "Veri ve Veri Bilimi", "veri-ve-veri-bilimi" },
                    { 6, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2901), "asdasfdsffsdf", true, false, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2901), "DevOps", "devops" },
                    { 7, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2902), "asdasfdsffsdf", true, false, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(2902), "Bulut", "bulut" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "About", "BirthOfYear", "CreatedDate", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, "İlber Ortaylı, Türk tarihçi, akademisyen ve yazar. Türk Tarih Kurumu Şeref Üyesidir. Ortaylı, Uluslararası Osmanlı Etütleri Komitesi yönetim kurulu üyesi ve Avrupa İranoloji Cemiyeti ve Avusturya-Türk Bilimler Forumu üyesidir.", 1950, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4501), "İlber", true, false, "Ortaylı", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4503), "ilber-ortayli.jpg", "ilber-ortayli-1" },
                    { 2, "Afşin Kum Kimdir? Afşin Kum, 1972 İzmir doğumlu. Boğaziçi Üniversitesinde bilgisayar mühendisliği, Bilgi Üniversitesinde sinema-televizyon öğrenimi gördü. 1997'den bu yana çeşitli kurumlarda yazılımcı ve yönetici olarak çalıştı.", 1960, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4506), "Afşin", true, false, "Kum", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4506), "afsin-kum.jpg", "afsin-kum-15" },
                    { 3, "Herbert George Wells ya da daha çok tanındığı adla H. G. Wells, Dünyaların Savaşı, GörünmezAdam,Dr Moreau'nun Adası ve Zaman Makinesi adlı bilimkurgu romanlarıyla tanınan ama neredeyseedebiyatınherdalında birçok eser vermiş olan İngiliz yazardır. Sosyalist olduğunu açıkça söyleyenH.G. Wells'inçoğueserinde önemli ölçüde siyasi ve sosyal yorumlar bulunmaktadır. Jules Verne gibigelecektekiteknolojikgelişmeleri anlattığı kitaplarıyla bilimkurgu dalının öncülerinden hattayaratıcılarındansayılmaktadır.", 1866, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4508), "Herbert George", true, false, "Wells", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4508), "herbert-george-wells.jpg", "herbert-george-wells-3" },
                    { 4, "Okula Essex'de gitti. Cambridge'de St. Johns College'e devam ederken Footlightstiyatro kulübünde görev aldı. Pek çok iş denedi. Hastanede hizmetlilik, inşaat işçiliği,kümes temizlikçiliği, bir Arap aile için korumalık yaptı. Daha sonra BBC'de Dr. Whodizisinde yapımcılık ve senaryo editörlüğü yaptı. Dr. Who'nun üç bölümünü yazdı. MontyPyton grubundan Graham Chapman ile birlikte çalıştı.\r\n\r\nBBC'de yayımlanan TheHitchhiker's Guide to the Galaxy (Otostopçunun Galaksi Rehberi) adlı radyo oyunu ile ünlüoldu. Oyun, kitap olarak da yayımlandı. Bu radyo oyunundan aynı adlı bir bilgisayar oyunuda üretti. Daha sonra Bureaucracy ve Starship Titanic adlı bilgisayar oyunları üzerinde deçalıştı. Starship Titanic sonradan bir kitap olarak da yayımlandı, ancak Adams'ın hem oyunhem de kitap üzerinde çalışacak zamanı olmadığından kitabı Terry Jones yazdı. İleriderecede bir Beatles hayranıydı.", 1982, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4509), "Douglas", true, false, "Adams", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4510), "douglas-adams.jpg", "douglas-adams-4" },
                    { 5, "Ray Douglas Bradbury korku ve bilimkurgu tarzlarında yazan Amerikalı bir yazardır.En çok bilinen kitapları 1950'de yazdığı kısa hikâyeler kitabı ve bir roman olan TheMartian Chronicles ve 1953'te yazdığı başyapıtı olan Fahrenheit 451'dir. Los Angeles'ta 91yaşında öldü.", 1920, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4511), "Ray Douglas", true, false, "Bradbury", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4511), "ray-douglas-bradbury.jpg", "ray-douglas-bradbury-5" },
                    { 6, "Japon yazardır. Tsugaru Yarımadası’nın merkezi yakınlarında küçük bir kasaba olanKanagi’de doğdu. Asıl adı Şuuci Tsuşima'dır. Ailedeki siyasetçi olma geleneğine karşıçıkarak, yazar olmaya karar verdi. Yirmi yaşında Tokyo Üniversitesi Fransız EdebiyatıBölümü’ne kaydını yaptırdı. Hayatının büyük bölümünde esrarkeş, veremli, asabi, kavgacı vealkolik biri olarak birkaç kez intihar etmeye kalkıştı. Dazai, 1948’de metresiyle birliktesuya atlayarak intihar etti. Ölümünün üzerinden bunca sene geçmesine rağmen, Japonya’dahâlâ ilgi gören bir yazardır. Eserlerinin çoğunluğunda yalnızlığı ele alır. Yalnızlık önplanda iken insanın arayış içinde olması ve insanın varoluşunu, içe dönüklüğünü yanitemelde insanı ele alır.", 1909, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4512), "Osamu", true, false, "Dazai", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4513), "osamu-dazai.jpg", "osamu-dazai-6" },
                    { 7, "Eric Arthur Blair veya daha bilinen takma adıyla George Orwell 20. yüzyıl İngilizedebiyatının önde gelen kalemleri arasında yer alan İngiliz romancı, gazeteci veeleştirmen. En çok, dünyaca ünlü Bin Dokuz Yüz Seksen Dört adlı romanı ve bu romandayarattığı Big Brother kavramı ile tanınır. ", 1903, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4566), "George", true, false, "Orwell", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4566), "george-orwell.png", "george-orwell-7" },
                    { 8, "Matt Haig bir İngiliz yazar ve gazetecidir. Çocuklar ve yetişkinler için, genellikl spekülatif kurgu türünde hem kurgu hem de kurgu olmayan kitaplar yazmıştır. Haig, çocukla ve yetişkinler için hem kurgu hem de kurgu olmayan kitapların yazarıdır. Kurgusal olmayançalışması Reasons to Stay Alive , Sunday Times'ın en çok satanlar listesinde bir numaraydıve 46 hafta boyunca Birleşik Krallık'ta ilk 10'da yer aldı. En çok satan çocuk romanı 'Noe Baba ve Ben' şu anda filme uyarlanıyor, yapımcılığını StudioCanal ve Blueprint Picturesüstleniyor.", 1982, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4567), "Matt", true, false, "Haig", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4568), "matt-haig.jpeg", "matt-haig-8" },
                    { 9, "Stephen William Hawking, İngiliz fizikçi, kozmolog, astronom, teorisyen ve yazar.Stephen Hawking, Einstein'dan bu yana dünyaya gelen en parlak teorik fizikçi olarak kabuledilmektedir. 12 onur derecesi almıştır. 1982'de CBE ile ödüllendirilmiş, bundan başkabirçok madalya ve ödül almıştır. ", 1942, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4569), "Stephen William", true, false, "ArmHawkingan", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4569), "stephen-william-hawking.jpg", "stephen-william-hawking-9" },
                    { 10, "Fyodor Mihayloviç Dostoyevski, Rus roman yazarıdır. Çocukluğunu sarhoş bir baba vehasta bir anne arasında geçiren Dostoyevski, annesinin ölümünden sonra Petersburg'dakiMühendis Okulu'na girdi. Babasının ölüm haberini de burada aldı. Okulu başarıylabitirdikten sonra istihkâm bölüğüne girdi.", 11821, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4570), "Fyodor", true, false, "Dostoyevski", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4571), "fyodor-dostoyevski.jpg", "fyodor-dostoyevski-10" },
                    { 11, "Manon Steffan Ros, Galli bir romancı, oyun yazarı, oyun yazarı, senarist vemüzisyendir. Tamamı Galce olan yirmiden fazla çocuk kitabı ve yetişkinler için üç romanınyazarıdır. Ödüllü romanı Blasu, The Seasoning başlığı altında İngilizce'ye çevrildi.", 1983, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4572), "Manon Steffan", true, false, "Ros", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4572), "manon-steffan-ros.jpg", "manon-steffan-ros-11" },
                    { 12, "Mustafa Kemal Atatürk, Türk asker ve devlet adamıdır. Türk Kurtuluş Savaşı'nınbaşkomutanı, Türkiye Cumhuriyeti'nin kurucusu ve ilk cumhurbaşkanıdır.Atatürk; çağdaş,ilerici ve laik bir ulus devlet kurmak için siyasal, ekonomik ve kültürel alanlardasekülarist ve milliyetçi nitelikte yenilikler gerçekleştirdi. Yabancılara tanınan ekonomikayrıcalıklar kaldırıldı ve onlara ait üretim araçları ve demir yolları millîleştirildi.Tevhîd-i Tedrîsât Kanunu ile eğitim, Türk hükûmetinin denetimine girdi. Seküler ve bilimse eğitim esas alındı. Binlerce yeni okul yapıldı. İlköğretim ücretsiz ve zorunlu durumagetirildi. Yabancı okullar devlet denetimine alındı. Köylülerin sırtına yüklenen ağırvergiler azaltıldı. Erkeklerin serpuşlarında ve giysilerinde bazı değişiklikler yapıldı.Takvim, saat ve ölçülerde değişikliklere gidildi. Mecelle kaldırılarak yerine seküler TürkKanunu Medenisi yürürlüğe konuldu. Kadınların sivil ve siyasal hakları pek çok Batıülkesinden önce tanındı. Çok eşlilik yasaklandı. Kadınların tanıklığı ve miras hakkı,erkeklerinkiyle eşit duruma getirildi. Benzer olarak, dünyanın çoğu ülkesinden önce olarakTürkiye'de kadınlara ilkin yerel seçimlerde (1930), sonra genel seçimlerde (1934) seçme veseçilme hakkı tanındı. Ceza ve borçlar hukukunda seküler yasalar yürürlüğe konuldu. SanayiTeşvik Kanunu kabul edildi. Toprak reformu için çabalandı. Arap harfleri temelli Osmanlıalfabesinin yerine Latin harfleri temelli yeni Türk alfabesi kabul edildi. Halkı okuryazarkılmak için eğitim seferberliği başlatıldı. Üniversite Reformu gerçekleştirildi. BirinciBeş Yıllık Sanayi Planı yürürlüğe konuldu. Sınıf ve durum ayrımı gözeten lakap ve unvanlarkaldırıldı ve soyadları yürürlüğe konuldu. Bağdaşık ve birleşmiş bir ulus yaratılması içinTürkleştirme siyaseti yürütüldü.", 1881, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4573), "Mustafa Kemal", true, false, "Atatürk", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4574), "mustafa-kemal-ataturk.png", "mustafa-kemal-ataturk-12" },
                    { 13, "Yuval Noah Harari, İsrailli tarihçi ve yazardır. İsrailli bir kamu entelektüeli,tarihçi ve Kudüs İbrani Üniversitesi Tarih Bölümü'nde profesör. Popüler bilim en çok satankitapları Sapiens: İnsanlığın Kısa Tarihi, Homo Deus: Yarının Kısa Tarihi ve 21.Yüzyıl İçi 21 Ders kitabının yazarıdır.", 1976, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4575), "Yuval Noah", true, false, "Harari", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4575), "yoval-nuah-harari.jpg", "yoval-nuah-harari-13" },
                    { 14, "Rus yazar ve asker. Dünya tarihinin en iyi yazarlarından birisi olarakbilinmektedir. Tolstoy, zengin bir ailenin çocuğu olarak Rusya'nın Tula şehrindeki YasnayaPolyana adlı bir konakta doğdu. Çok küçük yaşlarında önce annesini, sonra babasınıkaybetti; yakınlarının elinde büyüdü. Çocukluğundan beri gerçekleri incelemeye karşı büyükbir ilgisi vardı. Fransızcasını ilerletmiş, Voltaire'i ve Jean-Jacques Rousseau'yu okumuş,bu iki yazarın kuvvetli etkisinde kalmıştı. Daha sonraları Yasnaya Polyana'ya dönenTolstoy, yoksul köylülerin arasına katıldı. İlk eseri olan 'Çocukluk'u bu sıralarda yazdı.", 1828, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4576), "Lev Nikolayeviç", true, false, "Tolstoy", new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(4577), "lev-nikolayevic-tolstoy.jpg", "lev-nikolayevic-tolstoy-14" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "InstructorId", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Time", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9350), "test.", "1.jpg", 1, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9354), ".NET (.NET Core, MVC, Web & Desktop)", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9360), "ogrenci-kiz-1" },
                    { 2, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9361), "testtt.", "2.jpg", 2, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9362), "Java (Spring, Java SE, Java EE),", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9364), "sicak-kafa-20" },
                    { 3, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9365), "test.", "3.jpg", 3, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9365), "Python", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9366), "ogrenci-kiz-1" },
                    { 4, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9367), "test.", "4.jpg", 4, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9368), "JavaScript", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9369), "ogrenci-kiz-1" },
                    { 5, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9370), "test.", "5.jpg", 5, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9370), ".NET (.NET Core, MVC, Web & Desktop)", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9371), "ogrenci-kiz-1" },
                    { 6, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9372), "testtt.", "6.jpg", 6, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9373), "Java (Spring, Java SE, Java EE),", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9374), "sicak-kafa-20" },
                    { 7, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9375), "test.", "7.jpg", 7, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9375), "Python", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9376), "ogrenci-kiz-1" },
                    { 8, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9377), "test.", "8.jpg", 8, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9378), "JavaScript", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9379), "ogrenci-kiz-1" },
                    { 9, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9380), "test.", "9.jpg", 9, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9380), "MVC (.NET & Java)", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9381), "ogrenci-kiz-1" },
                    { 10, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9382), "test.", "10.jpg", 10, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9382), "PHP", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9383), "ogrenci-kiz-1" },
                    { 11, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9384), "test.", "11.jpg", 11, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9384), "React", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9385), "ogrenci-kiz-1" },
                    { 12, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9386), "testtt.", "12.jpg", 12, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9386), "Node.js", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9387), "sicak-kafa-20" },
                    { 13, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9388), "test.", "13.jpg", 13, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9389), "Angular", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9390), "ogrenci-kiz-1" },
                    { 14, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9391), "test.", "14.jpg", 14, true, false, true, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9391), "Microsoft SQL Server", 100m, new DateTime(2023, 7, 11, 21, 25, 57, 963, DateTimeKind.Local).AddTicks(9392), "ogrenci-kiz-1" }
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
                    { 1, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InstructorId",
                table: "Products",
                column: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
