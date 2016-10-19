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
                                                 StudyGroupName=qr.StudyGroup.GroupName
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
                                                 IsLeader=qr.IsLeader,
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

        public static List<PrxStudent> GetListByGroup(string studyGroupName)
        {
            List<PrxStudent> prxStudents = new List<PrxStudent>();

            using (EduContext eduContext=new EduContext())
            {
                var students = eduContext.Students.SqlQuery("select dbo.Students.StudentName, dbo.StudyGroups.GroupName from dbo.Students Inner Join dbo.StudyGroups ON dbo.Students.StudyGroupId = dbo.StudyGroups.StudyGroupId Where (dbo.StudyGroups.GroupName=N'{0}')", studyGroupName).ToList();
                foreach (var item in students)
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
