using System;
using System.Windows.Forms;
using Autofac;
using DrivingSchool.Infrastructure;
using DrivingSchool.Forms; // «десь будет лежать MainForm

namespace DrivingSchool
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// 1. —оздаем и настраиваем IoC-контейнер
			var container = ContainerConfig.CreateContainer();

			// 2. –егистрируем главную форму (пока еЄ нет Ч закомментируй эту строку)
			// container.RegisterType<MainForm>().AsSelf();

			// 3. «апускаем приложение, получа€ форму из контейнера
			// using (var scope = container.BeginLifetimeScope())
			// {
			//     var mainForm = scope.Resolve<MainForm>();
			//     Application.Run(mainForm);
			// }

			// ¬–≈ћ≈ЌЌјя «ј√Ћ”Ў ј, пока MainForm не создана:
			Application.Run(new Form());
		}
	}
}