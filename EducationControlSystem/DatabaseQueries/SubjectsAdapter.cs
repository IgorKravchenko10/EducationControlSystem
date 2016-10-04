using EducationControlSystem.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DatabaseQueries
{
    public class SubjectsAdapter
    {
        public static List<PrxSubject> GetSubjects(EduContext eduContext)
        {
            IQueryable<PrxSubject> getSubjects = from qr in eduContext.Subjects
                                                 select new PrxSubject
                                                 {
                                                     Id = qr.SubjectId,
                                                     Name = qr.SubjectName,
                                                 };
            List<PrxSubject> subjects = getSubjects.ToList();
            return subjects;
        }
    }
}
