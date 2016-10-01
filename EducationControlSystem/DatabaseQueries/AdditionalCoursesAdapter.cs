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
                                                                       StudyCourse = qr.StudyCourse
                                                                   };
            List<PrxAdditionalCourse> additionalCourses = getAdditionalCourses.ToList();
            return additionalCourses;
        }
    }
}
