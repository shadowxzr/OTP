using Autofac;
using DrivingSchool.Repositories.Interfaces;
using DrivingSchool.Repositories.Implementations;

namespace DrivingSchool.Infrastructure
{
	public static class ContainerConfig
	{
		public static IContainer CreateContainer()
		{
			var builder = new ContainerBuilder();

			// Регистрация репозиториев (Интерфейс -> Реализация)
			// По умолчанию Autofac использует InstancePerDependency (аналог Transient в Unity)
			builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
			builder.RegisterType<InstructorRepository>().As<IInstructorRepository>();
			builder.RegisterType<LessonTypeRepository>().As<ILessonTypeRepository>();
			builder.RegisterType<StudyGroupRepository>().As<IStudyGroupRepository>();
			builder.RegisterType<LessonRepository>().As<ILessonRepository>();
			builder.RegisterType<ExamRepository>().As<IExamRepository>();
			builder.RegisterType<PaymentRepository>().As<IPaymentRepository>();
			builder.RegisterType<AttendanceRepository>().As<IAttendanceRepository>();

			return builder.Build();
		}
	}
}