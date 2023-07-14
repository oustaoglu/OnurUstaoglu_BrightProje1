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
                    { 1, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6734), "Yazılım geliştirme, bilgisayar programlarının tasarımı, oluşturulması ve sürdürülmesi sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, işlevsellik sağlamak ve teknolojik çözümler üretmek için kodlama, test etme ve dağıtma adımlarını içerir. Yazılım geliştirme, bilgisayar, mobil cihazlar, web uygulamaları, oyunlar ve daha fazlası gibi çeşitli alanlarda kullanılır. Bu süreçte programlama dilleri, veritabanları, algoritmalar ve yazılım tasarım prensipleri gibi araçlar kullanılır. Yazılım geliştirme, hızlı teknolojik ilerlemelerle birlikte sürekli evrilen ve iyileşen bir disiplindir ve kullanıcıların ihtiyaçlarını karşılamak için yenilikçi ve güvenilir çözümler sunmayı hedefler.", true, false, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6744), "Yazılım Geliştime", "yazilim-gelistirme" },
                    { 2, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6749), "Mobil uygulama geliştirme, mobil platformlarda çalışabilen kullanışlı ve etkileşimli yazılım uygulamalarının tasarımı, oluşturulması ve dağıtılması sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, sorunlara çözüm sunmak ve kullanıcı deneyimini geliştirmek için programlama, arayüz tasarımı, test etme ve dağıtma adımlarını içerir. Mobil uygulama geliştiricileri, Android veya iOS gibi belirli platformlar için uygun programlama dilleri ve geliştirme araçları kullanır. Bu süreç, hızlı teknolojik değişimlerle birlikte sürekli gelişir ve kullanıcıların günlük yaşamlarını kolaylaştıran, eğlence sunan ve işlevsellik sağlayan yenilikçi uygulamaların ortaya çıkmasını sağlar. Mobil uygulama geliştirme, geniş bir kullanıcı tabanına erişmek ve büyüyen mobil pazarlardan yararlanmak isteyen işletmeler ve geliştiriciler için önemli bir stratejidir.", true, false, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6749), "Mobil Uygulama Geliştirme", "mobil-uygulama-gelistirme" },
                    { 3, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6751), "Oyun geliştirme, video oyunlarının tasarımı, programlaması ve oluşturulması sürecidir. Bu süreç, oyun kavramının belirlenmesi, hikaye yazımı, karakter tasarımı, dünya oluşturma, grafik ve ses tasarımı, oyun mekaniği ve kullanıcı arayüzü gibi aşamaları içerir. Oyun geliştirme ekipleri, oyun programcıları, sanatçılar, tasarımcılar ve ses mühendisleri gibi farklı disiplinlerden profesyonelleri içerir. Geliştiriciler, oyun motorları, programlama dilleri, grafik araçları ve geliştirme ortamları kullanarak oyunun yapısını oluştururlar. Oyun geliştirme, eğlence endüstrisinde önemli bir rol oynar ve oyunculara heyecan verici deneyimler sunmak için sürekli yenilikçilik ve yaratıcılık gerektirir.", true, false, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6751), "Oyun Geliştime", "oyun-gelistirme" },
                    { 4, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6775), "Web, dünya genelinde bilgilere erişim sağlayan ve kullanıcıların çeşitli hizmetlere bağlanmasını mümkün kılan bir ağdır. Web, HTML, CSS ve JavaScript gibi teknolojilerle oluşturulan web siteleri ve web uygulamaları aracılığıyla çalışır. Web, kullanıcıların arama yapma, e-posta gönderme, sosyal ağlarda etkileşimde bulunma, alışveriş yapma ve daha birçok işlemi gerçekleştirebilecekleri bir platform sunar. Web geliştirme, web sitelerinin ve uygulamalarının tasarımını, kodlamasını, testini ve dağıtımını içerir. Bu süreçte kullanıcı deneyimi, güvenlik, performans ve uyumluluk önemlidir. Web, küresel bağlantıyı sağlayan ve bilgiye kolay erişimi temsil eden önemli bir iletişim ve etkileşim aracıdır.", true, false, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6777), "Web", "web" },
                    { 5, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6778), "Veritabanı, yapılandırılmış verilerin depolandığı ve yönetildiği bir elektronik sistemdir. Veritabanları, bilgiyi organize etmek, erişmek, güncellemek ve analiz etmek için kullanılır. İşletmeler, kuruluşlar ve web uygulamaları gibi birçok alan veritabanlarını kullanır. Veritabanı yönetim sistemleri (DBMS), veritabanının oluşturulması, yapılandırılması, sorgulanması ve güncellenmesi için gereken araçları sağlar. Veritabanı tasarımı, veri bütünlüğü, performans optimizasyonu ve güvenlik gibi konular önemlidir. Veritabanları, büyük veri kümelerini işlemek, veri analizi yapmak ve karar verme süreçlerini desteklemek için önemli bir rol oynar. Veritabanları, verilerin etkili bir şekilde yönetilmesini ve bilgi tabanlı çözümler sunulmasını sağlar.", true, false, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6779), "Veritabanı", "veritabani" },
                    { 6, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6780), "DevOps, yazılım geliştirme ve işletim süreçlerini birleştirerek, yazılım projelerinin daha hızlı, güvenilir ve sürekli bir şekilde dağıtılmasını sağlayan bir yaklaşımdır. Bu metodoloji, geliştirme (Development) ve işletim (Operations) ekipleri arasında işbirliği ve iletişimi teşvik eder. DevOps, otomasyon, sürekli entegrasyon ve sürekli dağıtım gibi pratikleri kullanarak, yazılımın yaşam döngüsünü hızlandırır ve kaliteyi artırır. Ayrıca, altyapı yönetimi, hata izleme ve performans analizi gibi operasyonel süreçlere odaklanır. DevOps, esneklik, hızlı yanıt verme ve müşteri memnuniyetini artırma gibi faydalar sağlayarak yazılım projelerinin başarısını destekler.", true, false, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6780), "DevOps", "devops" },
                    { 7, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6781), "Bulut, internet üzerinde sunulan paylaşımlı bilgi işlem kaynaklarını ifade eder. Bulut hizmetleri, sunucular, depolama, veritabanları, ağ altyapısı ve uygulama hizmetleri gibi kaynaklara erişimi kolaylaştırır. Kullanıcılar, istedikleri zaman istedikleri yerden bu kaynaklara güvenli bir şekilde erişebilir ve ihtiyaçlarına göre ölçeklendirebilir. Bulut hizmetleri, esneklik, ölçeklenebilirlik, veri yedekleme, sürekli çalışma ve maliyet verimliliği gibi avantajlar sağlar. Bulut, işletmeler için altyapı maliyetlerini azaltırken, geliştiriciler için hızlı bir şekilde uygulama dağıtma imkanı sunar. Ayrıca, kullanıcılara mobil cihazlar ve web tarayıcıları aracılığıyla geniş bir hizmet yelpazesine erişme kolaylığı sağlar.", true, false, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(6781), "Bulut", "bulut" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "About", "BirthOfYear", "CreatedDate", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, "İlber Ortaylı, Türk tarihçi, akademisyen ve yazar. Türk Tarih Kurumu Şeref Üyesidir. Ortaylı, Uluslararası Osmanlı Etütleri Komitesi yönetim kurulu üyesi ve Avrupa İranoloji Cemiyeti ve Avusturya-Türk Bilimler Forumu üyesidir.", 1950, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8656), "İlber", true, false, "Ortaylı", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8659), "ilber-ortayli.jpg", "ilber-ortayli-1" },
                    { 2, "Afşin Kum Kimdir? Afşin Kum, 1972 İzmir doğumlu. Boğaziçi Üniversitesinde bilgisayar mühendisliği, Bilgi Üniversitesinde sinema-televizyon öğrenimi gördü. 1997'den bu yana çeşitli kurumlarda yazılımcı ve yönetici olarak çalıştı.", 1960, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8661), "Afşin", true, false, "Kum", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8661), "afsin-kum.jpg", "afsin-kum-15" },
                    { 3, "Herbert George Wells ya da daha çok tanındığı adla H. G. Wells, Dünyaların Savaşı, GörünmezAdam,Dr Moreau'nun Adası ve Zaman Makinesi adlı bilimkurgu romanlarıyla tanınan ama neredeyseedebiyatınherdalında birçok eser vermiş olan İngiliz yazardır. Sosyalist olduğunu açıkça söyleyenH.G. Wells'inçoğueserinde önemli ölçüde siyasi ve sosyal yorumlar bulunmaktadır. Jules Verne gibigelecektekiteknolojikgelişmeleri anlattığı kitaplarıyla bilimkurgu dalının öncülerinden hattayaratıcılarındansayılmaktadır.", 1866, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8663), "Herbert George", true, false, "Wells", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8663), "herbert-george-wells.jpg", "herbert-george-wells-3" },
                    { 4, "Okula Essex'de gitti. Cambridge'de St. Johns College'e devam ederken Footlightstiyatro kulübünde görev aldı. Pek çok iş denedi. Hastanede hizmetlilik, inşaat işçiliği,kümes temizlikçiliği, bir Arap aile için korumalık yaptı. Daha sonra BBC'de Dr. Whodizisinde yapımcılık ve senaryo editörlüğü yaptı. Dr. Who'nun üç bölümünü yazdı. MontyPyton grubundan Graham Chapman ile birlikte çalıştı.\r\n\r\nBBC'de yayımlanan TheHitchhiker's Guide to the Galaxy (Otostopçunun Galaksi Rehberi) adlı radyo oyunu ile ünlüoldu. Oyun, kitap olarak da yayımlandı. Bu radyo oyunundan aynı adlı bir bilgisayar oyunuda üretti. Daha sonra Bureaucracy ve Starship Titanic adlı bilgisayar oyunları üzerinde deçalıştı. Starship Titanic sonradan bir kitap olarak da yayımlandı, ancak Adams'ın hem oyunhem de kitap üzerinde çalışacak zamanı olmadığından kitabı Terry Jones yazdı. İleriderecede bir Beatles hayranıydı.", 1982, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8664), "Douglas", true, false, "Adams", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8665), "douglas-adams.jpg", "douglas-adams-4" },
                    { 5, "Ray Douglas Bradbury korku ve bilimkurgu tarzlarında yazan Amerikalı bir yazardır.En çok bilinen kitapları 1950'de yazdığı kısa hikâyeler kitabı ve bir roman olan TheMartian Chronicles ve 1953'te yazdığı başyapıtı olan Fahrenheit 451'dir. Los Angeles'ta 91yaşında öldü.", 1920, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8666), "Ray Douglas", true, false, "Bradbury", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8666), "ray-douglas-bradbury.jpg", "ray-douglas-bradbury-5" },
                    { 6, "Japon yazardır. Tsugaru Yarımadası’nın merkezi yakınlarında küçük bir kasaba olanKanagi’de doğdu. Asıl adı Şuuci Tsuşima'dır. Ailedeki siyasetçi olma geleneğine karşıçıkarak, yazar olmaya karar verdi. Yirmi yaşında Tokyo Üniversitesi Fransız EdebiyatıBölümü’ne kaydını yaptırdı. Hayatının büyük bölümünde esrarkeş, veremli, asabi, kavgacı vealkolik biri olarak birkaç kez intihar etmeye kalkıştı. Dazai, 1948’de metresiyle birliktesuya atlayarak intihar etti. Ölümünün üzerinden bunca sene geçmesine rağmen, Japonya’dahâlâ ilgi gören bir yazardır. Eserlerinin çoğunluğunda yalnızlığı ele alır. Yalnızlık önplanda iken insanın arayış içinde olması ve insanın varoluşunu, içe dönüklüğünü yanitemelde insanı ele alır.", 1909, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8667), "Osamu", true, false, "Dazai", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8668), "osamu-dazai.jpg", "osamu-dazai-6" },
                    { 7, "Eric Arthur Blair veya daha bilinen takma adıyla George Orwell 20. yüzyıl İngilizedebiyatının önde gelen kalemleri arasında yer alan İngiliz romancı, gazeteci veeleştirmen. En çok, dünyaca ünlü Bin Dokuz Yüz Seksen Dört adlı romanı ve bu romandayarattığı Big Brother kavramı ile tanınır. ", 1903, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8669), "George", true, false, "Orwell", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8669), "george-orwell.png", "george-orwell-7" },
                    { 8, "Matt Haig bir İngiliz yazar ve gazetecidir. Çocuklar ve yetişkinler için, genellikl spekülatif kurgu türünde hem kurgu hem de kurgu olmayan kitaplar yazmıştır. Haig, çocukla ve yetişkinler için hem kurgu hem de kurgu olmayan kitapların yazarıdır. Kurgusal olmayançalışması Reasons to Stay Alive , Sunday Times'ın en çok satanlar listesinde bir numaraydıve 46 hafta boyunca Birleşik Krallık'ta ilk 10'da yer aldı. En çok satan çocuk romanı 'Noe Baba ve Ben' şu anda filme uyarlanıyor, yapımcılığını StudioCanal ve Blueprint Picturesüstleniyor.", 1982, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8670), "Matt", true, false, "Haig", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8670), "matt-haig.jpeg", "matt-haig-8" },
                    { 9, "Stephen William Hawking, İngiliz fizikçi, kozmolog, astronom, teorisyen ve yazar.Stephen Hawking, Einstein'dan bu yana dünyaya gelen en parlak teorik fizikçi olarak kabuledilmektedir. 12 onur derecesi almıştır. 1982'de CBE ile ödüllendirilmiş, bundan başkabirçok madalya ve ödül almıştır. ", 1942, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8671), "Stephen William", true, false, "ArmHawkingan", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8672), "stephen-william-hawking.jpg", "stephen-william-hawking-9" },
                    { 10, "Fyodor Mihayloviç Dostoyevski, Rus roman yazarıdır. Çocukluğunu sarhoş bir baba vehasta bir anne arasında geçiren Dostoyevski, annesinin ölümünden sonra Petersburg'dakiMühendis Okulu'na girdi. Babasının ölüm haberini de burada aldı. Okulu başarıylabitirdikten sonra istihkâm bölüğüne girdi.", 11821, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8673), "Fyodor", true, false, "Dostoyevski", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8673), "fyodor-dostoyevski.jpg", "fyodor-dostoyevski-10" },
                    { 11, "Manon Steffan Ros, Galli bir romancı, oyun yazarı, oyun yazarı, senarist vemüzisyendir. Tamamı Galce olan yirmiden fazla çocuk kitabı ve yetişkinler için üç romanınyazarıdır. Ödüllü romanı Blasu, The Seasoning başlığı altında İngilizce'ye çevrildi.", 1983, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8674), "Manon Steffan", true, false, "Ros", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8674), "manon-steffan-ros.jpg", "manon-steffan-ros-11" },
                    { 12, "Mustafa Kemal Atatürk, Türk asker ve devlet adamıdır. Türk Kurtuluş Savaşı'nınbaşkomutanı, Türkiye Cumhuriyeti'nin kurucusu ve ilk cumhurbaşkanıdır.Atatürk; çağdaş,ilerici ve laik bir ulus devlet kurmak için siyasal, ekonomik ve kültürel alanlardasekülarist ve milliyetçi nitelikte yenilikler gerçekleştirdi. Yabancılara tanınan ekonomikayrıcalıklar kaldırıldı ve onlara ait üretim araçları ve demir yolları millîleştirildi.Tevhîd-i Tedrîsât Kanunu ile eğitim, Türk hükûmetinin denetimine girdi. Seküler ve bilimse eğitim esas alındı. Binlerce yeni okul yapıldı. İlköğretim ücretsiz ve zorunlu durumagetirildi. Yabancı okullar devlet denetimine alındı. Köylülerin sırtına yüklenen ağırvergiler azaltıldı. Erkeklerin serpuşlarında ve giysilerinde bazı değişiklikler yapıldı.Takvim, saat ve ölçülerde değişikliklere gidildi. Mecelle kaldırılarak yerine seküler TürkKanunu Medenisi yürürlüğe konuldu. Kadınların sivil ve siyasal hakları pek çok Batıülkesinden önce tanındı. Çok eşlilik yasaklandı. Kadınların tanıklığı ve miras hakkı,erkeklerinkiyle eşit duruma getirildi. Benzer olarak, dünyanın çoğu ülkesinden önce olarakTürkiye'de kadınlara ilkin yerel seçimlerde (1930), sonra genel seçimlerde (1934) seçme veseçilme hakkı tanındı. Ceza ve borçlar hukukunda seküler yasalar yürürlüğe konuldu. SanayiTeşvik Kanunu kabul edildi. Toprak reformu için çabalandı. Arap harfleri temelli Osmanlıalfabesinin yerine Latin harfleri temelli yeni Türk alfabesi kabul edildi. Halkı okuryazarkılmak için eğitim seferberliği başlatıldı. Üniversite Reformu gerçekleştirildi. BirinciBeş Yıllık Sanayi Planı yürürlüğe konuldu. Sınıf ve durum ayrımı gözeten lakap ve unvanlarkaldırıldı ve soyadları yürürlüğe konuldu. Bağdaşık ve birleşmiş bir ulus yaratılması içinTürkleştirme siyaseti yürütüldü.", 1881, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8675), "Mustafa Kemal", true, false, "Atatürk", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8676), "mustafa-kemal-ataturk.png", "mustafa-kemal-ataturk-12" },
                    { 13, "Yuval Noah Harari, İsrailli tarihçi ve yazardır. İsrailli bir kamu entelektüeli,tarihçi ve Kudüs İbrani Üniversitesi Tarih Bölümü'nde profesör. Popüler bilim en çok satankitapları Sapiens: İnsanlığın Kısa Tarihi, Homo Deus: Yarının Kısa Tarihi ve 21.Yüzyıl İçi 21 Ders kitabının yazarıdır.", 1976, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8677), "Yuval Noah", true, false, "Harari", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8677), "yoval-nuah-harari.jpg", "yoval-nuah-harari-13" },
                    { 14, "Rus yazar ve asker. Dünya tarihinin en iyi yazarlarından birisi olarakbilinmektedir. Tolstoy, zengin bir ailenin çocuğu olarak Rusya'nın Tula şehrindeki YasnayaPolyana adlı bir konakta doğdu. Çok küçük yaşlarında önce annesini, sonra babasınıkaybetti; yakınlarının elinde büyüdü. Çocukluğundan beri gerçekleri incelemeye karşı büyükbir ilgisi vardı. Fransızcasını ilerletmiş, Voltaire'i ve Jean-Jacques Rousseau'yu okumuş,bu iki yazarın kuvvetli etkisinde kalmıştı. Daha sonraları Yasnaya Polyana'ya dönenTolstoy, yoksul köylülerin arasına katıldı. İlk eseri olan 'Çocukluk'u bu sıralarda yazdı.", 1828, new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8678), "Lev Nikolayeviç", true, false, "Tolstoy", new DateTime(2023, 7, 14, 14, 0, 3, 371, DateTimeKind.Local).AddTicks(8678), "lev-nikolayevic-tolstoy.jpg", "lev-nikolayevic-tolstoy-14" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "InstructorId", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Time", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3511), "test.", "1.jpg", 1, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3513), ".NET (.NET Core, MVC, Web & Desktop)", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3518), ".net-core-mvc" },
                    { 2, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3519), "testtt.", "2.jpg", 2, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3520), "Java (Spring, Java SE, Java EE)", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3521), "java" },
                    { 3, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3522), "test.", "3.jpg", 3, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3522), "Python", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3523), "python" },
                    { 4, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3524), "test.", "4.jpg", 4, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3524), "JavaScript", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3525), "javascript" },
                    { 5, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3526), "test.", "5.jpg", 5, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3526), "C/C++", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3527), "c/c++	" },
                    { 6, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3528), "testtt.", "6.jpg", 6, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3528), "iOS & Android", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3529), "ios-android" },
                    { 7, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3530), "test.", "7.jpg", 7, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3530), "React Native", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3531), "react-native" },
                    { 8, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3532), "test.", "8.jpg", 8, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3532), "Flutter", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3533), "flutter" },
                    { 9, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3533), "test.", "9.jpg", 9, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3534), "Ionic", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3535), "ionic" },
                    { 10, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3535), "test.", "10.jpg", 10, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3536), "Unity", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3537), "unity" },
                    { 11, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3537), "test.", "11.jpg", 11, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3538), "Unreal Engine", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3538), "unreal-engine" },
                    { 12, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3539), "testtt.", "12.jpg", 12, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3539), "GameMaker Studio", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3540), "gamemaker-studio" },
                    { 13, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3541), "test.", "13.jpg", 13, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3541), "Buildbox", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3542), "buildbox" },
                    { 14, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3543), "test.", "14.jpg", 14, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3543), "PHP", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3544), "php" },
                    { 15, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3545), "test.", "8.jpg", 8, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3545), "React", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3546), "react" },
                    { 16, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3547), "test.", "9.jpg", 9, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3547), "Angular", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3548), "angular" },
                    { 17, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3548), "test.", "10.jpg", 10, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3549), "Node.js", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3550), "nodejs" },
                    { 18, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3550), "test.", "11.jpg", 11, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3551), "Microsoft SQL Server", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3551), "microsoft-sql-server" },
                    { 19, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3552), "testtt.", "12.jpg", 12, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3552), "MySQL", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3553), "mysql" },
                    { 20, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3554), "test.", "13.jpg", 13, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3554), "PostgreSQL", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3555), "postgresql" },
                    { 21, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3556), "test.", "11.jpg", 11, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3556), "SQLite", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3557), "sqlite" },
                    { 22, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3558), "testtt.", "12.jpg", 12, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3558), "Oracle", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3559), "oracle" },
                    { 23, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3559), "test.", "13.jpg", 13, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3560), "Docker", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3561), "docker" },
                    { 24, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3561), "test.", "14.jpg", 14, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3562), "Jenkins", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3563), "jenkins" },
                    { 25, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3564), "test.", "8.jpg", 8, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3564), "Ansible", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3565), "ansible" },
                    { 26, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3566), "test.", "9.jpg", 9, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3566), "Sonarcube", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3567), "sonarcube" },
                    { 27, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3568), "test.", "10.jpg", 10, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3568), "AWS", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3569), "aws" },
                    { 28, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3569), "test.", "11.jpg", 11, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3570), "Azure", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3571), "azure" },
                    { 29, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3571), "testtt.", "12.jpg", 12, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3572), "Serverless", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3573), "serverless" },
                    { 30, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3573), "testtt.", "12.jpg", 12, true, false, true, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3573), "Cloud Storage", 100m, new DateTime(2023, 7, 14, 14, 0, 3, 372, DateTimeKind.Local).AddTicks(3574), "cloudstorage" }
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
