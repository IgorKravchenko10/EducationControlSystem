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
    public partial class FrmViewSubjectsList : Form
    {
        public int SubjectId { get; set; }

        public FrmViewSubjectsList()
        {
            InitializeComponent();
        }

        private void FrmViewSubjectsList_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            List<PrxSubject> subjects = DatabaseQueries.SubjectsAdapter.GetListBySql();
            cmbStudyGroups.DataSource = subjects;
            cmbStudyGroups.ValueMember = "Id";
            cmbStudyGroups.DisplayMember = "Name";
        }

        private void SaveSubjectId()
        {
            SubjectId = (int)cmbStudyGroups.SelectedValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveSubjectId();
        }

        
    }
}
