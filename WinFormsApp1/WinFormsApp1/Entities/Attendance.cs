namespace DrivingSchool.Entities
{
	public class Attendance
	{
		public int Id { get; private set; }
		public int StudentId { get; private set; }
		public int LessonId { get; private set; }
		public bool IsPresent { get; private set; }

		public static Attendance CreateEntity(int id, int studentId, int lessonId, bool isPresent)
		{
			return new Attendance
			{
				Id = id,
				StudentId = studentId,
				LessonId = lessonId,
				IsPresent = isPresent
			};
		}
		protected Attendance () { }

		public Student Student { get; private set; }
		public Lesson Lesson { get; private set; }
	}
}