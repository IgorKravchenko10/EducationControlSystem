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
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public EduContext EduContext = new EduContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTree();
            LoadData();

        }

        private enum GroupTreeNodeTypeEnum
        {
            Students,
            Subjects,
            Teachers,
            StudyGroups,
            AdditionalCourses
        }

        private class GroupTreeNode
        {
            public GroupTreeNodeTypeEnum GroupTreeNodeType { get; set; }

        }

        public void FillTree()
        {
            CreateNodeContextMenu();

            TreeNode rootTreeNode = new TreeNode("Education Control System");
            treeView1.Nodes.Add(rootTreeNode);

            TreeNode studentsTreeNode = new TreeNode("Студенти");
            studentsTreeNode.ContextMenu = _NodeStudentContextMenu;
            GroupTreeNode groupTreeNode = new GroupTreeNode()
            {
                GroupTreeNodeType=GroupTreeNodeTypeEnum.Students
            };
            rootTreeNode.Nodes.Add(studentsTreeNode);
            studentsTreeNode.Tag = groupTreeNode;

            TreeNode studyGroupsTreeNode = new TreeNode("Навчальні групи");
            rootTreeNode.Nodes.Add(studyGroupsTreeNode);
            groupTreeNode = new GroupTreeNode()
            {
                GroupTreeNodeType=GroupTreeNodeTypeEnum.StudyGroups
            };
            studyGroupsTreeNode.Tag = groupTreeNode;

            TreeNode subjectsTreeNode = new TreeNode("Предмети");
            rootTreeNode.Nodes.Add(subjectsTreeNode);
            groupTreeNode = new GroupTreeNode()
            {
                GroupTreeNodeType = GroupTreeNodeTypeEnum.Subjects
            };
            subjectsTreeNode.Tag = groupTreeNode;

            TreeNode teachersTreeNode = new TreeNode("Викладачі");
            rootTreeNode.Nodes.Add(teachersTreeNode);
            groupTreeNode = new GroupTreeNode()
            {
                GroupTreeNodeType = GroupTreeNodeTypeEnum.Teachers
            };
            teachersTreeNode.Tag = groupTreeNode;

            TreeNode additionalCoursesTreeNode = new TreeNode("Додаткові курси");
            rootTreeNode.Nodes.Add(additionalCoursesTreeNode);
            groupTreeNode = new GroupTreeNode()
            {
                GroupTreeNodeType = GroupTreeNodeTypeEnum.AdditionalCourses
            };
            additionalCoursesTreeNode.Tag = groupTreeNode;
        }

        public void LoadStudents()
        {
            List<PrxStudent> students = DatabaseQueries.StudentsAdapter.GetList(EduContext);
            bndStudents.DataSource = students;
        }

        public void LoadSubjects()
        {
            List<PrxSubject> subjects = DatabaseQueries.SubjectsAdapter.GetSubjects(EduContext);
            bndSubjects.DataSource = subjects;
        }

        public void LoadStudyGroups()
        {
            List<PrxStudyGroup> studyGroups = DatabaseQueries.StudyGroupsAdapter.GetList(EduContext);
            bndStudyGroups.DataSource = studyGroups;
        }

        public void LoadTeachers()
        {
            List<PrxTeacher> teachers = DatabaseQueries.TeacherAdapter.GetList(EduContext);
            bndTeachers.DataSource = teachers;
        }

        public void LoadAdditionalCourses()
        {
            List<PrxAdditionalCourse> additionalCourses = DatabaseQueries.AdditionalCoursesAdapter.GetAdditionalCourses(EduContext);
            bndAdditionalCourses.DataSource = additionalCourses;

        }
        public void LoadData()
        {
            

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
            AddStudent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                SetGridVisible(this.grvStudents);
                LoadStudents();
                this.bndStudents.ResetBindings(false);
            }

            if (e.Node.Tag is GroupTreeNode)
            {
                GroupTreeNode groupTreeNode = (GroupTreeNode)e.Node.Tag;
                switch (((GroupTreeNode)e.Node.Tag).GroupTreeNodeType)
                {
                    case GroupTreeNodeTypeEnum.Students:
                        SetGridVisible(this.grvStudents);
                        LoadStudents();
                        this.bndStudents.ResetBindings(false);
                        break;
                    case GroupTreeNodeTypeEnum.StudyGroups:
                        SetGridVisible(this.grvStudyGroups);
                        LoadStudyGroups();
                        this.bndStudyGroups.ResetBindings(false);
                        break;
                    case GroupTreeNodeTypeEnum.Subjects:
                        SetGridVisible(this.grvSubjects);
                        LoadSubjects();
                        this.bndSubjects.ResetBindings(false);
                        break;
                    case GroupTreeNodeTypeEnum.Teachers:
                        SetGridVisible(this.grvTeachers);
                        LoadTeachers();
                        this.bndTeachers.ResetBindings(false);
                        break;
                    case GroupTreeNodeTypeEnum.AdditionalCourses:
                        SetGridVisible(this.grvAdditionalCourse);
                        LoadAdditionalCourses();
                        this.bndAdditionalCourses.ResetBindings(false);
                        break;
                }
            }
        }

        private void SetGridVisible(DataGridView dataGridView)
        {
            this.grvStudents.Dock = DockStyle.Fill;
            this.grvStudyGroups.Dock = DockStyle.Fill;
            this.grvSubjects.Dock = DockStyle.Fill;
            this.grvTeachers.Dock = DockStyle.Fill;
            this.grvAdditionalCourse.Dock = DockStyle.Fill;

            this.grvStudents.Visible = (dataGridView == this.grvStudents);
            this.grvStudyGroups.Visible = (dataGridView == this.grvStudyGroups);
            this.grvSubjects.Visible = (dataGridView == this.grvSubjects);
            this.grvTeachers.Visible = (dataGridView == this.grvTeachers);
            this.grvAdditionalCourse.Visible = (dataGridView == this.grvAdditionalCourse);
        }

        public void AddStudent()
        {
            using (FrmAddStudent frmAddStudent = new FrmAddStudent())
            {
                if (frmAddStudent.ShowDialog(this) == DialogResult.OK)
                {
                    LoadStudents();
                    this.bndStudents.ResetBindings(false);
                }
            }
        }

        private void btnAddStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddStudent();
        }

        private void btnAddStudyGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmAddStudyGroup frmAddstudyGroup = new FrmAddStudyGroup())
            {
                if (frmAddstudyGroup.ShowDialog(this) == DialogResult.OK)
                {
                    LoadStudyGroups();
                    this.bndStudyGroups.ResetBindings(false);
                }
            }
        }

        private void btnAddSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmAddSubject frmAddSubject = new FrmAddSubject())
            {
                if (frmAddSubject.ShowDialog(this) == DialogResult.OK)
                {
                    LoadSubjects();
                    this.bndSubjects.ResetBindings(false);
                }
            }
        }

        private void btnAddTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmAddTeacher frmAddTeacher = new FrmAddTeacher())
            {
                if (frmAddTeacher.ShowDialog(this) == DialogResult.OK)
                {
                    LoadTeachers();
                    this.bndTeachers.ResetBindings(false);
                }
            }
        }

        private void btnAddAdditionalCourse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
