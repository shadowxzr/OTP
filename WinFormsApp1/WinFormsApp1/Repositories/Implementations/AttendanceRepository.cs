using System.Collections.Generic;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Repositories.Implementations
{
	public class AttendanceRepository : IAttendanceRepository
	{
		public void Create(Attendance attendance) { }
		public IEnumerable<Attendance> ReadAllByLesson(int lessonId) => new List<Attendance>();
	}
}