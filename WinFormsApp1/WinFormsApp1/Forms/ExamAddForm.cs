using DrivingSchool.Entities;
using DrivingSchool.Entities.Enums;
using DrivingSchool.Entities.Enums.Entities.Enums;
using DrivingSchool.Repositories.Interfaces;
using System;
using System.Windows.Forms;

namespace DrivingSchool.Forms
{
	public partial class ExamAddForm : Form
	{
		private readonly IExamRepository _repository;

		public ExamAddForm(IExamRepository repository)
		{
			InitializeComponent(); _repository = repository;
		}

		private void ExamAddForm_Load(object sender, EventArgs e)
		{
			comboBoxExamType.DataSource = Enum.GetValues(typeof(ExamType));
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxStudentId.Text) || comboBoxExamType.SelectedItem == null)
			{
				MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			if (!int.TryParse(textBoxStudentId.Text, out int studentId))
			{
				MessageBox.Show("ID студента должен быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			var entity = Exam.CreateEntity(0, studentId, dateTimePickerDate.Value, (ExamType)comboBoxExamType.SelectedItem, (int)numericUpDownGrade.Value);
			_repository.Create(entity);

			DialogResult = DialogResult.OK; Close();
		}
	}
}