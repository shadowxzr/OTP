using System;
using System.Windows.Forms;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class InstructorEditForm : Form
	{
		private readonly IInstructorRepository _repository;
		private readonly int _id;

		public InstructorEditForm(IInstructorRepository repository, int id)
		{
			InitializeComponent(); _repository = repository; _id = id;
		}

		private void InstructorEditForm_Load(object sender, EventArgs e)
		{
			if (_id > 0)
			{
				var inst = _repository.ReadById(_id);
				if (inst != null)
				{
					textBoxFirstName.Text = inst.FirstName; textBoxLastName.Text = inst.LastName;
					textBoxPhone.Text = inst.Phone; numericUpDownExperience.Value = inst.ExperienceYears;
					Text = "Редактирование инструктора";
				}
			}
			else Text = "Добавление инструктора";
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || string.IsNullOrWhiteSpace(textBoxLastName.Text))
			{
				MessageBox.Show("Заполните ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var entity = Instructor.CreateEntity(_id, textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(), textBoxPhone.Text.Trim(), (int)numericUpDownExperience.Value);
			if (_id == 0) _repository.Create(entity); else _repository.Update(entity);

			DialogResult = DialogResult.OK; Close();
		}
	}
}