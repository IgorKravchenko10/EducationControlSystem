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
    public partial class FrmViewStudyGroupList : Form
    {
        public int StudyGroupId { get; set; }

        public FrmViewStudyGroupList()
        {
            InitializeComponent();
        }

        private void FrmViewStudyGroupList_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            List<PrxStudyGroup> studyGroups = DatabaseQueries.StudyGroupsAdapter.GetStudyGroupsBySql();
            cmbStudyGroups.DataSource = studyGroups;
            cmbStudyGroups.ValueMember = "Id";
            cmbStudyGroups.DisplayMember = "Name";
        }

        private void SaveGroupId()
        {
            StudyGroupId = (int)cmbStudyGroups.SelectedValue;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveGroupId();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
