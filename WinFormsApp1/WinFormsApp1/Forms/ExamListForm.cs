using System;
using System.Windows.Forms;
using Autofac;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class ExamListForm : Form
	{
		private readonly IExamRepository _repository;
		private readonly ILifetimeScope _scope;

		public ExamListForm(IExamRepository repository, ILifetimeScope scope)
		{
			InitializeComponent(); _repository = repository; _scope = scope;
		}

		private void ExamListForm_Load(object sender, EventArgs e) => LoadData();
		private void LoadData() => dataGridView.DataSource = _repository.ReadAll();

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var form = _scope.Resolve<ExamAddForm>();
			if (form.ShowDialog() == DialogResult.OK) LoadData();
		}
	}
}