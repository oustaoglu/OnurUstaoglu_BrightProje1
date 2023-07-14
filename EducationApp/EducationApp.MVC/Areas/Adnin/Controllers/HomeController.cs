using Microsoft.AspNetCore.Mvc;

namespace EducationApp.MVC.Areas.Adnin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
