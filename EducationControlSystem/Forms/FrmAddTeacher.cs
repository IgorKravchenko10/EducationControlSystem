using EducationControlSystem.DataObjects;
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
    public partial class FrmAddTeacher : Form
    {
        public FrmAddTeacher()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AddTeacher();
        }

        private void AddTeacher()
        {
            Teacher teacher = new Teacher()
            {
                TeacherName = txtBoxName.Text,
                Phone = txtPhoneNumber.Text
            };

            EduContext eduContext = new EduContext();
            eduContext.Teachers.Add(teacher);
            eduContext.SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
