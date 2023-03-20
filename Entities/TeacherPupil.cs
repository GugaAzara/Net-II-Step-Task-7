namespace Net_II_Step_Task_7.Entities
{
	public class TeacherPupil
	{
		public int Id { get; set; }
		public int TeacherId { get; set; }
		public Teacher Teachers { get; set; }
		public int PupilId { get; set; }
		public Pupil Pupils { get; set; }
	}
}
