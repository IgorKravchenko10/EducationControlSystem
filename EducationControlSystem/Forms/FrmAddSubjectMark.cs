using EducationControlSystem.DatabaseQueries;
using EducationControlSystem.DataObjects;
using EducationControlSystem.ProxyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationControlSystem.Forms
{
    public partial class FrmAddSubjectMark : Form
    {
        public FrmAddSubjectMark()
        {
            InitializeComponent();
        }

        private void FrmAddSubjectMark_Load(object sender, EventArgs e)
        {
            FillStates();
            FillStudents();
            FillSubjects();
        }

        private void FillStates()
        {
            cmbState.DataSource = Enum.GetValues(typeof(SubjectState));
        }

        private void FillStudents()
        {
            List<PrxStudent> students = DatabaseQueries.StudentsAdapter.GetListBySql();
            cmbStudent.DataSource = students;
            cmbStudent.ValueMember = "Id";
            cmbStudent.DisplayMember = "Name";
        }

        private void FillSubjects()
        {
            List<PrxSubject> subjects = DatabaseQueries.SubjectsAdapter.GetListBySql();
            cmbSubject.DataSource = subjects;
            cmbSubject.ValueMember = "Id";
            cmbSubject.DisplayMember = "Name";
        }

        private void AddToDatabase()
        {
            SubjectMark subjectMark = new SubjectMark()
            {
                Mark = Convert.ToInt32(txtBoxMark.Text),
                StudentId = (int)cmbStudent.SelectedValue,
                SubjectId = (int)cmbSubject.SelectedValue,
                State = (int)cmbState.SelectedValue,
                Semester = (int)numericUpDown1.Value,
                IsExam = checkBoxIsExam.Checked
            };

            EduContext eduContext = new EduContext();
            eduContext.SubjectMarks.Add(subjectMark);
            eduContext.SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AddToDatabase();
        }
    }
}
