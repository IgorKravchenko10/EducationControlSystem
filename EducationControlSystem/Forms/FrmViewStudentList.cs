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
    public partial class FrmViewStudentList : Form
    {
        public int StudentId { get; set; }

        public FrmViewStudentList()
        {
            InitializeComponent();
        }

        private void FrmViewStudentList_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            List<PrxStudent> students = DatabaseQueries.StudentsAdapter.GetListBySql();
            cmbStudent.DataSource = students;
            cmbStudent.ValueMember = "Id";
            cmbStudent.DisplayMember = "Name";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StudentId = (int)cmbStudent.SelectedValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
