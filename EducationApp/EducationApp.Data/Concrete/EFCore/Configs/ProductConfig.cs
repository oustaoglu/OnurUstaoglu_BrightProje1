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
					Name = ".NET (.NET Core, MVC, Web & Desktop)",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "1.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 1
				},
				new Product
				{
					Id = 2,
					Name = "Java (Spring, Java SE, Java EE),",
					Description = "testtt.",
					Url = "sicak-kafa-20",
					ImageUrl = "2.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 2
				},
				new Product
				{
					Id = 3,
					Name = "Python",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "3.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 3
				},
				new Product
				{
					Id = 4,
					Name = "JavaScript",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "4.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 4
				},
				new Product
				{
					Id = 5,
					Name = ".NET (.NET Core, MVC, Web & Desktop)",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "5.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 5
				},
				new Product
				{
					Id = 6,
					Name = "Java (Spring, Java SE, Java EE),",
					Description = "testtt.",
					Url = "sicak-kafa-20",
					ImageUrl = "6.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 6
				},
				new Product
				{
					Id = 7,
					Name = "Python",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "7.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 7
				},
				new Product
				{
					Id = 8,
					Name = "JavaScript",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "8.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 8
				},
				new Product
				{
					Id = 9,
					Name = "MVC (.NET & Java)",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "9.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 9
				},
				new Product
				{
					Id = 10,
					Name = "PHP",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "10.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 10
				},
				new Product
				{
					Id = 11,
					Name = "React",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "11.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 11
				},
				new Product
				{
					Id = 12,
					Name = "Node.js",
					Description = "testtt.",
					Url = "sicak-kafa-20",
					ImageUrl = "12.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 12
				},
				new Product
				{
					Id = 13,
					Name = "Angular",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "13.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 13
				},
				new Product
				{
					Id = 14,
					Name = "Microsoft SQL Server",
					Description = "test.",
					Url = "ogrenci-kiz-1",
					ImageUrl = "14.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 14
				});
				
		}
	}
}
