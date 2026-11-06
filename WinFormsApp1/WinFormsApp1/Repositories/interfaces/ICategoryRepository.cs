using System.Collections.Generic;
using DrivingSchool.Entities;

namespace DrivingSchool.Repositories.Interfaces
{
	public interface ICategoryRepository
	{
		void Create(Category category);
		IEnumerable<Category> ReadAll();
		Category ReadById(int id);
		void Update(Category category);
		void Delete(int id);
	}
}