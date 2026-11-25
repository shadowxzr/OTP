using System;

namespace DrivingSchool.Entities
{
	public class Student
	{
		public int Id { get; private set; }
		public string FirstName { get; private set; } = string.Empty;
		public string LastName { get; private set; } = string.Empty;
		public DateTime BirthDate { get; private set; }
		public string Phone { get; private set; } = string.Empty;
		public int GroupId { get; private set; }

		public static Student CreateEntity(int id, string firstName, string lastName, DateTime birthDate, string phone, int groupId)
		{
			return new Student
			{
				Id = id,
				FirstName = firstName ?? string.Empty,
				LastName = lastName ?? string.Empty,
				BirthDate = birthDate,
				Phone = phone ?? string.Empty,
				GroupId = groupId
			};
		}
		protected Student() { }

		public StudyGroup Group { get; private set; }
		public ICollection<Exam> Exams { get; private set; } = new List<Exam>();
		public ICollection<Payment> Payments { get; private set; } = new List<Payment>();
		public ICollection<Attendance> Attendances { get; private set; } = new List<Attendance>();
	}
}