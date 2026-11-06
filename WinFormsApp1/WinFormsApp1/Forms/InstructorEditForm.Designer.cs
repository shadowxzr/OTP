namespace DrivingSchool.Forms
{
	partial class InstructorEditForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxFirstName, textBoxLastName, textBoxPhone;
		private System.Windows.Forms.NumericUpDown numericUpDownExperience;
		private System.Windows.Forms.Label label1, label2, label3, label4;
		private System.Windows.Forms.Button buttonSave;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.textBoxFirstName = new System.Windows.Forms.TextBox(); this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.textBoxPhone = new System.Windows.Forms.TextBox(); this.numericUpDownExperience = new System.Windows.Forms.NumericUpDown();
			this.buttonSave = new System.Windows.Forms.Button(); this.label1 = new System.Windows.Forms.Label(); this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label(); this.label4 = new System.Windows.Forms.Label();

			this.label1.Text = "Имя:"; this.label1.Location = new System.Drawing.Point(12, 15);
			this.label2.Text = "Фамилия:"; this.label2.Location = new System.Drawing.Point(12, 45);
			this.label3.Text = "Телефон:"; this.label3.Location = new System.Drawing.Point(12, 75);
			this.label4.Text = "Стаж (лет):"; this.label4.Location = new System.Drawing.Point(12, 105);
			foreach (var lbl in new[] { label1, label2, label3, label4 }) lbl.Size = new System.Drawing.Size(80, 20);

			this.textBoxFirstName.Location = new System.Drawing.Point(100, 12); this.textBoxFirstName.Size = new System.Drawing.Size(200, 20);
			this.textBoxLastName.Location = new System.Drawing.Point(100, 42); this.textBoxLastName.Size = new System.Drawing.Size(200, 20);
			this.textBoxPhone.Location = new System.Drawing.Point(100, 72); this.textBoxPhone.Size = new System.Drawing.Size(200, 20);
			this.numericUpDownExperience.Location = new System.Drawing.Point(100, 102); this.numericUpDownExperience.Size = new System.Drawing.Size(100, 20); this.numericUpDownExperience.Maximum = 50;

			this.buttonSave.Location = new System.Drawing.Point(100, 140); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

			this.ClientSize = new System.Drawing.Size(330, 190);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { label1, label2, label3, label4, textBoxFirstName, textBoxLastName, textBoxPhone, numericUpDownExperience, buttonSave });
			this.Text = "Инструктор";
			this.Load += new System.EventHandler(this.InstructorEditForm_Load);
		}
	}
}