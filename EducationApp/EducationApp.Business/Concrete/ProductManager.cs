using EducationApp.Business.Abstract;
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
		public Task<List<Product>> GetHomePageProductsAsync()
		{
			throw new NotImplementedException();
		}
	}
}
