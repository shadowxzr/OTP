using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DrivingSchool.Entities; // Убедись, что namespace совпадает с твоими сущностями!
using DrivingSchool.Entities.Enums; // Если enum лежат в отдельном namespace
using Microsoft.EntityFrameworkCore;

namespace DrivingSchool.Data
{
	public class AppDbContext : DbContext
	{
		// 1. DbSet для каждой сущности
		public DbSet<Category> Categories { get; set; }
		public DbSet<StudyGroup> StudyGroups { get; set; }
		public DbSet<Instructor> Instructors { get; set; }
		public DbSet<LessonType> LessonTypes { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Lesson> Lessons { get; set; }
		public DbSet<Exam> Exams { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Attendance> Attendances { get; set; }

		// 2. Строка подключения
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// ЗАМЕНИ ДАННЫЕ НА СВОИ! (логин, пароль, имя базы)
			optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=driving_school_db;Username=postgres;Password=postgres");

			// Опционально: логирование SQL-запросов в консоль (очень полезно для отладки)
			optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
		}

		// 3. Настройка связей через Fluent API
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Связь Category 1:N StudyGroup
			modelBuilder.Entity<StudyGroup>()
				.HasOne(sg => sg.Category)
				.WithMany(c => c.StudyGroups)
				.HasForeignKey(sg => sg.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			// Связь StudyGroup 1:N Student
			modelBuilder.Entity<Student>()
				.HasOne(s => s.Group)
				.WithMany(g => g.Students)
				.HasForeignKey(s => s.GroupId)
				.OnDelete(DeleteBehavior.Restrict);

			// Связь StudyGroup 1:N Lesson
			modelBuilder.Entity<Lesson>()
				.HasOne(l => l.Group)
				.WithMany(g => g.Lessons)
				.HasForeignKey(l => l.GroupId)
				.OnDelete(DeleteBehavior.Restrict);

			// Связь Instructor 1:N Lesson
			modelBuilder.Entity<Lesson>()
				.HasOne(l => l.Instructor)
				.WithMany(i => i.Lessons)
				.HasForeignKey(l => l.InstructorId)
				.OnDelete(DeleteBehavior.Restrict);

			// Связь LessonType 1:N Lesson
			modelBuilder.Entity<Lesson>()
				.HasOne(l => l.LessonType)
				.WithMany(lt => lt.Lessons)
				.HasForeignKey(l => l.LessonTypeId)
				.OnDelete(DeleteBehavior.Restrict);

			// Связь Student 1:N Exam
			modelBuilder.Entity<Exam>()
				.HasOne(e => e.Student)
				.WithMany(s => s.Exams)
				.HasForeignKey(e => e.StudentId)
				.OnDelete(DeleteBehavior.Cascade);

			// Связь Student 1:N Payment
			modelBuilder.Entity<Payment>()
				.HasOne(p => p.Student)
				.WithMany(s => s.Payments)
				.HasForeignKey(p => p.StudentId)
				.OnDelete(DeleteBehavior.Cascade);

			// Связь Student N:M Lesson через Attendance (Транзакционная таблица)
			modelBuilder.Entity<Attendance>()
				.HasOne(a => a.Student)
				.WithMany(s => s.Attendances)
				.HasForeignKey(a => a.StudentId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Attendance>()
				.HasOne(a => a.Lesson)
				.WithMany(l => l.Attendances)
				.HasForeignKey(a => a.LessonId)
				.OnDelete(DeleteBehavior.Cascade);

			// Ограничения длины строк (согласно твоей ER-диаграмме)
			modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(10);
			modelBuilder.Entity<StudyGroup>().Property(sg => sg.Name).HasMaxLength(50);
			modelBuilder.Entity<Instructor>().Property(i => i.FirstName).HasMaxLength(50);
			modelBuilder.Entity<Instructor>().Property(i => i.LastName).HasMaxLength(50);
			modelBuilder.Entity<Instructor>().Property(i => i.Phone).HasMaxLength(20);
			modelBuilder.Entity<LessonType>().Property(lt => lt.Name).HasMaxLength(50);
			modelBuilder.Entity<Student>().Property(s => s.FirstName).HasMaxLength(50);
			modelBuilder.Entity<Student>().Property(s => s.LastName).HasMaxLength(50);
			modelBuilder.Entity<Student>().Property(s => s.Phone).HasMaxLength(20);
		}
	}
}