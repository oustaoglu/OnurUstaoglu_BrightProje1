using EducationApp.Entity.Concrete;

namespace EducationApp.MVC.Areas.Admin.Models
{
    public class UserUpdateViewModel
    {
        public User User { get; set; }
        public List<Role> Roles { get; set; }
        public IList<string> SelectedRoles { get; set; }
    }
}
