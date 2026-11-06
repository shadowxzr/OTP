using System;
using System.Windows.Forms;
using DrivingSchool.Entities;
using DrivingSchool.Repositories.Interfaces;

namespace DrivingSchool.Forms
{
	public partial class LessonAddForm : Form
	{
		private readonly ILessonRepository _repository;
		private readonly ILessonTypeRepository _typeRepository;
		private readonly IInstructorRepository _instructorRepository;
		private readonly IStudyGroupRepository _groupRepository;

		public LessonAddForm(ILessonRepository repository, ILessonTypeRepository typeRepository,
							 IInstructorRepository instructorRepository, IStudyGroupRepository groupRepository)
		{
			InitializeComponent();
			_repository = repository; _typeRepository = typeRepository;
			_instructorRepository = instructorRepository; _groupRepository = groupRepository;
		}

		private void LessonAddForm_Load(object sender, EventArgs e)
		{
			comboBoxLessonType.DataSource = _typeRepository.ReadAll(); comboBoxLessonType.DisplayMember = "Name"; comboBoxLessonType.ValueMember = "Id";
			comboBoxInstructor.DataSource = _instructorRepository.ReadAll(); comboBoxInstructor.DisplayMember = "LastName"; comboBoxInstructor.ValueMember = "Id";
			comboBoxGroup.DataSource = _groupRepository.ReadAll(); comboBoxGroup.DisplayMember = "Name"; comboBoxGroup.ValueMember = "Id";
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (comboBoxLessonType.SelectedValue == null || comboBoxInstructor.SelectedValue == null || comboBoxGroup.SelectedValue == null)
			{
				MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
			}

			var entity = Lesson.CreateEntity(0, dateTimePickerDate.Value,
				(int)comboBoxLessonType.SelectedValue, (int)comboBoxInstructor.SelectedValue, (int)comboBoxGroup.SelectedValue);
			_repository.Create(entity);

			DialogResult = DialogResult.OK; Close();
		}
	}
}