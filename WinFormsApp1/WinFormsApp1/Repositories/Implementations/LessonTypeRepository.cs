using System.Collections.Generic;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Repositories.Implementations
{
	public class LessonTypeRepository : ILessonTypeRepository
	{
		public void Create(LessonType lessonType) { }
		public IEnumerable<LessonType> ReadAll() => new List<LessonType>();
		public LessonType ReadById(int id) => LessonType.CreateEntity(0, string.Empty, false);
		public void Update(LessonType lessonType) { }
		public void Delete(int id) { }
	}
}