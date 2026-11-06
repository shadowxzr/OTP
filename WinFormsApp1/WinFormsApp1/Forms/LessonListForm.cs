using System;
using System.Windows.Forms;
using Autofac;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class LessonListForm : Form
	{
		private readonly ILessonRepository _repository;
		private readonly ILifetimeScope _scope;

		public LessonListForm(ILessonRepository repository, ILifetimeScope scope)
		{
			InitializeComponent(); _repository = repository; _scope = scope;
		}

		private void LessonListForm_Load(object sender, EventArgs e) => LoadData();
		private void LoadData() => dataGridView.DataSource = _repository.ReadAll();

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var form = _scope.Resolve<LessonAddForm>();
			if (form.ShowDialog() == DialogResult.OK) LoadData();
		}
	}
}