using System;
using System.Windows.Forms;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class StudyGroupEditForm : Form
	{
		private readonly IStudyGroupRepository _repository;
		private readonly ICategoryRepository _categoryRepository;
		private readonly int _id;

		public StudyGroupEditForm(IStudyGroupRepository repository, ICategoryRepository categoryRepository, int id)
		{
			InitializeComponent(); _repository = repository; _categoryRepository = categoryRepository; _id = id;
		}

		private void StudyGroupEditForm_Load(object sender, EventArgs e)
		{
			comboBoxCategory.DataSource = _categoryRepository.ReadAll();
			comboBoxCategory.DisplayMember = "Name"; comboBoxCategory.ValueMember = "Id";

			if (_id > 0)
			{
				var group = _repository.ReadById(_id);
				if (group != null)
				{
					textBoxName.Text = group.Name; comboBoxCategory.SelectedValue = group.CategoryId;
					Text = "Редактирование группы";
				}
			}
			else Text = "Добавление группы";
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxName.Text) || comboBoxCategory.SelectedValue == null)
			{
				MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			int categoryId = (int)comboBoxCategory.SelectedValue;
			var entity = StudyGroup.CreateEntity(_id, textBoxName.Text.Trim(), categoryId);

			if (_id == 0) _repository.Create(entity); else _repository.Update(entity);

			DialogResult = DialogResult.OK; Close();
		}
	}
}