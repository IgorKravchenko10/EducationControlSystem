﻿using EducationControlSystem.DataObjects;
using EducationControlSystem.Forms;
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
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTree();
            this.WindowState = FormWindowState.Maximized;
        }

        private enum GroupTreeNodeTypeEnum
        {
            Students,
            Subjects,
            Teachers,
            StudyGroups,
            AdditionalCourses,
            SubjectMarks
        }

        private class GroupTreeNode
        {
            public GroupTreeNodeTypeEnum GroupTreeNodeType { get; set; }

        }

        public void FillTree()
        {

            TreeNode rootTreeNode = new TreeNode("Education Control System");
            treeView1.Nodes.Add(rootTreeNode);

            TreeNode studentsTreeNode = new TreeNode("Студенти");
            GroupTreeNode groupTreeNode = new GroupTreeNode()
            {
                GroupTreeNodeType = GroupTreeNodeTypeEnum.Students
            };
            rootTreeNode.Nodes.Add(studentsTreeNode);
            studentsTreeNode.Tag = groupTreeNode;

            TreeNode studyGroupsTreeNode = new TreeNode("Навчальні групи");
            rootTreeNode.Nodes.Add(studyGroupsTreeNode);
            groupTreeNode = new GroupTreeNode()
            {
                GroupTreeNodeType = GroupTreeNodeTypeEnum.StudyGroups
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

            TreeNode subjectMarksTreeNode = new TreeNode("Оцінки");
            rootTreeNode.Nodes.Add(subjectMarksTreeNode);
            groupTreeNode = new GroupTreeNode()
            {
                GroupTreeNodeType = GroupTreeNodeTypeEnum.SubjectMarks
            };
            subjectMarksTreeNode.Tag = groupTreeNode;
        }

        private void LoadStudents()
        {
            List<PrxStudent> students = DatabaseQueries.StudentsAdapter.GetList(EduContext);
            bndStudents.DataSource = students;
        }

        private void LoadSubjects()
        {
            List<PrxSubject> subjects = DatabaseQueries.SubjectsAdapter.GetList(EduContext);
            bndSubjects.DataSource = subjects;
        }

        private void LoadStudyGroups()
        {
            List<PrxStudyGroup> studyGroups = DatabaseQueries.StudyGroupsAdapter.GetList(EduContext);
            bndStudyGroups.DataSource = studyGroups;
        }

        private void LoadTeachers()
        {
            List<PrxTeacher> teachers = DatabaseQueries.TeacherAdapter.GetList(EduContext);
            bndTeachers.DataSource = teachers;
        }

        private void LoadAdditionalCourses()
        {
            List<PrxAdditionalCourse> additionalCourses = DatabaseQueries.AdditionalCoursesAdapter.GetAdditionalCourses(EduContext);
            bndAdditionalCourses.DataSource = additionalCourses;
        }

        private void LoadAdditionalCoursesBySubjectAndTeacher(int subjectId, int teacherId)
        {
            List<PrxAdditionalCourse> additionalCourses = DatabaseQueries.AdditionalCoursesAdapter.GetAdditionalCoursesBySubjectAndTeacher(EduContext, subjectId, teacherId);
            bndAdditionalCourses.DataSource = additionalCourses;
        }

        private void LoadStudentsByStudyGroup(int studyGroupId)
        {
            List<PrxStudent> students = DatabaseQueries.StudentsAdapter.GetListByGroup(EduContext, studyGroupId);
            bndStudents.DataSource = students;
        }

        private void LoadStudentsByIsAbroad()
        {
            List<PrxStudent> students = DatabaseQueries.StudentsAdapter.GetListByIsAbroad(EduContext);
            bndStudents.DataSource = students;
        }

        private void LoadStudentsByGoodState()
        {
            List<PrxStudent> students = DatabaseQueries.StudentsAdapter.GetListBySubjectState();
            bndStudents.DataSource = students;
        }

        private void LoadSubjectMarksBySubject(int subjectId)
        {
            List<PrxSubjectMark> subjectMarks = DatabaseQueries.SubjectMarksAdapter.GetListBySubject(EduContext, subjectId);
            bndSubjectMarks.DataSource = subjectMarks;
        }

        private void LoadSubjectMarksByStudent(int studentId)
        {
            List<PrxSubjectMark> subjectMarks = DatabaseQueries.SubjectMarksAdapter.GetListByStudent(EduContext, studentId);
            bndSubjectMarks.DataSource = subjectMarks;
        }

        private void LoadSubjectMarks()
        {
            List<PrxSubjectMark> subjectMarks = DatabaseQueries.SubjectMarksAdapter.GetList(EduContext);
            bndSubjectMarks.DataSource = subjectMarks;
        }

        private void LoadSubjectMarksByStudyGroup(int studyGroupId)
        {
            List<PrxSubjectMark> subjectMarks = DatabaseQueries.SubjectMarksAdapter.GetListByGroup(EduContext, studyGroupId);
            bndSubjectMarks.DataSource = subjectMarks;
        }

        private void LoadSubjectMarksByAverage(int semester)
        {
            List<PrxSubjectMark> subjectMarks = DatabaseQueries.SubjectMarksAdapter.GetListByAverage(EduContext, semester);
            bndSubjectMarks.DataSource = subjectMarks;
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
                    case GroupTreeNodeTypeEnum.SubjectMarks:
                        SetGridVisible(this.grvSubjectMarks);
                        LoadSubjectMarks();
                        this.bndSubjectMarks.ResetBindings(false);
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
            this.grvSubjectMarks.Dock = DockStyle.Fill;

            this.grvStudents.Visible = (dataGridView == this.grvStudents);
            this.grvStudyGroups.Visible = (dataGridView == this.grvStudyGroups);
            this.grvSubjects.Visible = (dataGridView == this.grvSubjects);
            this.grvTeachers.Visible = (dataGridView == this.grvTeachers);
            this.grvAdditionalCourse.Visible = (dataGridView == this.grvAdditionalCourse);
            this.grvSubjectMarks.Visible = (dataGridView == this.grvSubjectMarks);
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
            using (FrmAddAdditionalCourse frmAddAdditionaCourse = new FrmAddAdditionalCourse())
            {
                if (frmAddAdditionaCourse.ShowDialog(this) == DialogResult.OK)
                {
                    LoadAdditionalCourses();
                    this.bndAdditionalCourses.ResetBindings(false);
                }
            }
        }

        private void btnAddSubjectMark_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmAddSubjectMark frmAddSubjectMark = new FrmAddSubjectMark())
            {
                if (frmAddSubjectMark.ShowDialog(this) == DialogResult.OK)
                {
                    LoadSubjectMarks();
                    this.bndSubjectMarks.ResetBindings(false);
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int studyGroupId = new int();

            using (FrmViewStudyGroupList frmViewStudyGroupList = new FrmViewStudyGroupList())
            {
                if (frmViewStudyGroupList.ShowDialog(this) == DialogResult.OK)
                {
                    studyGroupId = frmViewStudyGroupList.StudyGroupId;
                    LoadStudentsByStudyGroup(studyGroupId);
                    SetGridVisible(this.grvStudents);
                }
            }
            

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadStudentsByIsAbroad();
            SetGridVisible(this.grvStudents);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadStudentsByGoodState();
            SetGridVisible(this.grvStudents);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadStudentsByGoodState();
            SetGridVisible(this.grvStudents);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int subjectId = new int();
            using (FrmViewSubjectsList frmViewSubjectsList = new FrmViewSubjectsList())
            {
                if (frmViewSubjectsList.ShowDialog(this) == DialogResult.OK)
                {
                    subjectId = frmViewSubjectsList.SubjectId;
                    LoadSubjectMarksBySubject(subjectId);
                    SetGridVisible(this.grvSubjectMarks);
                }
            }
            
        }

        private void btnSubjectMarksStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int studentId = new int();

            using (FrmViewStudentList frmViewStudentList = new FrmViewStudentList())
            {
                if (frmViewStudentList.ShowDialog(this) == DialogResult.OK)
                {
                    studentId = frmViewStudentList.StudentId;
                    LoadSubjectMarksByStudent(studentId);
                    SetGridVisible(this.grvSubjectMarks);
                }
            }
            
        }


        private void btnSubjectMarksGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int studyGroupId = new int();

            using (FrmViewStudyGroupList frmViewStudyGroupList = new FrmViewStudyGroupList())
            {
                if (frmViewStudyGroupList.ShowDialog(this) == DialogResult.OK)
                {
                    studyGroupId = frmViewStudyGroupList.StudyGroupId;
                    LoadSubjectMarksByStudyGroup(studyGroupId);
                    SetGridVisible(this.grvSubjectMarks);
                }
            }
            
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int semester = new int();
            using (FrmSelectSemester frmSelectSemester = new FrmSelectSemester())
            {
                if (frmSelectSemester.ShowDialog(this) == DialogResult.OK)
                {
                    semester = frmSelectSemester.Semester;
                    LoadSubjectMarksByAverage(semester);
                    SetGridVisible(this.grvSubjectMarks);
                }
            }
            
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int subjectId = new int();
            int teacherId = new int();

            using (FrmViewSubjectsAndTeachersList frmViewSubjectsAndTeachersList = new FrmViewSubjectsAndTeachersList())
            {
                if (frmViewSubjectsAndTeachersList.ShowDialog(this) == DialogResult.OK)
                {
                    subjectId = frmViewSubjectsAndTeachersList.SubjectId;
                    teacherId = frmViewSubjectsAndTeachersList.TeacherId;
                    LoadAdditionalCoursesBySubjectAndTeacher(subjectId, teacherId);
                    SetGridVisible(this.grvAdditionalCourse);
                }
            }
        }

        private void grvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                PrxStudent prxStudent = (PrxStudent)grvStudents.CurrentRow.DataBoundItem;
                EditStudent(prxStudent.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void EditStudent(int id)
        {
            using (FrmAddStudent frmAddStudent = new FrmAddStudent(id))
            {
                if (frmAddStudent.ShowDialog(this) == DialogResult.OK)
                {
                    LoadStudents();
                    SetGridVisible(this.grvStudents);
                }
            }

        }


        private void grvSubjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvStudyGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvSubjectMarks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvTeachers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvAdditionalCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
