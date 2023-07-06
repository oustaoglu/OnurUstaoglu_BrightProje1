using EducationApp.Business.Abstract;
using EducationApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EducationApp.MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly IProductService _productManager;

		public HomeController(IProductService productManager)
		{
			_productManager = productManager;
		}

		public async Task<IActionResult> Index()
		{
			var products = await _productManager.GetHomePageProductsAsync();
			return View(products);
		}
	}
}