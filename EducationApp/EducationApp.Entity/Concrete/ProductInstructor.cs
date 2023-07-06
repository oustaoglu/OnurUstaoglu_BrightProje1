using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Entity.Concrete
{
	public class ProductInstructor
	{
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
