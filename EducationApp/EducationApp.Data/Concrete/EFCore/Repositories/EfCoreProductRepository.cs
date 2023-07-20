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
				.Where(p => p.IsActive && !p.IsDeleted)
				.Include(p => p.Instructor)
				.AsQueryable();
			if (categoryUrl != null)
			{
				result = result
					.Include(p => p.ProductCategories)
					.ThenInclude(pc => pc.Category)
					.Where(p => p.ProductCategories.Any(pc => pc.Category.Url == categoryUrl))
					.AsQueryable();
			}
			if (instructorUrl != null)
			{
				result = result
					.Where(p => p.Instructor.Url == instructorUrl)
					.AsQueryable();
			}
			return await result.ToListAsync();
		}

		public async Task<Product> GetProductsByUrlAsync(string productUrl)
		{
			var result = await _context
				.Products
				.Where(p => p.IsActive && !p.IsDeleted && p.Url == productUrl)
				.Include(p => p.ProductCategories)
				.ThenInclude(pc => pc.Category)
				.Include(p => p.Instructor)
				.FirstOrDefaultAsync();
			return result;
		}

		public async Task<List<Product>> GetHomePageProductsAsync()
		{
			var result = await _context
				.Products
				.Where(p => p.IsActive && !p.IsDeleted && p.IsHome)
				.Include(p => p.ProductCategories)
				.ThenInclude(pc => pc.Category)
				.Include(p => p.Instructor)
				.ToListAsync();
			return result;
		}

        public async Task<List<Product>> GetProductsWithFullDataAsync(bool? isHome, bool? isActive)
        {
            var result = _context
				.Products
				.Where(b => !b.IsDeleted)
				.AsQueryable();

            if (isHome != null)
            {
                result = result
                    .Where(b => b.IsHome == isHome)
                    .AsQueryable();
            }

            if (isActive != null)
            {
                result = result
                    .Where(b => b.IsActive == isActive)
                    .AsQueryable();
            }
            result = result
                .Include(b => b.Instructor)
                .AsQueryable();

            return await result.ToListAsync();
        }
    }
}