namespace DrivingSchool.Entities
{
	public class Category
	{
		public int Id { get; private set; }
		public string Name { get; private set; } = string.Empty;

		public static Category CreateEntity(int id, string name)
		{
			return new Category
			{
				Id = id,
				Name = name ?? string.Empty
			};
		}
	}
}