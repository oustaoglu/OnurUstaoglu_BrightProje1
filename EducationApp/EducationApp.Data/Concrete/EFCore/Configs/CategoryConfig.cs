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
	public class CategoryConfig : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();

			builder.Property(x => x.CreatedDate).IsRequired();

			builder.Property(x => x.ModifiedDate).IsRequired();

			builder.Property(x => x.IsActive).IsRequired();

			builder.Property(x => x.IsDeleted).IsRequired();

			builder.Property(x => x.Url).IsRequired();

			builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

			builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);

			builder.HasData(
				new Category
				{
					Id = 1,
					Name = "Yazılım Geliştime",
					Description = "Yazılım geliştirme, bilgisayar programlarının tasarımı, oluşturulması ve sürdürülmesi sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, işlevsellik sağlamak ve teknolojik çözümler üretmek için kodlama, test etme ve dağıtma adımlarını içerir. Yazılım geliştirme, bilgisayar, mobil cihazlar, web uygulamaları, oyunlar ve daha fazlası gibi çeşitli alanlarda kullanılır. Bu süreçte programlama dilleri, veritabanları, algoritmalar ve yazılım tasarım prensipleri gibi araçlar kullanılır. Yazılım geliştirme, hızlı teknolojik ilerlemelerle birlikte sürekli evrilen ve iyileşen bir disiplindir ve kullanıcıların ihtiyaçlarını karşılamak için yenilikçi ve güvenilir çözümler sunmayı hedefler.",
					Url = "yazilim-gelistirme"
				},
				new Category
				{
					Id = 2,
					Name = "Mobil Uygulama Geliştirme",
					Description = "Mobil uygulama geliştirme, mobil platformlarda çalışabilen kullanışlı ve etkileşimli yazılım uygulamalarının tasarımı, oluşturulması ve dağıtılması sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, sorunlara çözüm sunmak ve kullanıcı deneyimini geliştirmek için programlama, arayüz tasarımı, test etme ve dağıtma adımlarını içerir. Mobil uygulama geliştiricileri, Android veya iOS gibi belirli platformlar için uygun programlama dilleri ve geliştirme araçları kullanır. Bu süreç, hızlı teknolojik değişimlerle birlikte sürekli gelişir ve kullanıcıların günlük yaşamlarını kolaylaştıran, eğlence sunan ve işlevsellik sağlayan yenilikçi uygulamaların ortaya çıkmasını sağlar. Mobil uygulama geliştirme, geniş bir kullanıcı tabanına erişmek ve büyüyen mobil pazarlardan yararlanmak isteyen işletmeler ve geliştiriciler için önemli bir stratejidir.",
					Url = "mobil-uygulama-gelistirme"
				},
				new Category
				{
                    Id = 3,
                    Name = "Oyun Geliştime",
                    Description = "Oyun geliştirme, video oyunlarının tasarımı, programlaması ve oluşturulması sürecidir. Bu süreç, oyun kavramının belirlenmesi, hikaye yazımı, karakter tasarımı, dünya oluşturma, grafik ve ses tasarımı, oyun mekaniği ve kullanıcı arayüzü gibi aşamaları içerir. Oyun geliştirme ekipleri, oyun programcıları, sanatçılar, tasarımcılar ve ses mühendisleri gibi farklı disiplinlerden profesyonelleri içerir. Geliştiriciler, oyun motorları, programlama dilleri, grafik araçları ve geliştirme ortamları kullanarak oyunun yapısını oluştururlar. Oyun geliştirme, eğlence endüstrisinde önemli bir rol oynar ve oyunculara heyecan verici deneyimler sunmak için sürekli yenilikçilik ve yaratıcılık gerektirir.",
                    Url = "oyun-gelistirme"
                },
				new Category
				{
					Id = 4,
					Name = "Web",
					Description = "Web, dünya genelinde bilgilere erişim sağlayan ve kullanıcıların çeşitli hizmetlere bağlanmasını mümkün kılan bir ağdır. Web, HTML, CSS ve JavaScript gibi teknolojilerle oluşturulan web siteleri ve web uygulamaları aracılığıyla çalışır. Web, kullanıcıların arama yapma, e-posta gönderme, sosyal ağlarda etkileşimde bulunma, alışveriş yapma ve daha birçok işlemi gerçekleştirebilecekleri bir platform sunar. Web geliştirme, web sitelerinin ve uygulamalarının tasarımını, kodlamasını, testini ve dağıtımını içerir. Bu süreçte kullanıcı deneyimi, güvenlik, performans ve uyumluluk önemlidir. Web, küresel bağlantıyı sağlayan ve bilgiye kolay erişimi temsil eden önemli bir iletişim ve etkileşim aracıdır.",
					Url = "web"
				},
				new Category
				{
					Id = 5,
					Name = "Veritabanı",
					Description = "Veritabanı, yapılandırılmış verilerin depolandığı ve yönetildiği bir elektronik sistemdir. Veritabanları, bilgiyi organize etmek, erişmek, güncellemek ve analiz etmek için kullanılır. İşletmeler, kuruluşlar ve web uygulamaları gibi birçok alan veritabanlarını kullanır. Veritabanı yönetim sistemleri (DBMS), veritabanının oluşturulması, yapılandırılması, sorgulanması ve güncellenmesi için gereken araçları sağlar. Veritabanı tasarımı, veri bütünlüğü, performans optimizasyonu ve güvenlik gibi konular önemlidir. Veritabanları, büyük veri kümelerini işlemek, veri analizi yapmak ve karar verme süreçlerini desteklemek için önemli bir rol oynar. Veritabanları, verilerin etkili bir şekilde yönetilmesini ve bilgi tabanlı çözümler sunulmasını sağlar.",
					Url = "veritabani"
				},
				new Category
				{
					Id = 6,
					Name = "DevOps",
					Description = "DevOps, yazılım geliştirme ve işletim süreçlerini birleştirerek, yazılım projelerinin daha hızlı, güvenilir ve sürekli bir şekilde dağıtılmasını sağlayan bir yaklaşımdır. Bu metodoloji, geliştirme (Development) ve işletim (Operations) ekipleri arasında işbirliği ve iletişimi teşvik eder. DevOps, otomasyon, sürekli entegrasyon ve sürekli dağıtım gibi pratikleri kullanarak, yazılımın yaşam döngüsünü hızlandırır ve kaliteyi artırır. Ayrıca, altyapı yönetimi, hata izleme ve performans analizi gibi operasyonel süreçlere odaklanır. DevOps, esneklik, hızlı yanıt verme ve müşteri memnuniyetini artırma gibi faydalar sağlayarak yazılım projelerinin başarısını destekler.",
					Url = "devops"
				},
				new Category
				{
					Id = 7,
					Name = "Bulut",
					Description = "Bulut, internet üzerinde sunulan paylaşımlı bilgi işlem kaynaklarını ifade eder. Bulut hizmetleri, sunucular, depolama, veritabanları, ağ altyapısı ve uygulama hizmetleri gibi kaynaklara erişimi kolaylaştırır. Kullanıcılar, istedikleri zaman istedikleri yerden bu kaynaklara güvenli bir şekilde erişebilir ve ihtiyaçlarına göre ölçeklendirebilir. Bulut hizmetleri, esneklik, ölçeklenebilirlik, veri yedekleme, sürekli çalışma ve maliyet verimliliği gibi avantajlar sağlar. Bulut, işletmeler için altyapı maliyetlerini azaltırken, geliştiriciler için hızlı bir şekilde uygulama dağıtma imkanı sunar. Ayrıca, kullanıcılara mobil cihazlar ve web tarayıcıları aracılığıyla geniş bir hizmet yelpazesine erişme kolaylığı sağlar.",
					Url = "bulut"
				});
		}
	}
}
