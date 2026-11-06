namespace DrivingSchool.Entities
{
	public class Instructor
	{
		public int Id { get; private set; }
		public string FirstName { get; private set; } = string.Empty;
		public string LastName { get; private set; } = string.Empty;
		public string Phone { get; private set; } = string.Empty;
		public int ExperienceYears { get; private set; }

		public static Instructor CreateEntity(int id, string firstName, string lastName, string phone, int experienceYears)
		{
			return new Instructor
			{
				Id = id,
				FirstName = firstName ?? string.Empty,
				LastName = lastName ?? string.Empty,
				Phone = phone ?? string.Empty,
				ExperienceYears = experienceYears
			};
		}
	}
}