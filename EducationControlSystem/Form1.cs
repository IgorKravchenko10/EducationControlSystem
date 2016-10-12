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
            LoadData();
        }

        public void LoadData()
        {
            List<PrxStudent> students = DatabaseQueries.StudentsAdapter.GetStudents(EduContext);
            bndStudents.DataSource = students;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateNodeContextMenu();

            TreeNode rootTreeNode = new TreeNode("Education Control System");
            treeView1.Nodes.Add(rootTreeNode);

            TreeNode studentsTreeNode = new TreeNode("Студенти");
            studentsTreeNode.ContextMenu = _NodeStudentContextMenu;
            rootTreeNode.Nodes.Add(studentsTreeNode);

            TreeNode studyGroupsTreeNode = new TreeNode("Навчальні групи");
            rootTreeNode.Nodes.Add(studyGroupsTreeNode);

            TreeNode subjectsTreeNode = new TreeNode("Предмети");
            rootTreeNode.Nodes.Add(subjectsTreeNode);

            TreeNode teachersTreeNode = new TreeNode("Викладачі");
            rootTreeNode.Nodes.Add(teachersTreeNode);

            TreeNode additionalCoursesTreeNode = new TreeNode("Додаткові курси");
            rootTreeNode.Nodes.Add(additionalCoursesTreeNode);
        }

        private ContextMenu _NodeStudentContextMenu;
        /// <summary>
        /// Создаём контекстное меню для узлов задач
        /// </summary>
        private void CreateNodeContextMenu()
        {
            _NodeStudentContextMenu = new ContextMenu();

            MenuItem createMenuItem = new MenuItem("Додати студента");
            createMenuItem.Click += new EventHandler(NewStudentMenuItem_Click);
            _NodeStudentContextMenu.MenuItems.Add(createMenuItem);

            MenuItem deleteMenuItem = new MenuItem("Видалити студента");
            _NodeStudentContextMenu.MenuItems.Add(deleteMenuItem);
        }

        private void NewStudentMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudent frmAddStudent = new FrmAddStudent();
            frmAddStudent.Show();
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
