using System.Collections.Generic;
using DrivingSchool.Entities;

namespace DrivingSchool.Repositories.Interfaces
{
	public interface IAttendanceRepository
	{
		void Create(Attendance attendance);
		IEnumerable<Attendance> ReadAllByLesson(int lessonId);
	}
}