using System.Collections.Generic;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Repositories.Implementations
{
	public class CategoryRepository : ICategoryRepository
	{
		public void Create(Category category) { }
		public IEnumerable<Category> ReadAll() => new List<Category>();
		public Category ReadById(int id) => Category.CreateEntity(0, string.Empty);
		public void Update(Category category) { }
		public void Delete(int id) { }
	}
}