
namespace DrivingSchool.Entities
{
	public class Lesson
	{
		public int Id { get; private set; }
		public DateTime Date { get; private set; }
		public int LessonTypeId { get; private set; }
		public int InstructorId { get; private set; }
		public int GroupId { get; private set; }

		public static Lesson CreateEntity(int id, DateTime date, int lessonTypeId, int instructorId, int groupId)
		{
			return new Lesson
			{
				Id = id,
				Date = date,
				LessonTypeId = lessonTypeId,
				InstructorId = instructorId,
				GroupId = groupId
			};
		}
	}
}