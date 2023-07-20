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
	public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
	{
        EducationAppContext _context = new EducationAppContext();
        public async Task<List<Category>> GetAllCategoriesAsync(bool isDeleted, bool? isActive = null)
        {
            var result = _context
                .Categories
                .Where(c => c.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(c => c.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
