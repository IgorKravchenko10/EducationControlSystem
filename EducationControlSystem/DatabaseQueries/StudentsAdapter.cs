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
        public static List<PrxStudent> GetStudents(EduContext eduContext)
        {
            IQueryable<PrxStudent> getStudents = from qr in eduContext.Students
                                                 select new PrxStudent
                                                 {
                                                     Id = qr.StudentId,
                                                     Name = qr.StudentName,
                                                     DateOfBirth = qr.DateOfBirth,
                                                     DateEntry = qr.DateEntry,
                                                     IsAbroad = qr.IsAbroad,
                                                     PhoneNumber = qr.PhoneNumber,
                                                     IsContract = qr.IsContract
                                                 };
            List<PrxStudent> students = getStudents.ToList();
            return students;
        }

        public static List<PrxStudent> GetListOfGroup(EduContext eduContext, int studyGroupId)
        {
            IQueryable<PrxStudent> getList = from qr in eduContext.Students
                                                  where studyGroupId == qr.StudyGroupId
                                                  select new PrxStudent
                                                  {
                                                      Id = qr.StudentId,
                                                      Name = qr.StudentName,
                                                      DateOfBirth = qr.DateOfBirth,
                                                      DateEntry = qr.DateEntry,
                                                      IsAbroad = qr.IsAbroad,
                                                      PhoneNumber = qr.PhoneNumber,
                                                      IsContract = qr.IsContract
                                                  };
            List<PrxStudent> studentsList = getList.ToList();
            return studentsList;
        }
    }
}
