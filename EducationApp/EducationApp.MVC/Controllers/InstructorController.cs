using EducationApp.Business.Abstract;
using EducationApp.Business.Concrete;
using EducationApp.Entity.Concrete;
using EducationApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EducationApp.MVC.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorManager;

        public InstructorController(IInstructorService instructorManager)
        {
            _instructorManager = instructorManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Instructor> productList = await _instructorManager.GetInstructorsWithFullDataAsync(true);
            List<InstructorViewModel> instructorViewModelList = productList.Select(p => new InstructorViewModel
            {
                Id = p.Id,
                Name = p.FirstName,
                Url = p.Url,
                ImageUrl = p.PhotoUrl
                //ImageUrl = p.ImageUrl,
                //InstructorName = p.Instructor.FirstName + " " + p.Instructor.LastName,
                //InstructorUrl = p.Instructor.Url,
            }).ToList();
            return View(instructorViewModelList);
        }
    }
}
