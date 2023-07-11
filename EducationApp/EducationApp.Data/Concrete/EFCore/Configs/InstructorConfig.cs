using EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Data.Concrete.EFCore.Configs
{
	public class InstructorConfig : IEntityTypeConfiguration<Instructor>
	{
		public void Configure(EntityTypeBuilder<Instructor> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();

			builder.Property(x => x.CreatedDate).IsRequired();

			builder.Property(x => x.ModifiedDate).IsRequired();

			builder.Property(x => x.IsActive).IsRequired();

			builder.Property(x => x.IsDeleted).IsRequired();

			builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);

			builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);

			builder.Property(x => x.BirthOfYear).IsRequired();

			builder.Property(x => x.About).IsRequired().HasMaxLength(1000);

			builder.Property(x => x.Url).IsRequired();

			builder.Property(x => x.PhotoUrl).IsRequired();

			builder.HasData(
				new Instructor
				{
					Id = 1,
					FirstName = "İlber",
					LastName = "Ortaylı",
					BirthOfYear = 1950,
					PhotoUrl = "ilber-ortayli.jpg",
					Url = "ilber-ortayli-1",
					About = "İlber Ortaylı, Türk tarihçi, akademisyen ve yazar. Türk Tarih Kurumu Şeref Üyesidir. Ortaylı, Uluslararası Osmanlı Etütleri Komitesi yönetim kurulu üyesi ve Avrupa İranoloji Cemiyeti ve Avusturya-Türk Bilimler Forumu üyesidir."
				},
				new Instructor
				{
					Id = 2,
					FirstName = "Afşin",
					LastName = "Kum",
					BirthOfYear = 1960,
					PhotoUrl = "afsin-kum.jpg",
					Url = "afsin-kum-15",
					About = "Afşin Kum Kimdir? Afşin Kum, 1972 İzmir doğumlu. Boğaziçi Üniversitesinde bilgisayar mühendisliği, Bilgi Üniversitesinde sinema-televizyon öğrenimi gördü. 1997'den bu yana çeşitli kurumlarda yazılımcı ve yönetici olarak çalıştı."
				},
				 new Instructor
				 {
					  Id = 3,
					  FirstName = "Herbert George",
					  LastName = "Wells",
					  BirthOfYear = 1866,
					  PhotoUrl = "herbert-george-wells.jpg",
					  Url = "herbert-george-wells-3",
					  About = "Herbert George Wells ya da daha çok tanındığı adla H. G. Wells, Dünyaların Savaşı, GörünmezAdam,Dr Moreau'nun Adası ve Zaman Makinesi adlı bilimkurgu romanlarıyla tanınan ama neredeyseedebiyatınherdalında birçok eser vermiş olan İngiliz yazardır. Sosyalist olduğunu açıkça söyleyenH.G. Wells'inçoğueserinde önemli ölçüde siyasi ve sosyal yorumlar bulunmaktadır. Jules Verne gibigelecektekiteknolojikgelişmeleri anlattığı kitaplarıyla bilimkurgu dalının öncülerinden hattayaratıcılarındansayılmaktadır."
				 },
				new Instructor
				{
					Id = 4,
					FirstName = "Douglas",
					LastName = "Adams",
					BirthOfYear = 1982,
					PhotoUrl = "douglas-adams.jpg",
					Url = "douglas-adams-4",
					About = "Okula Essex'de gitti. Cambridge'de St. Johns College'e devam ederken Footlightstiyatro kulübünde görev aldı. Pek çok iş denedi. Hastanede hizmetlilik, inşaat işçiliği,kümes temizlikçiliği, bir Arap aile için korumalık yaptı. Daha sonra BBC'de Dr. Whodizisinde yapımcılık ve senaryo editörlüğü yaptı. Dr. Who'nun üç bölümünü yazdı. MontyPyton grubundan Graham Chapman ile birlikte çalıştı.\r\n\r\nBBC'de yayımlanan TheHitchhiker's Guide to the Galaxy (Otostopçunun Galaksi Rehberi) adlı radyo oyunu ile ünlüoldu. Oyun, kitap olarak da yayımlandı. Bu radyo oyunundan aynı adlı bir bilgisayar oyunuda üretti. Daha sonra Bureaucracy ve Starship Titanic adlı bilgisayar oyunları üzerinde deçalıştı. Starship Titanic sonradan bir kitap olarak da yayımlandı, ancak Adams'ın hem oyunhem de kitap üzerinde çalışacak zamanı olmadığından kitabı Terry Jones yazdı. İleriderecede bir Beatles hayranıydı."
				},
				new Instructor
				{
					Id = 5,
					FirstName = "Ray Douglas",
					LastName = "Bradbury",
					BirthOfYear = 1920,
					PhotoUrl = "ray-douglas-bradbury.jpg",
					Url = "ray-douglas-bradbury-5",
					About = "Ray Douglas Bradbury korku ve bilimkurgu tarzlarında yazan Amerikalı bir yazardır.En çok bilinen kitapları 1950'de yazdığı kısa hikâyeler kitabı ve bir roman olan TheMartian Chronicles ve 1953'te yazdığı başyapıtı olan Fahrenheit 451'dir. Los Angeles'ta 91yaşında öldü."
				},
				new Instructor
				{
					Id = 6,
					FirstName = "Osamu",
					LastName = "Dazai",
					BirthOfYear = 1909,
					PhotoUrl = "osamu-dazai.jpg",
					Url = "osamu-dazai-6",
					About = "Japon yazardır. Tsugaru Yarımadası’nın merkezi yakınlarında küçük bir kasaba olanKanagi’de doğdu. Asıl adı Şuuci Tsuşima'dır. Ailedeki siyasetçi olma geleneğine karşıçıkarak, yazar olmaya karar verdi. Yirmi yaşında Tokyo Üniversitesi Fransız EdebiyatıBölümü’ne kaydını yaptırdı. Hayatının büyük bölümünde esrarkeş, veremli, asabi, kavgacı vealkolik biri olarak birkaç kez intihar etmeye kalkıştı. Dazai, 1948’de metresiyle birliktesuya atlayarak intihar etti. Ölümünün üzerinden bunca sene geçmesine rağmen, Japonya’dahâlâ ilgi gören bir yazardır. Eserlerinin çoğunluğunda yalnızlığı ele alır. Yalnızlık önplanda iken insanın arayış içinde olması ve insanın varoluşunu, içe dönüklüğünü yanitemelde insanı ele alır."
				},
				new Instructor
				{
					Id = 7,
					FirstName = "George",
					LastName = "Orwell",
					BirthOfYear = 1903,
					PhotoUrl = "george-orwell.png",
					Url = "george-orwell-7",
					About = "Eric Arthur Blair veya daha bilinen takma adıyla George Orwell 20. yüzyıl İngilizedebiyatının önde gelen kalemleri arasında yer alan İngiliz romancı, gazeteci veeleştirmen. En çok, dünyaca ünlü Bin Dokuz Yüz Seksen Dört adlı romanı ve bu romandayarattığı Big Brother kavramı ile tanınır. "
				},
				new Instructor
				{
					Id = 8,
					FirstName = "Matt",
					LastName = "Haig",
					BirthOfYear = 1982,
					PhotoUrl = "matt-haig.jpeg",
					Url = "matt-haig-8",
					About = "Matt Haig bir İngiliz yazar ve gazetecidir. Çocuklar ve yetişkinler için, genellikl spekülatif kurgu türünde hem kurgu hem de kurgu olmayan kitaplar yazmıştır. Haig, çocukla ve yetişkinler için hem kurgu hem de kurgu olmayan kitapların yazarıdır. Kurgusal olmayançalışması Reasons to Stay Alive , Sunday Times'ın en çok satanlar listesinde bir numaraydıve 46 hafta boyunca Birleşik Krallık'ta ilk 10'da yer aldı. En çok satan çocuk romanı 'Noe Baba ve Ben' şu anda filme uyarlanıyor, yapımcılığını StudioCanal ve Blueprint Picturesüstleniyor."
				},
				new Instructor
				{
					Id = 9,
					FirstName = "Stephen William",
					LastName = "ArmHawkingan",
					BirthOfYear = 1942,
					PhotoUrl = "stephen-william-hawking.jpg",
					Url = "stephen-william-hawking-9",
					About = "Stephen William Hawking, İngiliz fizikçi, kozmolog, astronom, teorisyen ve yazar.Stephen Hawking, Einstein'dan bu yana dünyaya gelen en parlak teorik fizikçi olarak kabuledilmektedir. 12 onur derecesi almıştır. 1982'de CBE ile ödüllendirilmiş, bundan başkabirçok madalya ve ödül almıştır. "
				},
				new Instructor
				{
					Id = 10,
					FirstName = "Fyodor",
					LastName = "Dostoyevski",
					BirthOfYear = 11821,
					PhotoUrl = "fyodor-dostoyevski.jpg",
					Url = "fyodor-dostoyevski-10",
					About = "Fyodor Mihayloviç Dostoyevski, Rus roman yazarıdır. Çocukluğunu sarhoş bir baba vehasta bir anne arasında geçiren Dostoyevski, annesinin ölümünden sonra Petersburg'dakiMühendis Okulu'na girdi. Babasının ölüm haberini de burada aldı. Okulu başarıylabitirdikten sonra istihkâm bölüğüne girdi."
				},
				new Instructor
				{
					Id = 11,
					FirstName = "Manon Steffan",
					LastName = "Ros",
					BirthOfYear = 1983,
					PhotoUrl = "manon-steffan-ros.jpg",
					Url = "manon-steffan-ros-11",
					About = "Manon Steffan Ros, Galli bir romancı, oyun yazarı, oyun yazarı, senarist vemüzisyendir. Tamamı Galce olan yirmiden fazla çocuk kitabı ve yetişkinler için üç romanınyazarıdır. Ödüllü romanı Blasu, The Seasoning başlığı altında İngilizce'ye çevrildi."
				},
				new Instructor
				{
					Id = 12,
					FirstName = "Mustafa Kemal",
					LastName = "Atatürk",
					BirthOfYear = 1881,
					PhotoUrl = "mustafa-kemal-ataturk.png",
					Url = "mustafa-kemal-ataturk-12",
					About = "Mustafa Kemal Atatürk, Türk asker ve devlet adamıdır. Türk Kurtuluş Savaşı'nınbaşkomutanı, Türkiye Cumhuriyeti'nin kurucusu ve ilk cumhurbaşkanıdır.Atatürk; çağdaş,ilerici ve laik bir ulus devlet kurmak için siyasal, ekonomik ve kültürel alanlardasekülarist ve milliyetçi nitelikte yenilikler gerçekleştirdi. Yabancılara tanınan ekonomikayrıcalıklar kaldırıldı ve onlara ait üretim araçları ve demir yolları millîleştirildi.Tevhîd-i Tedrîsât Kanunu ile eğitim, Türk hükûmetinin denetimine girdi. Seküler ve bilimse eğitim esas alındı. Binlerce yeni okul yapıldı. İlköğretim ücretsiz ve zorunlu durumagetirildi. Yabancı okullar devlet denetimine alındı. Köylülerin sırtına yüklenen ağırvergiler azaltıldı. Erkeklerin serpuşlarında ve giysilerinde bazı değişiklikler yapıldı.Takvim, saat ve ölçülerde değişikliklere gidildi. Mecelle kaldırılarak yerine seküler TürkKanunu Medenisi yürürlüğe konuldu. Kadınların sivil ve siyasal hakları pek çok Batıülkesinden önce tanındı. Çok eşlilik yasaklandı. Kadınların tanıklığı ve miras hakkı,erkeklerinkiyle eşit duruma getirildi. Benzer olarak, dünyanın çoğu ülkesinden önce olarakTürkiye'de kadınlara ilkin yerel seçimlerde (1930), sonra genel seçimlerde (1934) seçme veseçilme hakkı tanındı. Ceza ve borçlar hukukunda seküler yasalar yürürlüğe konuldu. SanayiTeşvik Kanunu kabul edildi. Toprak reformu için çabalandı. Arap harfleri temelli Osmanlıalfabesinin yerine Latin harfleri temelli yeni Türk alfabesi kabul edildi. Halkı okuryazarkılmak için eğitim seferberliği başlatıldı. Üniversite Reformu gerçekleştirildi. BirinciBeş Yıllık Sanayi Planı yürürlüğe konuldu. Sınıf ve durum ayrımı gözeten lakap ve unvanlarkaldırıldı ve soyadları yürürlüğe konuldu. Bağdaşık ve birleşmiş bir ulus yaratılması içinTürkleştirme siyaseti yürütüldü."
				},
				new Instructor
				{
					Id = 13,
					FirstName = "Yuval Noah",
					LastName = "Harari",
					BirthOfYear = 1976,
					PhotoUrl = "yoval-nuah-harari.jpg",
					Url = "yoval-nuah-harari-13",
					About = "Yuval Noah Harari, İsrailli tarihçi ve yazardır. İsrailli bir kamu entelektüeli,tarihçi ve Kudüs İbrani Üniversitesi Tarih Bölümü'nde profesör. Popüler bilim en çok satankitapları Sapiens: İnsanlığın Kısa Tarihi, Homo Deus: Yarının Kısa Tarihi ve 21.Yüzyıl İçi 21 Ders kitabının yazarıdır."
				},
				new Instructor
				{
					Id = 14,
					FirstName = "Lev Nikolayeviç",
					LastName = "Tolstoy",
					BirthOfYear = 1828,
					PhotoUrl = "lev-nikolayevic-tolstoy.jpg",
					Url = "lev-nikolayevic-tolstoy-14",
					About = "Rus yazar ve asker. Dünya tarihinin en iyi yazarlarından birisi olarakbilinmektedir. Tolstoy, zengin bir ailenin çocuğu olarak Rusya'nın Tula şehrindeki YasnayaPolyana adlı bir konakta doğdu. Çok küçük yaşlarında önce annesini, sonra babasınıkaybetti; yakınlarının elinde büyüdü. Çocukluğundan beri gerçekleri incelemeye karşı büyükbir ilgisi vardı. Fransızcasını ilerletmiş, Voltaire'i ve Jean-Jacques Rousseau'yu okumuş,bu iki yazarın kuvvetli etkisinde kalmıştı. Daha sonraları Yasnaya Polyana'ya dönenTolstoy, yoksul köylülerin arasına katıldı. İlk eseri olan 'Çocukluk'u bu sıralarda yazdı."
				});
		}
	}
}
