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
			menuStrip = new MenuStrip();
			справочникиToolStripMenuItem = new ToolStripMenuItem();
			категорииToolStripMenuItem = new ToolStripMenuItem();
			инструкторыToolStripMenuItem = new ToolStripMenuItem();
			типыЗанятийToolStripMenuItem = new ToolStripMenuItem();
			группыToolStripMenuItem = new ToolStripMenuItem();
			операцииToolStripMenuItem = new ToolStripMenuItem();
			занятияToolStripMenuItem = new ToolStripMenuItem();
			экзаменыToolStripMenuItem = new ToolStripMenuItem();
			оплатыToolStripMenuItem = new ToolStripMenuItem();
			отчетыToolStripMenuItem = new ToolStripMenuItem();
			menuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip
			// 
			menuStrip.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem, отчетыToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(800, 24);
			menuStrip.TabIndex = 0;
			// 
			// справочникиToolStripMenuItem
			// 
			справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { категорииToolStripMenuItem, инструкторыToolStripMenuItem, типыЗанятийToolStripMenuItem, группыToolStripMenuItem });
			справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			справочникиToolStripMenuItem.Size = new Size(94, 20);
			справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// категорииToolStripMenuItem
			// 
			категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
			категорииToolStripMenuItem.Size = new Size(167, 22);
			категорииToolStripMenuItem.Text = "Категории";
			категорииToolStripMenuItem.Click += КатегорииToolStripMenuItem_Click;
			// 
			// инструкторыToolStripMenuItem
			// 
			инструкторыToolStripMenuItem.Name = "инструкторыToolStripMenuItem";
			инструкторыToolStripMenuItem.Size = new Size(167, 22);
			инструкторыToolStripMenuItem.Text = "Инструкторы";
			инструкторыToolStripMenuItem.Click += ИнструкторыToolStripMenuItem_Click;
			// 
			// типыЗанятийToolStripMenuItem
			// 
			типыЗанятийToolStripMenuItem.Name = "типыЗанятийToolStripMenuItem";
			типыЗанятийToolStripMenuItem.Size = new Size(167, 22);
			типыЗанятийToolStripMenuItem.Text = "Типы занятий";
			типыЗанятийToolStripMenuItem.Click += ТипыЗанятийToolStripMenuItem_Click;
			// 
			// группыToolStripMenuItem
			// 
			группыToolStripMenuItem.Name = "группыToolStripMenuItem";
			группыToolStripMenuItem.Size = new Size(167, 22);
			группыToolStripMenuItem.Text = "Учебные группы";
			группыToolStripMenuItem.Click += ГруппыToolStripMenuItem_Click;
			// 
			// операцииToolStripMenuItem
			// 
			операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { занятияToolStripMenuItem, экзаменыToolStripMenuItem, оплатыToolStripMenuItem });
			операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
			операцииToolStripMenuItem.Size = new Size(75, 20);
			операцииToolStripMenuItem.Text = "Операции";
			// 
			// занятияToolStripMenuItem
			// 
			занятияToolStripMenuItem.Name = "занятияToolStripMenuItem";
			занятияToolStripMenuItem.Size = new Size(129, 22);
			занятияToolStripMenuItem.Text = "Занятия";
			занятияToolStripMenuItem.Click += ЗанятияToolStripMenuItem_Click;
			// 
			// экзаменыToolStripMenuItem
			// 
			экзаменыToolStripMenuItem.Name = "экзаменыToolStripMenuItem";
			экзаменыToolStripMenuItem.Size = new Size(129, 22);
			экзаменыToolStripMenuItem.Text = "Экзамены";
			экзаменыToolStripMenuItem.Click += ЭкзаменыToolStripMenuItem_Click;
			// 
			// оплатыToolStripMenuItem
			// 
			оплатыToolStripMenuItem.Name = "оплатыToolStripMenuItem";
			оплатыToolStripMenuItem.Size = new Size(129, 22);
			оплатыToolStripMenuItem.Text = "Оплаты";
			оплатыToolStripMenuItem.Click += ОплатыToolStripMenuItem_Click;
			// 
			// отчетыToolStripMenuItem
			// 
			отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
			отчетыToolStripMenuItem.Size = new Size(60, 20);
			отчетыToolStripMenuItem.Text = "Отчеты";
			// 
			// MainForm
			// 
			ClientSize = new Size(800, 450);
			Controls.Add(menuStrip);
			MainMenuStrip = menuStrip;
			Name = "MainForm";
			Text = "Автошкола - Главное меню";
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}