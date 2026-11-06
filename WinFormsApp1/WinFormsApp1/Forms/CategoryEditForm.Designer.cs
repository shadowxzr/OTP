namespace DrivingSchool.Forms
{
	partial class CategoryEditForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonSave;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();

			this.labelName.Location = new System.Drawing.Point(12, 15); this.labelName.Size = new System.Drawing.Size(100, 20); this.labelName.Text = "Название:";
			this.textBoxName.Location = new System.Drawing.Point(118, 12); this.textBoxName.Size = new System.Drawing.Size(200, 20);
			this.buttonSave.Location = new System.Drawing.Point(118, 50); this.buttonSave.Size = new System.Drawing.Size(100, 30); this.buttonSave.Text = "Сохранить";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

			this.ClientSize = new System.Drawing.Size(340, 100);
			this.Controls.Add(this.labelName); this.Controls.Add(this.textBoxName); this.Controls.Add(this.buttonSave);
			this.Text = "Категория";
			this.Load += new System.EventHandler(this.CategoryEditForm_Load);
		}
	}
}