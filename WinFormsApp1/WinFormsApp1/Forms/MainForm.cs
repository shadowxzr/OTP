using System;
using System.Windows.Forms;
using Autofac;

namespace DrivingSchool.Forms
{
	public partial class MainForm : Form
	{
		private readonly ILifetimeScope _scope;

		public MainForm(ILifetimeScope scope)
		{
			InitializeComponent();
			_scope = scope ?? throw new ArgumentNullException(nameof(scope));
		}

		private void КатегорииToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<CategoryListForm>().ShowDialog();
		private void ИнструкторыToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<InstructorListForm>().ShowDialog();
		private void ТипыЗанятийToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<LessonTypeListForm>().ShowDialog();
		private void ГруппыToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<StudyGroupListForm>().ShowDialog();
		private void ЗанятияToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<LessonListForm>().ShowDialog();
		private void ЭкзаменыToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<ExamListForm>().ShowDialog();
		private void ОплатыToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<PaymentListForm>().ShowDialog();
	}
}