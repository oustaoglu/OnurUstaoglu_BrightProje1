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
					Description = "sadafsffddsavb",
					Url = "yazilim-gelistirme"
				},
				new Category
				{
					Id = 2,
					Name = "Mobil",
					Description = "asdasfdsffsdf",
					Url = "mobil"
				},
				new Category
				{
					Id = 3,
					Name = "Web",
					Description = "asdasfdsffsdf",
					Url = "web"
				},
				new Category
				{
					Id = 4,
					Name = "Veri Tabanı",
					Description = "asdasfdsffsdf",
					Url = "veri-tabanı"
				},
				new Category
				{
					Id = 5,
					Name = "Veri ve Veri Bilimi",
					Description = "asdasfdsffsdf",
					Url = "veri-ve-veri-bilimi"
				},
				new Category
				{
					Id = 6,
					Name = "DevOps",
					Description = "asdasfdsffsdf",
					Url = "devops"
				},
				new Category
				{
					Id = 7,
					Name = "Bulut",
					Description = "asdasfdsffsdf",
					Url = "bulut"
				});
		}
	}
}
