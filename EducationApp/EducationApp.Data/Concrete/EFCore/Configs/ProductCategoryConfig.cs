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
	public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
	{
		public void Configure(EntityTypeBuilder<ProductCategory> builder)
		{
			builder.HasKey(bc => new { bc.ProductId, bc.CategoryId });
			builder.HasData(
				new ProductCategory { ProductId = 1, CategoryId = 1 },
				new ProductCategory { ProductId = 2, CategoryId = 1 },
				new ProductCategory { ProductId = 3, CategoryId = 1 },
				new ProductCategory { ProductId = 4, CategoryId = 1 },
				new ProductCategory { ProductId = 5, CategoryId = 1 },
				new ProductCategory { ProductId = 6, CategoryId = 1 },
				new ProductCategory { ProductId = 7, CategoryId = 2 },
				new ProductCategory { ProductId = 8, CategoryId = 2 },
				new ProductCategory { ProductId = 9, CategoryId = 2 },
				new ProductCategory { ProductId = 10, CategoryId = 2 },
				new ProductCategory { ProductId = 11, CategoryId = 3 },
				new ProductCategory { ProductId = 12, CategoryId = 3 },
				new ProductCategory { ProductId = 13, CategoryId = 3 },
				new ProductCategory { ProductId = 14, CategoryId = 3 });
		}
	}
}
