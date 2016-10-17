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

namespace EducationControlSystem
{
    public partial class FrmAddAdditionalCourse : Form
    {
        public FrmAddAdditionalCourse()
        {
            InitializeComponent();
        }

        private void FrmAddAdditionalCourse_Load(object sender, EventArgs e)
        {
            EduContext eduContext = new EduContext();
            FillTeachers(eduContext);
            FillSubjects(eduContext);
        }

        public void FillTeachers(EduContext eduContext)
        {
            List<PrxTeacher> teachers = TeacherAdapter.GetList(eduContext);

            cmbTeachers.DataSource = teachers;
            cmbTeachers.ValueMember = "Id";
            cmbTeachers.DisplayMember = "Name";

        }
        public void FillSubjects(EduContext eduContext)
        {
            List<PrxSubject> subjects = SubjectsAdapter.GetList(eduContext);

            cmbSubjects.DataSource = subjects;
            cmbSubjects.ValueMember = "Id";
            cmbSubjects.DisplayMember = "Name";

        }

        public void AddAdditionalCourse()
        {
            AdditionalCourse additionalCourse = new AdditionalCourse()
            {
                AdditionalCourseName = txtBoxName.Text,
                SubjectId = (int)cmbSubjects.SelectedValue,
                TeacherId = (int)cmbTeachers.SelectedValue,
                StudyCourse = (int)numericUpDown1.Value
            };
            EduContext educontext = new EduContext();

            educontext.AdditionalCourses.Add(additionalCourse);
            educontext.SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AddAdditionalCourse();
        }
    }
}
