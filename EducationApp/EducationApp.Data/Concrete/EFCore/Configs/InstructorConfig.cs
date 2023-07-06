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
				});
		}
	}
}
