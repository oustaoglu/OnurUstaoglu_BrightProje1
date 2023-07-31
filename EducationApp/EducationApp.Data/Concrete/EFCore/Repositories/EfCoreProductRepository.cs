using EducationApp.Core;
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
		public EfCoreProductRepository(EducationAppContext _context) : base(_context)
		{

		}

		private EducationAppContext Context
		{
			get { return _dbContext as EducationAppContext; }
		}

		public async Task CheckProductsCategories()
		{
			var productCategoryIds = await Context
				.ProductCategories
				.Select(pc => pc.ProductId)
				.Distinct()
				.ToListAsync();
			var productIds = await Context
				.Products
				.Select(p => p.Id)
				.ToListAsync();
			List<int> different = productIds.Except(productCategoryIds).ToList();
			await Context.ProductCategories.AddRangeAsync(different.Select(d => new ProductCategory
			{
				ProductId = d,
				CategoryId = 1
			}).ToList());
			await Context.SaveChangesAsync();
		}

		public async Task CreateProductAsync(Product product, List<int> SelectedCategoryIds)
		{
			await Context.Products.AddAsync(product);
			await Context.SaveChangesAsync();
			product.ProductCategories = SelectedCategoryIds.Select(sc => new ProductCategory
			{
				ProductId = product.Id,
				CategoryId = sc
			}).ToList();
			Context.Products.Update(product);
			await Context.SaveChangesAsync();
		}

		public async Task<List<Product>> GetAllActiveProductsAsync(string categoryUrl = null, string instructorUrl = null)
		{
			var result = Context
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

		public async Task<List<Product>> GetAllProductsWithInstructor(bool isDeleted)
		{
			var result = await Context
				.Products
				.Where(p => p.IsDeleted == isDeleted)
				.Include(p => p.Instructor)
				.ToListAsync();
			return result;
		}

		public async Task<Product> GetProductByIdAsync(int id)
		{
			var result = await Context
				.Products
				.Where(p => p.IsActive && !p.IsDeleted && p.Id == id)
				.Include(p => p.ProductCategories)
				.ThenInclude(bc => bc.Category)
				.Include(p => p.Instructor)
				.FirstOrDefaultAsync();	
			return result;
		}

		public async Task<Product> GetProductByUrlAsync(string productUrl)
		{
			var result = await Context
				.Products
				.Where(p => p.IsActive && !p.IsDeleted && p.Url == productUrl)
				.Include(p => p.ProductCategories)
				.ThenInclude(pc => pc.Category)
				.Include(p =>p.Instructor)
				.FirstOrDefaultAsync();
			return result;
		}

		public async Task<List<Product>> GetProductsWithFullDataAsync(bool? isHome = null, bool? isActive = null)
		{
			var result = Context
				.Products
				.Where(p => !p.IsDeleted)
				.AsQueryable();

			if (isHome != null)
			{
				result = result
					.Where(p => p.IsHome == isHome)
					.AsQueryable();
			}

			if (isActive != null)
			{
				result = result
					.Where(p => p.IsActive == isActive)
					.AsQueryable();
			}
			result = result
				.Include(p => p.ProductCategories)
				.ThenInclude(pc => pc.Category)
				.Include(p => p.Instructor)
				.AsQueryable();
			return await result.ToListAsync();
		}

		public async Task UpdateInstructorOfProducts()
		{
			var products = await Context
				.Products
				.ToListAsync();
			foreach (var product in products)
			{
				product.InstructorId = 1;
			};
			Context.Products.UpdateRange(products);
			await Context.SaveChangesAsync();
		}

		public void UpdateProduct(Product product)
		{
			Product oldProduct = Context
				.Products
				.Include(p => p.ProductCategories)
				.ThenInclude(pc => pc.Category)
				.Include(p => p.Instructor)
				.Where(p => p.Id == product.Id)
				.FirstOrDefault();
			oldProduct.Name = product.Name;
			oldProduct.Description = product.Description;
			oldProduct.Price = product.Price;
			oldProduct.IsActive = product.IsActive;
			oldProduct.IsHome = product.IsHome;
			oldProduct.IsDeleted = product.IsDeleted;
			oldProduct.InstructorId = product.InstructorId;
			oldProduct.Url = product.Url;
			oldProduct.ModifiedDate = DateTime.Now;
			oldProduct.ProductCategories = product.ProductCategories;
			oldProduct.ImageUrl = product.ImageUrl;

			Context.Products.Update(oldProduct);
			Context.SaveChanges();
		}
	}
}