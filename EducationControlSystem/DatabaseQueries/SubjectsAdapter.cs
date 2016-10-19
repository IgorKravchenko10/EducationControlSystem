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
        public static List<PrxSubject> GetList(EduContext eduContext)
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

        public static List<PrxSubject> GetListBySql()
        {
            List<PrxSubject> prxSubjects = new List<PrxSubject>();

            using (var eduContext = new EduContext())
            {
                var subjects = eduContext.Subjects.SqlQuery("select * from dbo.Subjects").ToList();
                foreach (var item in subjects)
                {
                    prxSubjects.Add(item.CopyToProxy());
                }
            }
            return prxSubjects;
        }
    }
}
