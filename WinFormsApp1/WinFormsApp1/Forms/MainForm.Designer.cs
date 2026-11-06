namespace DrivingSchool.Forms
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem инструкторыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem типыЗанятийToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem занятияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem экзаменыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оплатыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.инструкторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.типыЗанятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.занятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.экзаменыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

			// menuStrip
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.справочникиToolStripMenuItem,
				this.операцииToolStripMenuItem,
				this.отчетыToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 24);

			// Справочники
			this.справочникиToolStripMenuItem.Text = "Справочники";
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.категорииToolStripMenuItem, this.инструкторыToolStripMenuItem,
				this.типыЗанятийToolStripMenuItem, this.группыToolStripMenuItem});

			this.категорииToolStripMenuItem.Text = "Категории";
			this.категорииToolStripMenuItem.Click += new System.EventHandler(this.КатегорииToolStripMenuItem_Click);

			this.инструкторыToolStripMenuItem.Text = "Инструкторы";
			this.инструкторыToolStripMenuItem.Click += new System.EventHandler(this.ИнструкторыToolStripMenuItem_Click);

			this.типыЗанятийToolStripMenuItem.Text = "Типы занятий";
			this.типыЗанятийToolStripMenuItem.Click += new System.EventHandler(this.ТипыЗанятийToolStripMenuItem_Click);

			this.группыToolStripMenuItem.Text = "Учебные группы";
			this.группыToolStripMenuItem.Click += new System.EventHandler(this.ГруппыToolStripMenuItem_Click);

			// Операции
			this.операцииToolStripMenuItem.Text = "Операции";
			this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.занятияToolStripMenuItem, this.экзаменыToolStripMenuItem, this.оплатыToolStripMenuItem});

			this.занятияToolStripMenuItem.Text = "Занятия";
			this.занятияToolStripMenuItem.Click += new System.EventHandler(this.ЗанятияToolStripMenuItem_Click);

			this.экзаменыToolStripMenuItem.Text = "Экзамены";
			this.экзаменыToolStripMenuItem.Click += new System.EventHandler(this.ЭкзаменыToolStripMenuItem_Click);

			this.оплатыToolStripMenuItem.Text = "Оплаты";
			this.оплатыToolStripMenuItem.Click += new System.EventHandler(this.ОплатыToolStripMenuItem_Click);

			// Отчеты
			this.отчетыToolStripMenuItem.Text = "Отчеты";

			// MainForm
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip); // <-- ВОТ ЭТА СТРОКА ДОБАВЛЯЕТ МЕНЮ НА ФОРМУ
			this.MainMenuStrip = this.menuStrip;
			this.Text = "Автошкола - Главное меню";
		}
	}
}