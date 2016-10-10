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
    public partial class FrmAddStudent : Form
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
            foreach (var item in studyGroups)
            {
                cmdStudyGroups.DataSource = item;
            }
            cmdStudyGroups.DataSource = studyGroups;
            cmdStudyGroups.ValueMember = "Id";
            cmdStudyGroups.DisplayMember = "Name";
            
        }

        private void cmdStudyGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void AddToDatabase()
        {
            Student student = new Student();
            student.StudentName = txtBoxName.Text;
            student.DateOfBirth = dateTimePickerBirth.Value;
            student.YearEntry = Convert.ToInt32(txtBoxYearEntry.Text);
            student.PhoneNumber = txtBoxPhoneNumber.Text;
            student.StudyGroup = (StudyGroup)cmdStudyGroups.SelectedItem;
            student.IsAbroad = checkBoxIsAbroad.Checked;
            student.IsContract = checkBoxOnContract.Checked;
            student.IsLeader = checkBoxIsLeader.Checked;
            EduContext educontext = new EduContext();

            educontext.Students.Add(student);
            educontext.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddToDatabase();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
