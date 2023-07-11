using EducationApp.Business.Abstract;
using EducationApp.Business.Concrete;
using EducationApp.Entity.Concrete;
using EducationApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.MVC.ViewComponents
{
    public class InstructorsViewComponent: ViewComponent
    {
        private readonly IInstructorService _instructorManager;

        public InstructorsViewComponent(IInstructorService instructorManager)
        {
            _instructorManager = instructorManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Instructor> authorList = await _instructorManager.GetAllAsync();
            List<InstructorViewModel> instructorViewModelList = authorList.Select(a => new InstructorViewModel
            {
                Name=a.FirstName + " " + a.LastName,
                Url=a.Url
            }).ToList();
            return View(instructorViewModelList);
        }
    }
}
