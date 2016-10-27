using EducationControlSystem.DatabaseQueries;
using EducationControlSystem.DataObjects;
using EducationControlSystem.ProxyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationControlSystem
{
    public partial class FrmAddStudent : DevExpress.XtraEditors.XtraForm
    {
        public bool NeedUpdate { get; set; } = false;

        public PrxStudent PrxStudent { get; set; }

        public EduContext EduContext { get; set; } = new EduContext();

        public FrmAddStudent()
        {
            InitializeComponent();
        }

        public FrmAddStudent(int id)
        {
            InitializeComponent();

            PrxStudent = DatabaseQueries.StudentsAdapter.GetItemProxy(EduContext, id);

            FillComboBox();

            this.txtBoxName.Text = PrxStudent.Name;
            this.dateTimePickerBirth.Value = PrxStudent.DateOfBirth;
            this.txtBoxYearEntry.Text = PrxStudent.YearEntry.ToString();
            this.txtBoxPhoneNumber.Text = PrxStudent.PhoneNumber;
            this.cmbStudyGroups.SelectedValue = PrxStudent.StudyGroup.Id;
            this.checkBoxIsAbroad.Checked = PrxStudent.IsAbroad;
            this.checkBoxOnContract.Checked = PrxStudent.IsContract;
            this.checkBoxIsLeader.Checked = PrxStudent.IsLeader;

            NeedUpdate = true;
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        public void FillComboBox()
        {
            List<PrxStudyGroup> studyGroups = StudyGroupsAdapter.GetStudyGroupsBySql();

            cmbStudyGroups.DataSource = studyGroups;
            cmbStudyGroups.ValueMember = "Id";
            cmbStudyGroups.DisplayMember = "Name";
        }

        private void UpdateStudent()
        {
            Student student = DatabaseQueries.StudentsAdapter.GetItem(EduContext, PrxStudent.Id);
            
            student.StudentName = txtBoxName.Text;
            student.DateOfBirth = dateTimePickerBirth.Value;
            student.YearEntry = Convert.ToInt32(txtBoxYearEntry.Text);
            student.PhoneNumber = txtBoxPhoneNumber.Text;
            student.StudyGroupId = (int)cmbStudyGroups.SelectedValue;
            student.IsAbroad = checkBoxIsAbroad.Checked;
            student.IsContract = checkBoxOnContract.Checked;
            student.IsLeader = checkBoxIsLeader.Checked;

            EduContext.SaveChanges();
        }

        private Student Create()
        {
            
            Student student = new Student()
            {
                StudentName = txtBoxName.Text,
                DateOfBirth = dateTimePickerBirth.Value,
                YearEntry = Convert.ToInt32(txtBoxYearEntry.Text),
                PhoneNumber = txtBoxPhoneNumber.Text,
                StudyGroupId = (int)cmbStudyGroups.SelectedValue,
                IsAbroad = checkBoxIsAbroad.Checked,
                IsContract = checkBoxOnContract.Checked,
                IsLeader = checkBoxIsLeader.Checked
            };

            return student;
        }

        public void AddToDatabase()
        {
            Student student = Create();

            EduContext.Students.Add(student);
            EduContext.SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (NeedUpdate)
            {
                UpdateStudent();
            }
            else
            {
                AddToDatabase();
            }

            this.Close();
        }
    }
}
