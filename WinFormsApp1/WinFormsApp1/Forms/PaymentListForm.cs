using System;
using System.Windows.Forms;
using Autofac;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class PaymentListForm : Form
	{
		private readonly IPaymentRepository _repository;
		private readonly ILifetimeScope _scope;

		public PaymentListForm(IPaymentRepository repository, ILifetimeScope scope)
		{
			InitializeComponent(); _repository = repository; _scope = scope;
		}

		private void PaymentListForm_Load(object sender, EventArgs e) => LoadData();
		private void LoadData() => dataGridView.DataSource = _repository.ReadAll();

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var form = _scope.Resolve<PaymentAddForm>();
			if (form.ShowDialog() == DialogResult.OK) LoadData();
		}
	}
}