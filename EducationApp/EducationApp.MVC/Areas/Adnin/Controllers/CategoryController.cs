using Microsoft.AspNetCore.Mvc;

namespace EducationApp.MVC.Areas.Adnin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
