using DrivingSchool.Entities.Enums.Entities.Enums;

namespace DrivingSchool.Entities
{
	public class Exam
	{
		public int Id { get; private set; }
		public int StudentId { get; private set; }
		public DateTime Date { get; private set; }
		public ExamType ExamType { get; private set; }
		public int Grade { get; private set; }

		public static Exam CreateEntity(int id, int studentId, DateTime date, ExamType examType, int grade)
		{
			return new Exam
			{
				Id = id,
				StudentId = studentId,
				Date = date,
				ExamType = examType,
				Grade = grade
			};
		}
	}
}