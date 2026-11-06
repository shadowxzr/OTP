using System;
using System.Windows.Forms;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class CategoryEditForm : Form
	{
		private readonly ICategoryRepository _repository;
		private readonly int _id;

		public CategoryEditForm(ICategoryRepository repository, int id)
		{
			InitializeComponent();
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
			_id = id;
		}

		private void CategoryEditForm_Load(object sender, EventArgs e)
		{
			if (_id > 0)
			{
				var category = _repository.ReadById(_id);
				if (category != null)
				{
					textBoxName.Text = category.Name;
					Text = "Редактирование категории";
				}
			}
			else Text = "Добавление категории";
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxName.Text))
			{
				MessageBox.Show("Введите название!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var entity = Category.CreateEntity(_id, textBoxName.Text.Trim());
			if (_id == 0) _repository.Create(entity);
			else _repository.Update(entity);

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}