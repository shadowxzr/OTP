using System;
using System.Windows.Forms;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class LessonTypeEditForm : Form
	{
		private readonly ILessonTypeRepository _repository;
		private readonly int _id;

		public LessonTypeEditForm(ILessonTypeRepository repository, int id)
		{
			InitializeComponent(); _repository = repository; _id = id;
		}

		private void LessonTypeEditForm_Load(object sender, EventArgs e)
		{
			if (_id > 0)
			{
				var lt = _repository.ReadById(_id);
				if (lt != null)
				{
					textBoxName.Text = lt.Name; checkBoxIsTheory.Checked = lt.IsTheory;
					Text = "Редактирование типа занятия";
				}
			}
			else Text = "Добавление типа занятия";
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxName.Text))
			{
				MessageBox.Show("Введите название!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			var entity = LessonType.CreateEntity(_id, textBoxName.Text.Trim(), checkBoxIsTheory.Checked);
			if (_id == 0) _repository.Create(entity); else _repository.Update(entity);

			DialogResult = DialogResult.OK; Close();
		}
	}
}