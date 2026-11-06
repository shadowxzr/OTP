using System.Collections.Generic;
using DrivingSchool.Entities;

namespace DrivingSchool.Repositories.Interfaces
{
	public interface IExamRepository
	{
		void Create(Exam exam);
		IEnumerable<Exam> ReadAll();
	}
}