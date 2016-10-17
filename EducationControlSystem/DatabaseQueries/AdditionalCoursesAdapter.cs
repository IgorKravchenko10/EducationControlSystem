using EducationControlSystem.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DatabaseQueries
{
    public class AdditionalCoursesAdapter
    {
        public static List<PrxAdditionalCourse> GetAdditionalCourses(EduContext eduContext)
        {
            IQueryable<PrxAdditionalCourse> getAdditionalCourses = from qr in eduContext.AdditionalCourses
                                                                   select new PrxAdditionalCourse
                                                                   {
                                                                       AdditionalCourseId = qr.AdditionalCourseId,
                                                                       AdditionalCourseName = qr.AdditionalCourseName,
                                                                       StudyCourse = qr.StudyCourse,
                                                                       Subject = new PrxSubject
                                                                       {
                                                                           Id = qr.SubjectId,
                                                                           Name = qr.Subject.SubjectName
                                                                       },
                                                                       Teacher = new PrxTeacher
                                                                       {
                                                                           Id = qr.TeacherId,
                                                                           Name = qr.Teacher.TeacherName,
                                                                           PhoneNumber = qr.Teacher.Phone
                                                                       }
                                                                   };
            List<PrxAdditionalCourse> additionalCourses = getAdditionalCourses.ToList();
            return additionalCourses;
        }
    }
}
