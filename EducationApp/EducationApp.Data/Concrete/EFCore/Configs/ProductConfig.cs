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
					Name = ".NET (.NET Core, MVC, Web API)",
					Description = "test.",
					Url = ".net-core-mvc",
					ImageUrl = "1.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 1
				},
				new Product
				{
					Id = 2,
					Name = "Java (Spring, Java SE, Java EE)",
					Description = "testtt.",
					Url = "java",
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
					Url = "python",
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
					Url = "javascript",
					ImageUrl = "4.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 4
				},
				new Product
				{
					Id = 5,
					Name = "C/C++",
					Description = "test.",
					Url = "c/c++	",
					ImageUrl = "5.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 5
				},
				new Product
				{
					Id = 6,
					Name = "iOS & Android",
					Description = "testtt.",
					Url = "ios-android",
					ImageUrl = "6.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 6
				},
				new Product
				{
					Id = 7,
					Name = "React Native",
					Description = "test.",
					Url = "react-native",
					ImageUrl = "7.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 7
				},
				new Product
				{
					Id = 8,
					Name = "Flutter",
					Description = "test.",
					Url = "flutter",
					ImageUrl = "8.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 8
				},
				new Product
				{
					Id = 9,
					Name = "Ionic",
					Description = "test.",
					Url = "ionic",
					ImageUrl = "9.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 9
				},
				new Product
				{
					Id = 10,
					Name = "Unity",
					Description = "test.",
					Url = "unity",
					ImageUrl = "10.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 10
				},
				new Product
				{
					Id = 11,
					Name = "Unreal Engine",
					Description = "test.",
					Url = "unreal-engine",
					ImageUrl = "11.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 11
				},
				new Product
				{
					Id = 12,
					Name = "GameMaker Studio",
					Description = "testtt.",
					Url = "gamemaker-studio",
					ImageUrl = "12.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 12
				},
				new Product
				{
					Id = 13,
					Name = "Buildbox",
					Description = "test.",
					Url = "buildbox",
					ImageUrl = "13.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 13
				},
				new Product
				{
					Id = 14,
					Name = "PHP",
					Description = "test.",
					Url = "php",
					ImageUrl = "14.jpg",
					Price = 100,
					Time = DateTime.Now,
					IsHome = true,
					InstructorId = 14
				},
                new Product
                {
                    Id = 15,
                    Name = "React",
                    Description = "test.",
                    Url = "react",
                    ImageUrl = "8.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 8
                },
                new Product
                {
                    Id = 16,
                    Name = "Angular",
                    Description = "test.",
                    Url = "angular",
                    ImageUrl = "9.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 9
                },
                new Product
                {
                    Id = 17,
                    Name = "Node.js",
                    Description = "test.",
                    Url = "nodejs",
                    ImageUrl = "10.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 10
                },
                new Product
                {
                    Id = 18,
                    Name = "Microsoft SQL Server",
                    Description = "test.",
                    Url = "microsoft-sql-server",
                    ImageUrl = "11.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 11
                },
                new Product
                {
                    Id = 19,
                    Name = "MySQL",
                    Description = "testtt.",
                    Url = "mysql",
                    ImageUrl = "12.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 12
                },
                new Product
                {
                    Id = 20,
                    Name = "PostgreSQL",
                    Description = "test.",
                    Url = "postgresql",
                    ImageUrl = "13.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 13
                },
                new Product
                {
                    Id = 21,
                    Name = "SQLite",
                    Description = "test.",
                    Url = "sqlite",
                    ImageUrl = "11.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 11
                },
                new Product
                {
                    Id = 22,
                    Name = "Oracle",
                    Description = "testtt.",
                    Url = "oracle",
                    ImageUrl = "12.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 12
                },
                new Product
                {
                    Id = 23,
                    Name = "Docker",
                    Description = "test.",
                    Url = "docker",
                    ImageUrl = "13.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 13
                },
                new Product
                {
                    Id = 24,
                    Name = "Jenkins",
                    Description = "test.",
                    Url = "jenkins",
                    ImageUrl = "14.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 14
                },
                new Product
                {
                    Id = 25,
                    Name = "Ansible",
                    Description = "test.",
                    Url = "ansible",
                    ImageUrl = "8.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 8
                },
                new Product
                {
                    Id = 26,
                    Name = "Sonarcube",
                    Description = "test.",
                    Url = "sonarcube",
                    ImageUrl = "9.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 9
                },
                new Product
                {
                    Id = 27,
                    Name = "AWS",
                    Description = "test.",
                    Url = "aws",
                    ImageUrl = "10.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 10
                },
                new Product
                {
                    Id = 28,
                    Name = "Azure",
                    Description = "test.",
                    Url = "azure",
                    ImageUrl = "11.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 11
                },
                new Product
                {
                    Id = 29,
                    Name = "Serverless",
                    Description = "testtt.",
                    Url = "serverless",
                    ImageUrl = "12.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 12
                },
                new Product
                {
                    Id = 30,
                    Name = "Cloud Storage",
                    Description = "testtt.",
                    Url = "cloudstorage",
                    ImageUrl = "12.jpg",
                    Price = 100,
                    Time = DateTime.Now,
                    IsHome = true,
                    InstructorId = 12
                });
		}
	}
}
