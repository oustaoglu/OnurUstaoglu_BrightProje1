using EducationApp.Data.Abstract;
using EducationApp.Data.Concrete.EFCore.Contexts;
using EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Data.Concrete.EFCore.Repositories
{
	public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
	{
		EducationAppContext _context = new EducationAppContext();
		public async Task<List<Product>> GetAllActiveProductsAsync(string categoryUrl = null, string instructorUrl = null)
		{

			var result = _context
				.Products
				.Where(b => b.IsActive && !b.IsDeleted)
				.AsQueryable();
			if (categoryUrl != null)
			{
				result = result
					.Include(b => b.ProductCategories)
					.ThenInclude(bc => bc.Category)
					.Where(b => b.ProductCategories.Any(bc => bc.Category.Url == categoryUrl))
					.AsQueryable();
			}
			if (instructorUrl != null)
			{
				result = result
					.Include(b => b.Instructor)
					.Where(b => b.Instructor.Url == instructorUrl)
					.AsQueryable();
			}
			return await result.ToListAsync();
		}

		public async Task<Product> GetProductByUrlAsync(string bookUrl)
		{
			var result = await _context
				.Products
				.Where(b => b.IsActive && !b.IsDeleted && b.Url == bookUrl)
				.Include(b => b.ProductCategories)
				.ThenInclude(bc => bc.Category)
				.Include(b => b.Instructor)
				.FirstOrDefaultAsync();
			return result;
		}

		public async Task<List<Product>> GetHomePageProductsAsync()
		{
			var result = await _context
				.Products
				.Where(b => b.IsActive && !b.IsDeleted && b.IsHome)
				.Include(b => b.ProductCategories)
				.ThenInclude(bc => bc.Category)
				.Include(b => b.Instructor)
				.ToListAsync();
			return result;
		}
	}
}