using DrivingSchool.Entities;
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
			checkedListBoxExamType.Items.Clear();
			checkedListBoxExamType.Items.Add("Теория");
			checkedListBoxExamType.Items.Add("Вождение");
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxStudentId.Text))
			{
				MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			if (!int.TryParse(textBoxStudentId.Text, out int studentId))
			{
				MessageBox.Show("ID студента должен быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			ExamType examType = ExamType.None;
			if (checkedListBoxExamType.GetItemChecked(0)) examType |= ExamType.Theory;
			if (checkedListBoxExamType.GetItemChecked(1)) examType |= ExamType.Driving;

			if (examType == ExamType.None)
			{
				MessageBox.Show("Выберите хотя бы один тип экзамена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			var entity = Exam.CreateEntity(0, studentId, dateTimePickerDate.Value, examType, (int)numericUpDownGrade.Value);
			_repository.Create(entity);

			DialogResult = DialogResult.OK; Close();
		}
	}
}