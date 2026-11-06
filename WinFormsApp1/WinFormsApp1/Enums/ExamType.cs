using System;

namespace DrivingSchool.Entities.Enums
{
	[Flags]
	public enum ExamType
	{
		None = 0,
		Theory = 1,
		Driving = 2,
		Both = Theory | Driving
	}
}