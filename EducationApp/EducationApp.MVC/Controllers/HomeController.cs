using EducationApp.Business.Abstract;
using EducationApp.Entity.Concrete;
using EducationApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EducationApp.MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly IProductService _productManager;

		public HomeController(ICategoryService categoryManager, IProductService productManager)
		{
			_productManager = productManager;
		}

        public async Task<IActionResult> Index()
        {
            List<Product> productList = await _productManager.GetHomePageProductsAsync();

            List<ProductViewModel> productViewModelList = productList.Select(b => new ProductViewModel
            {
                Id = b.Id,
                Name = b.Name,
                Price = b.Price,
                Url = b.Url,
                ImageUrl = b.ImageUrl,
                InstructorName = b.Instructor.FirstName + " " + b.Instructor.LastName,
                InstructorUrl = b.Instructor.Url,
            }).ToList();
            return View(productViewModelList);
        }
    }
}