using EducationApp.Business.Abstract;
using EducationApp.Data.Abstract;
using EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Business.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductRepository _productRepository;

		public ProductManager(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public async Task CreateAsync(Product product)
		{
			await _productRepository.CreateAsync(product);
		}

		public void Delete(Product product)
		{
			_productRepository.Delete(product);
		}

		public async Task<List<Product>> GetAllAsync()
		{
			var result = await _productRepository.GetAllAsync();
			return result;
		}

		public async Task<Product> GetByIdAsync(int id)
		{
			var result = await _productRepository.GetByIdAsync(id);
			return result;
		}
		public void Update(Product product)
		{
			_productRepository.Update(product);
		}

		public async Task<List<Product>> GetHomePageProductsAsync()
		{
			var result = await _productRepository.GetHomePageProductsAsync();
			return result;
		}

		public async Task<List<Product>> GetAllActiveProductsAsync(string categoryUrl = null, string instructorUrl = null)
		{
			var result = await _productRepository.GetAllActiveProductsAsync(categoryUrl, instructorUrl);
			return result;
		}
		public async Task<Product> GetProductsByUrlAsync(string productUrl)
		{
			var result = await _productRepository.GetProductsByUrlAsync(productUrl);
			return result;
		}

        public async Task<List<Product>> GetProductsWithFullDataAsync(bool? isHome = null, bool? isActive = null)
        {
            var result = await _productRepository.GetProductsWithFullDataAsync(isHome, isActive);
            return result;
        }
    }
}
