using EducationApp.Data.Abstract;
using EducationApp.Data.Concrete.EFCore.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Data.Concrete.EFCore.Repositories
{
	public class EfCoreGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		EducationAppContext _context = new EducationAppContext();
		public async Task CreateAsync(TEntity entity)
		{
			await _context.Set<TEntity>().AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public void Delete(TEntity entity)
		{
			_context.Set<TEntity>().Remove(entity);
			_context.SaveChanges();
		}

		public async Task<List<TEntity>> GetAllAsync()
		{
			return await _context.Set<TEntity>().ToListAsync();
		}

		public async Task<TEntity> GetByIdAsync(int id)
		{
			return await _context.Set<TEntity>().FindAsync(id);
		}

		public void Update(TEntity entity)
		{
			_context.Set<TEntity>().Update(entity);
			_context.SaveChanges();
		}
	}
}
