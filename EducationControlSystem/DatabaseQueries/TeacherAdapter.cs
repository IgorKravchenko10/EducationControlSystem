using EducationControlSystem.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DatabaseQueries
{
    public class TeacherAdapter
    {
        
        public static List<PrxTeacher> GetList(EduContext eduContext)
        {

            IQueryable<PrxTeacher> getList = from qr in eduContext.Teachers
                                             select new PrxTeacher()
                                             {
                                                 Id = qr.TeacherId,
                                                 Name = qr.TeacherName,
                                                 PhoneNumber = qr.Phone
                                             };
            List<PrxTeacher> teachers = getList.ToList();
            return teachers;
        }
    }
}
