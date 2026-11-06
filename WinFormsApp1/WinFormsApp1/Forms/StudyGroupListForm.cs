using System;
using System.Windows.Forms;
using Autofac;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class StudyGroupListForm : Form
	{
		private readonly IStudyGroupRepository _repository;
		private readonly ILifetimeScope _scope;

		public StudyGroupListForm(IStudyGroupRepository repository, ILifetimeScope scope)
		{
			InitializeComponent(); _repository = repository; _scope = scope;
		}

		private void StudyGroupListForm_Load(object sender, EventArgs e) => LoadData();
		private void LoadData() => dataGridView.DataSource = _repository.ReadAll();

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var form = _scope.Resolve<StudyGroupEditForm>(new TypedParameter(typeof(int), 0));
			if (form.ShowDialog() == DialogResult.OK) LoadData();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (dataGridView.CurrentRow?.DataBoundItem is StudyGroup selected)
			{
				var form = _scope.Resolve<StudyGroupEditForm>(new TypedParameter(typeof(int), selected.Id));
				if (form.ShowDialog() == DialogResult.OK) LoadData();
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView.CurrentRow?.DataBoundItem is StudyGroup selected)
			{
				_repository.Delete(selected.Id); LoadData();
			}
		}
	}
}