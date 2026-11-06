namespace DrivingSchool.Forms
{
	partial class PaymentAddForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.NumericUpDown numericUpDownAmount;
		private System.Windows.Forms.TextBox textBoxStudentId;
		private System.Windows.Forms.Label label1, label2, label3;
		private System.Windows.Forms.Button buttonSave;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker(); this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
			this.textBoxStudentId = new System.Windows.Forms.TextBox(); this.buttonSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label(); this.label2 = new System.Windows.Forms.Label(); this.label3 = new System.Windows.Forms.Label();

			this.label1.Text = "Дата:"; this.label1.Location = new System.Drawing.Point(12, 15);
			this.label2.Text = "ID Студента:"; this.label2.Location = new System.Drawing.Point(12, 45);
			this.label3.Text = "Сумма:"; this.label3.Location = new System.Drawing.Point(12, 75);
			foreach (var lbl in new[] { label1, label2, label3 }) lbl.Size = new System.Drawing.Size(100, 20);

			this.dateTimePickerDate.Location = new System.Drawing.Point(118, 12); this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
			this.textBoxStudentId.Location = new System.Drawing.Point(118, 42); this.textBoxStudentId.Size = new System.Drawing.Size(200, 20);
			this.numericUpDownAmount.Location = new System.Drawing.Point(118, 72); this.numericUpDownAmount.Size = new System.Drawing.Size(200, 20);
			this.numericUpDownAmount.DecimalPlaces = 2; this.numericUpDownAmount.Maximum = 1000000;

			this.buttonSave.Location = new System.Drawing.Point(118, 110); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

			this.ClientSize = new System.Drawing.Size(340, 160);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { label1, label2, label3, dateTimePickerDate, textBoxStudentId, numericUpDownAmount, buttonSave });
			this.Text = "Добавление оплаты";
		}
	}
}