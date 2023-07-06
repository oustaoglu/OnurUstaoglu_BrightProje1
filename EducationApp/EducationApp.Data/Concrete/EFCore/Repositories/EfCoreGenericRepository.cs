using EducationApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Data.Concrete.EFCore.Repositories
{
	public class EfCoreGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
	}
}
