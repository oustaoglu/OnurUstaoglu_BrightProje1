using EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Business.Abstract
{
	public interface IInstructorService
	{
		Task<Instructor> GetByIdAsync(int id);
		Task<List<Instructor>> GetAllAsync();
		Task CreateAsync(Instructor instructor);
		void Update(Instructor instructor);
		void Delete(Instructor instructor);
	}
}
