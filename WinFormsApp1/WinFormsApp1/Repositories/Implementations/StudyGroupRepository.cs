using System.Collections.Generic;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Repositories.Implementations
{
	public class StudyGroupRepository : IStudyGroupRepository
	{
		public void Create(StudyGroup group) { }
		public IEnumerable<StudyGroup> ReadAll() => new List<StudyGroup>();
		public StudyGroup ReadById(int id) => StudyGroup.CreateEntity(0, string.Empty, 0);
		public void Update(StudyGroup group) { }
		public void Delete(int id) { }
	}
}