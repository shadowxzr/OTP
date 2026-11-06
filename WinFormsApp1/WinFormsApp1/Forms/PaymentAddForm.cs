using System;
using System.Windows.Forms;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class PaymentAddForm : Form
	{
		private readonly IPaymentRepository _repository;

		public PaymentAddForm(IPaymentRepository repository)
		{
			InitializeComponent(); _repository = repository;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxStudentId.Text) || numericUpDownAmount.Value <= 0)
			{
				MessageBox.Show("Заполните все поля и укажите сумму больше нуля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			if (!int.TryParse(textBoxStudentId.Text, out int studentId))
			{
				MessageBox.Show("ID студента должен быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			var entity = Payment.CreateEntity(0, studentId, numericUpDownAmount.Value, dateTimePickerDate.Value);
			_repository.Create(entity);

			DialogResult = DialogResult.OK; Close();
		}
	}
}