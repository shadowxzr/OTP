using System.Collections.Generic;
using DrivingSchool.Entities;

namespace DrivingSchool.Repositories.Interfaces
{
	public interface ILessonRepository
	{
		void Create(Lesson lesson);
		IEnumerable<Lesson> ReadAll();
	}
}