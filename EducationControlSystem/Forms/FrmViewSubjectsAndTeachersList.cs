using EducationControlSystem.DatabaseQueries;
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
    public partial class FrmViewSubjectsAndTeachersList : Form
    {
        public int SubjectId { get; set; }

        public int TeacherId { get; set; }

        public FrmViewSubjectsAndTeachersList()
        {
            InitializeComponent();
        }

        private void FrmViewSubjectsAndTeachersList_Load(object sender, EventArgs e)
        {
            EduContext eduContext = new EduContext();
            FillTeachers(eduContext);
            FillSubjects(eduContext);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveId();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTeachers(EduContext eduContext)
        {
            List<PrxTeacher> teachers = TeacherAdapter.GetList(eduContext);

            cmbTeachers.DataSource = teachers;
            cmbTeachers.ValueMember = "Id";
            cmbTeachers.DisplayMember = "Name";

        }
        private void FillSubjects(EduContext eduContext)
        {
            List<PrxSubject> subjects = SubjectsAdapter.GetList(eduContext);

            cmbSubjects.DataSource = subjects;
            cmbSubjects.ValueMember = "Id";
            cmbSubjects.DisplayMember = "Name";
        }

        private void SaveId()
        {
            SubjectId = (int)cmbSubjects.SelectedValue;
            TeacherId = (int)cmbTeachers.SelectedValue;
        }

    }
}
