using System.Collections.Generic;
using DrivingSchool.Entities;

namespace DrivingSchool.Repositories.Interfaces
{
	public interface IStudyGroupRepository
	{
		void Create(StudyGroup group);
		IEnumerable<StudyGroup> ReadAll();
		StudyGroup ReadById(int id);
		void Update(StudyGroup group);
		void Delete(int id);
	}
}