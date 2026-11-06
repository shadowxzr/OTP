namespace DrivingSchool.Entities
{
	public class LessonType
	{
		public int Id { get; private set; }
		public string Name { get; private set; } = string.Empty;
		public bool IsTheory { get; private set; }

		public static LessonType CreateEntity(int id, string name, bool isTheory)
		{
			return new LessonType
			{
				Id = id,
				Name = name ?? string.Empty,
				IsTheory = isTheory
			};
		}
	}
}