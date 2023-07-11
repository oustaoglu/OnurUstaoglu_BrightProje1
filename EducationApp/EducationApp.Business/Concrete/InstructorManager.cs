using EducationApp.Business.Abstract;
using EducationApp.Data.Abstract;
using EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Business.Concrete
{
	public class InstructorManager : IInstructorService
	{
		private readonly IInstructorRepository _instructorRepository;

		public InstructorManager(IInstructorRepository instructorRepository)
		{
			_instructorRepository = instructorRepository;
		}

		public async Task CreateAsync(Instructor instructor)
		{
			await _instructorRepository.CreateAsync(instructor);
		}

		public void Delete(Instructor instructor)
		{
			_instructorRepository.Delete(instructor);
		}

		public async Task<List<Instructor>> GetAllAsync()
		{
            var result = await _instructorRepository.GetAllAsync();
            return result;
		}

		public async Task<Instructor> GetByIdAsync(int id)
		{
			var result = await _instructorRepository.GetByIdAsync(id);
			return result;
		}

		public void Update(Instructor instructor)
		{
			_instructorRepository.Update(instructor);
		}
	}
}
