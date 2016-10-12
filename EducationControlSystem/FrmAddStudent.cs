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
    public partial class FrmAddStudent : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            FillComboBox();
            
        }

        public void FillComboBox()
        {
            List<PrxStudyGroup> studyGroups = StudyGroupsAdapter.GetStudyGroupsBySql();

            cmdStudyGroups.DataSource = studyGroups;
            cmdStudyGroups.ValueMember = "Id";
            cmdStudyGroups.DisplayMember = "Name";
            
        }

        public void AddToDatabase()
        {
            Student student = new Student();
            student.StudentName = txtBoxName.Text;
            student.DateOfBirth = dateTimePickerBirth.Value;
            student.YearEntry = Convert.ToInt32(txtBoxYearEntry.Text);
            student.PhoneNumber = txtBoxPhoneNumber.Text;
            student.StudyGroupId = (int)cmdStudyGroups.SelectedValue;
            student.IsAbroad = checkBoxIsAbroad.Checked;
            student.IsContract = checkBoxOnContract.Checked;
            student.IsLeader = checkBoxIsLeader.Checked;
            EduContext educontext = new EduContext();

            educontext.Students.Add(student);
            educontext.SaveChanges();
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                AddToDatabase();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Будь ласка, заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
