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
	public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
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

			builder.Property(x => x.Time).IsRequired();

			builder.Property(x => x.ImageUrl).IsRequired();

			builder.Property(x => x.Price).IsRequired();

			builder.Property(x => x.IsHome).IsRequired();

			builder.HasOne(x => x.Instructor).WithMany(x => x.Products).HasForeignKey(x => x.InstructorId).OnDelete(DeleteBehavior.NoAction);

			builder.HasData(
				new Product
				{
					Id = 1,
					Name = "Öğrenci Kız",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "ogrenci-kiz.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = false,
					InstructorId = 1
				},
				new Product
				{
					Id = 2,
					Name = "Sıcak Kafa",
					Description = "testtt.",
					Url = "sicak-kafa-20",
					ImageUrl = "sicak-kafa.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 2
				});
		}
	}
}
