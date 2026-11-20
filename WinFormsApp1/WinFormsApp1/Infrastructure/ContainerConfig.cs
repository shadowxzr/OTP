using Autofac;
using DrivingSchool.Repositories.Interfaces;
using DrivingSchool.Repositories.Implementations;
using DrivingSchool.Infrastructure.Modules; // Подключаем наш модуль

namespace DrivingSchool.Infrastructure
{
    public static class ContainerConfig
    {
        public static IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            // 1. Регистрация репозиториев
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<InstructorRepository>().As<IInstructorRepository>();
            builder.RegisterType<LessonTypeRepository>().As<ILessonTypeRepository>();
            builder.RegisterType<StudyGroupRepository>().As<IStudyGroupRepository>();
            builder.RegisterType<LessonRepository>().As<ILessonRepository>();
            builder.RegisterType<ExamRepository>().As<IExamRepository>();
            builder.RegisterType<PaymentRepository>().As<IPaymentRepository>();
            builder.RegisterType<AttendanceRepository>().As<IAttendanceRepository>();

            // 2. Регистрация форм через отдельный модуль
            builder.RegisterModule<FormsModule>();

            return builder.Build();
        }
    }
}