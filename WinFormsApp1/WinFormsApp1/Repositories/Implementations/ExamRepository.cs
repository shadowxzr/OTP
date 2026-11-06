using System.Collections.Generic;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Repositories.Implementations
{
	public class ExamRepository : IExamRepository
	{
		public void Create(Exam exam) { }
		public IEnumerable<Exam> ReadAll() => new List<Exam>();
	}
}