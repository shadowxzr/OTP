namespace DrivingSchool.Entities
{
	public class StudyGroup
	{
		public int Id { get; private set; }
		public string Name { get; private set; } = string.Empty;
		public int CategoryId { get; private set; }

		public static StudyGroup CreateEntity(int id, string name, int categoryId)
		{
			return new StudyGroup
			{
				Id = id,
				Name = name ?? string.Empty,
				CategoryId = categoryId
			};
		}
	}
}