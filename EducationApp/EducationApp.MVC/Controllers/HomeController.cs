using EducationApp.Business.Abstract;
using EducationApp.Business.Concrete;
using EducationApp.Entity.Concrete;
using EducationApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EducationApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productManager;
        private readonly IInstructorService _instructorManager;

        public HomeController(ICategoryService categoryManager, IProductService productManager, IInstructorService instructorManager)
        {
            _productManager = productManager;
            _instructorManager = instructorManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> productList = await _productManager.GetProductsWithFullDataAsync(true, true);
            List<ProductViewModel> productViewModelList = productList.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Url = p.Url,
                ImageUrl = p.ImageUrl,
                InstructorName = p.Instructor.FirstName + " " + p.Instructor.LastName,
                InstructorUrl = p.Instructor.Url,
            }).ToList();
            return View(productViewModelList);
        }
        public async Task<IActionResult> Privacy()
        {
            List<Instructor> instructorList = await _instructorManager.GetInstructorsWithFullDataAsync(true);
            List<InstructorViewModel> instructorViewModelList = instructorList.Select(p => new InstructorViewModel
            {
                Id = p.Id,
                Name = p.FirstName,
                Url = p.Url,
                ImageUrl = p.PhotoUrl
            }).ToList();
            return View(instructorViewModelList);
        }
    }
}