using EducationApp.Business.Abstract;
using EducationApp.Entity.Concrete;
using EducationApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EducationApp.MVC.Controllers
{
    public class EducationAppController : Controller
    {
        private readonly IProductService _productManager;

        public EducationAppController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public async Task<IActionResult> ProductList(string categoryurl = null, string instructorurl = null)
        {
            List<Product> productList = await _productManager.GetAllActiveProductsAsync(categoryurl, instructorurl);
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
    }
}
