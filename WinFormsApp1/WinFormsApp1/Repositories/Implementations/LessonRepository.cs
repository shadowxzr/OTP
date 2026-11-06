using System;
using System.Collections.Generic;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Repositories.Implementations
{
	public class LessonRepository : ILessonRepository
	{
		public void Create(Lesson lesson) { }
		public IEnumerable<Lesson> ReadAll() => new List<Lesson>();
	}
}