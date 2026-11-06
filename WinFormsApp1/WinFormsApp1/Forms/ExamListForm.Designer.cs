namespace DrivingSchool.Forms
{
	partial class ExamListForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button buttonAdd;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dataGridView = new System.Windows.Forms.DataGridView(); this.buttonAdd = new System.Windows.Forms.Button();

			this.dataGridView.Location = new System.Drawing.Point(12, 12); this.dataGridView.Size = new System.Drawing.Size(560, 300); this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.buttonAdd.Location = new System.Drawing.Point(12, 320); this.buttonAdd.Size = new System.Drawing.Size(150, 30); this.buttonAdd.Text = "Добавить экзамен";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.dataGridView); this.Controls.Add(this.buttonAdd);
			this.Text = "Операции: Экзамены";
			this.Load += new System.EventHandler(this.ExamListForm_Load);
		}
	}
}