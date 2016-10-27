using EducationControlSystem.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DatabaseQueries
{
    public class StudentsAdapter
    {

        public static PrxStudent GetItemProxy(EduContext eduContext, int id)
        {
            IQueryable<PrxStudent> getItem = from qr in eduContext.Students
                                             where qr.StudentId == id
                                             select new PrxStudent
                                             {
                                                 Id = qr.StudentId,
                                                 Name = qr.StudentName,
                                                 DateOfBirth = qr.DateOfBirth,
                                                 YearEntry = qr.YearEntry,
                                                 IsAbroad = qr.IsAbroad,
                                                 PhoneNumber = qr.PhoneNumber,
                                                 IsContract = qr.IsContract,
                                                 IsLeader = qr.IsLeader,
                                                 StudyGroup = new PrxStudyGroup
                                                 {
                                                     Id = qr.StudyGroup.StudyGroupId,
                                                     Name = qr.StudyGroup.GroupName,
                                                 },
                                                 StudyGroupName = qr.StudyGroup.GroupName
                                             };
            PrxStudent prxStudent = getItem.FirstOrDefault();
            return prxStudent;
        }

        public static DataObjects.Student GetItem(EduContext eduContext, int id)
        {
            DataObjects.Student student = (from qr in eduContext.Students where qr.StudentId == id select qr).FirstOrDefault();
            return student;
        }

        public static List<PrxStudent> GetList(EduContext eduContext)
        {
            IQueryable<PrxStudent> getList = from qr in eduContext.Students
                                             select new PrxStudent
                                             {
                                                 Id = qr.StudentId,
                                                 Name = qr.StudentName,
                                                 DateOfBirth = qr.DateOfBirth,
                                                 YearEntry = qr.YearEntry,
                                                 IsAbroad = qr.IsAbroad,
                                                 PhoneNumber = qr.PhoneNumber,
                                                 IsContract = qr.IsContract,
                                                 IsLeader = qr.IsLeader,
                                                 StudyGroup = new PrxStudyGroup
                                                 {
                                                     Id = qr.StudyGroup.StudyGroupId,
                                                     Name = qr.StudyGroup.GroupName,
                                                 },
                                                 StudyGroupName = qr.StudyGroup.GroupName
                                             };
            List<PrxStudent> students = getList.ToList();
            return students;
        }

        public static List<PrxStudent> GetListByGroup(EduContext eduContext, int studyGroupId)
        {
            IQueryable<PrxStudent> getList = from qr in eduContext.Students
                                             where studyGroupId == qr.StudyGroupId
                                             select new PrxStudent
                                             {
                                                 Id = qr.StudentId,
                                                 Name = qr.StudentName,
                                                 DateOfBirth = qr.DateOfBirth,
                                                 YearEntry = qr.YearEntry,
                                                 IsAbroad = qr.IsAbroad,
                                                 PhoneNumber = qr.PhoneNumber,
                                                 IsContract = qr.IsContract,
                                                 StudyGroupName = qr.StudyGroup.GroupName,
                                                 IsLeader = qr.IsLeader,
                                             };
            List<PrxStudent> students = getList.ToList();
            return students;
        }

        public static List<PrxStudent> GetListByIsAbroad(EduContext eduContext)
        {
            IQueryable<PrxStudent> getList = from qr in eduContext.Students
                                             where qr.IsAbroad == true
                                             select new PrxStudent
                                             {
                                                 Id = qr.StudentId,
                                                 Name = qr.StudentName,
                                                 DateOfBirth = qr.DateOfBirth,
                                                 YearEntry = qr.YearEntry,
                                                 IsAbroad = qr.IsAbroad,
                                                 PhoneNumber = qr.PhoneNumber,
                                                 IsContract = qr.IsContract,
                                                 StudyGroupName = qr.StudyGroup.GroupName,
                                                 IsLeader = qr.IsLeader
                                             };
            List<PrxStudent> students = getList.ToList();
            return students;
        }

        public static List<PrxStudent> GetListBySubjectState()
        {
            List<PrxStudent> prxStudents = new List<PrxStudent>();

            using (EduContext eduContext=new EduContext())
            {
                var students = eduContext.Students.SqlQuery("select distinct dbo.Students.* from dbo.Students Inner Join dbo.SubjectMarks ON dbo.Students.StudentId = dbo.SubjectMarks.StudentId WHERE(dbo.SubjectMarks.State = 1) OR (dbo.SubjectMarks.State = 0)").ToList();

                foreach(var item in students)
                {
                    prxStudents.Add(item.CopyToProxy());
                }
            }
            return prxStudents;
        }        

        public static List<PrxStudent> GetListBySql()
        {
            List<PrxStudent> prxStudents = new List<PrxStudent>();

            using (var eduContext = new EduContext())
            {
                var students = eduContext.Students.SqlQuery("select * from dbo.Students").ToList();
                foreach (var item in students)
                {
                    prxStudents.Add(item.CopyToProxy());
                }
            }
            return prxStudents;
        }
    }
}
