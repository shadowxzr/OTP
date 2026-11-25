namespace DrivingSchool.Forms
{
	partial class ExamAddForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.NumericUpDown numericUpDownGrade;
		private System.Windows.Forms.TextBox textBoxStudentId;
		private System.Windows.Forms.CheckedListBox checkedListBoxExamType;
		private System.Windows.Forms.Label label1, label2, label3, label4;
		private System.Windows.Forms.Button buttonSave;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
			this.textBoxStudentId = new System.Windows.Forms.TextBox();
			this.checkedListBoxExamType = new System.Windows.Forms.CheckedListBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();

			this.label1.Text = "Дата:"; this.label1.Location = new System.Drawing.Point(12, 15);
			this.label2.Text = "ID Студента:"; this.label2.Location = new System.Drawing.Point(12, 45);
			this.label3.Text = "Тип экзамена:"; this.label3.Location = new System.Drawing.Point(12, 75);
			this.label4.Text = "Оценка:"; this.label4.Location = new System.Drawing.Point(12, 135);
			foreach (var lbl in new[] { label1, label2, label3, label4 }) lbl.Size = new System.Drawing.Size(100, 20);

			this.dateTimePickerDate.Location = new System.Drawing.Point(118, 12); this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
			this.textBoxStudentId.Location = new System.Drawing.Point(118, 42); this.textBoxStudentId.Size = new System.Drawing.Size(200, 20);

			this.checkedListBoxExamType.Location = new System.Drawing.Point(118, 72);
			this.checkedListBoxExamType.Size = new System.Drawing.Size(200, 45);
			this.checkedListBoxExamType.CheckOnClick = true;

			this.numericUpDownGrade.Location = new System.Drawing.Point(118, 132); this.numericUpDownGrade.Size = new System.Drawing.Size(100, 20); this.numericUpDownGrade.Maximum = 5;

			this.buttonSave.Location = new System.Drawing.Point(118, 170); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

			this.ClientSize = new System.Drawing.Size(340, 220);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { label1, label2, label3, label4, dateTimePickerDate, textBoxStudentId, checkedListBoxExamType, numericUpDownGrade, buttonSave });
			this.Text = "Добавление экзамена";
			this.Load += new System.EventHandler(this.ExamAddForm_Load);
		}
	}
}