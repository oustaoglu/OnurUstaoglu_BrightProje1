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
		public EfCoreInstructorRepository(EducationAppContext _context) : base(_context)
		{

		}

		private EducationAppContext Context
		{
			get { return _dbContext as EducationAppContext; }
		}

		public async Task CreateWithUrl(Instructor instructor)
        {
            await Context.Instructors.AddAsync(instructor);
            await Context.SaveChangesAsync();
            instructor.Url = instructor.Url + "-" + instructor.Id;
            await Context.SaveChangesAsync();
        }

        public async Task<List<Instructor>> GetAllInstructorsAsync(bool isDeleted, bool? isActive)
        {
            var result = Context
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
    }
}
