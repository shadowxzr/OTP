using System;
using System.Windows.Forms;
using Autofac;
using DrivingSchool.Infrastructure;
using DrivingSchool.Forms;

namespace DrivingSchool
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// 1. Создаем контейнер
			var container = ContainerConfig.CreateContainer();

			// 2. Создаем scope и получаем из него главную форму
			using (var scope = container.BeginLifetimeScope())
			{
				var mainForm = scope.Resolve<MainForm>();
				Application.Run(mainForm);
			}
		}
	}
}