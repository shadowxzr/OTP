using System.Collections.Generic;
using DrivingSchool.Entities;

namespace DrivingSchool.Repositories.Interfaces
{
	public interface ILessonTypeRepository
	{
		void Create(LessonType lessonType);
		IEnumerable<LessonType> ReadAll();
		LessonType ReadById(int id);
		void Update(LessonType lessonType);
		void Delete(int id);
	}
}