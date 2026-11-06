using System;
using System.Windows.Forms;
using Autofac;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class CategoryListForm : Form
	{
		private readonly ICategoryRepository _repository;
		private readonly ILifetimeScope _scope;

		public CategoryListForm(ICategoryRepository repository, ILifetimeScope scope)
		{
			InitializeComponent();
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
			_scope = scope ?? throw new ArgumentNullException(nameof(scope));
		}

		private void CategoryListForm_Load(object sender, EventArgs e) => LoadData();
		private void LoadData() => dataGridView.DataSource = _repository.ReadAll();

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var form = _scope.Resolve<CategoryEditForm>(new TypedParameter(typeof(int), 0));
			if (form.ShowDialog() == DialogResult.OK) LoadData();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (dataGridView.CurrentRow?.DataBoundItem is Category selected)
			{
				var form = _scope.Resolve<CategoryEditForm>(new TypedParameter(typeof(int), selected.Id));
				if (form.ShowDialog() == DialogResult.OK) LoadData();
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView.CurrentRow?.DataBoundItem is Category selected)
			{
				_repository.Delete(selected.Id);
				LoadData();
			}
		}
	}
}