using Microsoft.AspNetCore.Mvc;
using Net_II_Step_Task_7.Entities;

namespace Net_II_Step_Task_7.Controllers
{
	public class TPController : Controller
	{
		public readonly TPContext _context;

		public TPController(TPContext context)
		{
			_context = context;
		}

		/*Teacher[] GetAllTeachersByStudent(string studentName)
		{
			var getStudents = _context.Pupils.Where(x => x.FirstName == "Giorgi").ToArray();

			var getStudentsId = _context


			var getTeachers = from Teacher in Teacher
							  where 
			return getTeachers;
		}*/

	}
}
