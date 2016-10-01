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
    public partial class Form1 : Form
    {
        public EduContext EduContext = new EduContext();

        public Form1()
        {
            InitializeComponent();
            List<PrxStudent> students = DatabaseQueries.StudentsAdapter.GetStudents(EduContext);
            List<PrxStudent> studentsList = DatabaseQueries.StudentsAdapter.GetListOfGroup(EduContext, 3);
            List<PrxAdditionalCourse> additionalCourses = DatabaseQueries.AdditionalCoursesAdapter.GetAdditionalCourses(EduContext);
            bndStudents.DataSource = additionalCourses;
        }

        public void AddToDatabase()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode rootTreeNode = new TreeNode("Education Control System");
            treeView1.Nodes.Add(rootTreeNode);

            TreeNode studentsTreeNode = new TreeNode("Students");
            rootTreeNode.Nodes.Add(studentsTreeNode);

            TreeNode subjectsTreeNode = new TreeNode("Study groups");
            rootTreeNode.Nodes.Add(subjectsTreeNode);

            TreeNode additionalCoursesTreeNode = new TreeNode("Additional courses");
            rootTreeNode.Nodes.Add(additionalCoursesTreeNode);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SetGridVisible(grvStudents);
        }

        private void SetGridVisible(DataGridView dataGridView)
        {
            this.grvStudents.Dock = DockStyle.Fill;
            this.grvSubjects.Dock = DockStyle.Fill;
            this.grvStudents.Visible = (dataGridView == this.grvStudents);
            this.grvSubjects.Visible = (dataGridView == this.grvSubjects);
        }
    }
}
