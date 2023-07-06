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
	public class ProductInstructorConfig : IEntityTypeConfiguration<ProductInstructor>
	{
		public void Configure(EntityTypeBuilder<ProductInstructor> builder)
		{
			builder.HasKey(bc => new { bc.ProductId, bc.InstructorId });
			builder.HasData(
				new ProductInstructor { ProductId = 1, InstructorId = 1 },
				new ProductInstructor { ProductId = 2, InstructorId = 2 });
		}
	}
}
