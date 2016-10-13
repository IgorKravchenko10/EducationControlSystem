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
    public partial class FrmAddSubject : Form
    {
        public FrmAddSubject()
        {
            InitializeComponent();
        }

        public void AddToDatabase()
        {
            Subject subject = new Subject()
            {
                SubjectName = txtBoxName.Text
            };

            EduContext eduContext = new EduContext();
            eduContext.Subjects.Add(subject);
            eduContext.SaveChanges();
        } 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            AddToDatabase();
            this.Close();
        }
    }
}
