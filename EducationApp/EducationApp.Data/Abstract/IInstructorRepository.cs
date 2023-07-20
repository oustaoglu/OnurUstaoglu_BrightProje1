using EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Data.Abstract
{
    public interface IInstructorRepository : IGenericRepository<Instructor>
    {
        Task CreateWithUrl(Instructor instructor);
        Task<List<Instructor>> GetAllActiveInstructorsAsync(string categoryUrl, string instructorUrl);
        Task<List<Instructor>> GetAllInstructorsAsync(bool isDeleted, bool? isActive);
        Task<List<Instructor>> GetHomePageInstructorsAsync();
        Task<Instructor> GetInstructorsByUrlAsync(string url);
        Task<List<Instructor>> GetInstructorsWithFullDataAsync(bool? isActive);
    }
}
