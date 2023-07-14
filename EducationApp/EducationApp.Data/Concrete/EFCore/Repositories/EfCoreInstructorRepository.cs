using EducationApp.Data.Abstract;
using EducationApp.Data.Concrete.EFCore.Contexts;
using EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Data.Concrete.EFCore.Repositories
{
    public class EfCoreInstructorRepository : EfCoreGenericRepository<Instructor>, IInstructorRepository
    {
        EducationAppContext _context = new EducationAppContext();

        public async Task CreateWithUrl(Instructor instructor)
        {
            await _context.Instructors.AddAsync(instructor);
            await _context.SaveChangesAsync();
            instructor.Url = instructor.Url + "-" + instructor.Id;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Instructor>> GetAllInstructorsAsync(bool isDeleted, bool? isActive)
        {
            var result = _context
                .Instructors
                .Where(a => a.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(a => a.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
