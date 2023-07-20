using EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Data.Abstract
{
	public interface IProductRepository : IGenericRepository<Product>
	{
		Task<List<Product>> GetHomePageProductsAsync();
		Task<List<Product>> GetAllActiveProductsAsync(string categoryUrl = null, string instructorUrl = null);
        Task<Product> GetProductsByUrlAsync(string productUrl);
        Task<List<Product>> GetProductsWithFullDataAsync(bool? isHome, bool? isActive);
    }
}
