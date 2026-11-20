using Autofac;
using DrivingSchool.Forms; // Убедитесь, что namespace совпадает с вашим

namespace DrivingSchool.Infrastructure.Modules
{
	/// <summary>
	/// Модуль Autofac для автоматической регистрации всех форм приложения.
	/// </summary>
	public class FormsModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			// Находим сборку, в которой лежит MainForm
			var formsAssembly = typeof(MainForm).Assembly;

			// Регистрируем все классы, имя которых заканчивается на "Form"
			builder.RegisterAssemblyTypes(formsAssembly)
				   .Where(t => t.Name.EndsWith("Form"))
				   .AsSelf();
		}
	}
}