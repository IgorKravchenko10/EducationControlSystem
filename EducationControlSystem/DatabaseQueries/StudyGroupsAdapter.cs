using EducationControlSystem.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DatabaseQueries
{
    public class StudyGroupsAdapter
    {

        public static List<PrxStudyGroup> GetStudyGroups(EduContext eduContext)
        {
            IQueryable<PrxStudyGroup> getStudyGroups = from qr in eduContext.StudyGroups
                                                       select new PrxStudyGroup
                                                       {
                                                           Id = qr.StudyGroupId,
                                                           Name = qr.GroupName,
                                                           StudentsCount = qr.StudentsCount
                                                       };
            List<PrxStudyGroup> studyGroups = getStudyGroups.ToList();
            return studyGroups;
        }

        public static List<PrxStudyGroup> GetStudyGroupsBySql()
        {
            List<PrxStudyGroup> prxStudyGroups = new List<PrxStudyGroup>();

            using (var eduContext = new EduContext())
            {
                var studyGroups = eduContext.StudyGroups.SqlQuery("select * from dbo.StudyGroups").ToList();
                foreach (var item in studyGroups)
                {
                    prxStudyGroups.Add(item.CopyToProxy());
                }
            }
            return prxStudyGroups;
        }
    }
}
