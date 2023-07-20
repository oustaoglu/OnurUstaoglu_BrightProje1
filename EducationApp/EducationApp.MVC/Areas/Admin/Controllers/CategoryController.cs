using Microsoft.AspNetCore.Mvc;

namespace EducationApp.MVC.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
