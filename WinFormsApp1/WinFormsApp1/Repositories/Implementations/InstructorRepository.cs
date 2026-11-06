using System.Collections.Generic;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Repositories.Implementations
{
	public class InstructorRepository : IInstructorRepository
	{
		public void Create(Instructor instructor) { }
		public IEnumerable<Instructor> ReadAll() => new List<Instructor>();
		public Instructor ReadById(int id) => Instructor.CreateEntity(0, string.Empty, string.Empty, string.Empty, 0);
		public void Update(Instructor instructor) { }
		public void Delete(int id) { }
	}
}