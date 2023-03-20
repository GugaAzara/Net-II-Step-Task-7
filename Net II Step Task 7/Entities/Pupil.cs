using Microsoft.Identity.Client;

namespace Net_II_Step_Task_7.Entities
{
	public class Pupil
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Sex { get; set; }
		public string Class { get; set; }

		public ICollection<TeacherPupil> TeacherPupil { get; set; }

	}
}
