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
    public partial class FrmAddStudyGroup : Form
    {
        public FrmAddStudyGroup()
        {
            InitializeComponent();
        }

        private void FrmAddStudyGroup_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        public void FillComboBox()
        {
            EduContext eduContext = new EduContext();
            List<PrxTeacher> teachers = DatabaseQueries.TeacherAdapter.GetList(eduContext);

            cmbTeachers.DataSource = teachers;
            cmbTeachers.ValueMember = "Id";
            cmbTeachers.DisplayMember = "Name";
        }

        public void AddToDatabase()
        {
            StudyGroup studyGroup = new StudyGroup()
            {
                GroupName = txtBoxName.Text,
                TeacherId = (int)cmbTeachers.SelectedValue
            };
            EduContext eduContext = new EduContext();
            eduContext.StudyGroups.Add(studyGroup);
            eduContext.SaveChanges();

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            AddToDatabase();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
