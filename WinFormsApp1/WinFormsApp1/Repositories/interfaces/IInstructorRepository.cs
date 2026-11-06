using System.Collections.Generic;
using DrivingSchool.Entities;

namespace DrivingSchool.Repositories.Interfaces
{
	public interface IInstructorRepository
	{
		void Create(Instructor instructor);
		IEnumerable<Instructor> ReadAll();
		Instructor ReadById(int id);
		void Update(Instructor instructor);
		void Delete(int id);
	}
}