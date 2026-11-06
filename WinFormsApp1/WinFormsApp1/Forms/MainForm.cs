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

		private void ÊàòåãîðèèToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<CategoryListForm>().ShowDialog();
		private void ÈíñòðóêòîðûToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<InstructorListForm>().ShowDialog();
		private void ÒèïûÇàíÿòèéToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<LessonTypeListForm>().ShowDialog();
		private void ÃðóïïûToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<StudyGroupListForm>().ShowDialog();
		private void ÇàíÿòèÿToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<LessonListForm>().ShowDialog();
		private void ÝêçàìåíûToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<ExamListForm>().ShowDialog();
		private void ÎïëàòûToolStripMenuItem_Click(object sender, EventArgs e) => _scope.Resolve<PaymentListForm>().ShowDialog();
	}
}