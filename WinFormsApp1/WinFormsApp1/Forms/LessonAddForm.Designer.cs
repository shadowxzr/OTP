namespace DrivingSchool.Forms
{
	partial class LessonAddForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.ComboBox comboBoxLessonType, comboBoxInstructor, comboBoxGroup;
		private System.Windows.Forms.Label label1, label2, label3, label4;
		private System.Windows.Forms.Button buttonSave;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker(); this.comboBoxLessonType = new System.Windows.Forms.ComboBox();
			this.comboBoxInstructor = new System.Windows.Forms.ComboBox(); this.comboBoxGroup = new System.Windows.Forms.ComboBox();
			this.buttonSave = new System.Windows.Forms.Button(); this.label1 = new System.Windows.Forms.Label(); this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label(); this.label4 = new System.Windows.Forms.Label();

			this.label1.Text = "Дата:"; this.label1.Location = new System.Drawing.Point(12, 15);
			this.label2.Text = "Тип занятия:"; this.label2.Location = new System.Drawing.Point(12, 45);
			this.label3.Text = "Инструктор:"; this.label3.Location = new System.Drawing.Point(12, 75);
			this.label4.Text = "Группа:"; this.label4.Location = new System.Drawing.Point(12, 105);
			foreach (var lbl in new[] { label1, label2, label3, label4 }) lbl.Size = new System.Drawing.Size(100, 20);

			this.dateTimePickerDate.Location = new System.Drawing.Point(118, 12); this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
			this.comboBoxLessonType.Location = new System.Drawing.Point(118, 42); this.comboBoxLessonType.Size = new System.Drawing.Size(200, 20); this.comboBoxLessonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxInstructor.Location = new System.Drawing.Point(118, 72); this.comboBoxInstructor.Size = new System.Drawing.Size(200, 20); this.comboBoxInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroup.Location = new System.Drawing.Point(118, 102); this.comboBoxGroup.Size = new System.Drawing.Size(200, 20); this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.buttonSave.Location = new System.Drawing.Point(118, 140); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

			this.ClientSize = new System.Drawing.Size(340, 190);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { label1, label2, label3, label4, dateTimePickerDate, comboBoxLessonType, comboBoxInstructor, comboBoxGroup, buttonSave });
			this.Text = "Добавление занятия";
			this.Load += new System.EventHandler(this.LessonAddForm_Load);
		}
	}
}