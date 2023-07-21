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

        public async Task<List<Instructor>> GetAllActiveInstructorsAsync(string categoryUrl, string productUrl)
        {

            var result = _context
                .Instructors
                .Where(p => p.IsActive && !p.IsDeleted)
                .Include(p => p.Products)
                .AsQueryable();
            if (categoryUrl != null)
            {
                result = result
                    .Include(p => p.Products)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }

        public async Task<List<Instructor>> GetAllInstructorsAsync(bool isDeleted, bool? isActive)
        {
            var result = _context
                .Instructors
                .Where(i => i.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(i => i.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }

        public async Task<List<Instructor>> GetHomePageInstructorsAsync()
        {
            var result = await _context
                .Instructors
                .Where(b => b.IsActive && !b.IsDeleted)
                .ToListAsync();
            return result;
        }

        public async Task<Instructor> GetInstructorsByUrlAsync(string url)
        {
            var result = await _context
                .Instructors
                .Where(b => b.IsActive && !b.IsDeleted && b.Url == url)
                .FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Instructor>> GetInstructorsWithFullDataAsync(bool? isActive)
        {
            var result = _context
                .Instructors
                .Where(b => !b.IsDeleted)
                .AsQueryable();

            if (isActive != null)
            {
                result = result
                    .Where(b => b.IsActive == isActive)
                    .AsQueryable();
            }
            result = result
                .Include(b => b.Products)
                .AsQueryable();

            return await result.ToListAsync();
        }
    }
}
