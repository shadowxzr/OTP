namespace DrivingSchool.Forms
{
	partial class CategoryListForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();

			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Size = new System.Drawing.Size(560, 300);
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

			this.buttonAdd.Location = new System.Drawing.Point(12, 320); this.buttonAdd.Size = new System.Drawing.Size(100, 30); this.buttonAdd.Text = "Добавить";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			this.buttonUpdate.Location = new System.Drawing.Point(120, 320); this.buttonUpdate.Size = new System.Drawing.Size(100, 30); this.buttonUpdate.Text = "Изменить";
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			this.buttonDelete.Location = new System.Drawing.Point(228, 320); this.buttonDelete.Size = new System.Drawing.Size(100, 30); this.buttonDelete.Text = "Удалить";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.dataGridView); this.Controls.Add(this.buttonAdd); this.Controls.Add(this.buttonUpdate); this.Controls.Add(this.buttonDelete);
			this.Text = "Справочник: Категории";
			this.Load += new System.EventHandler(this.CategoryListForm_Load);
		}
	}
}