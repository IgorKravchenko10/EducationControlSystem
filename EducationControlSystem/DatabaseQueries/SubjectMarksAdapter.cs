using EducationControlSystem.DataObjects;
using EducationControlSystem.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DatabaseQueries
{
    public class SubjectMarksAdapter
    {
        public static List<PrxSubjectMark> GetListByGroup(EduContext eduContext, int studyGroupId)
        {

            IQueryable<PrxSubjectMark> getSubjectMarks = from qr in eduContext.SubjectMarks
                                                         join student in eduContext.Students on qr.StudentId equals student.StudentId
                                                         join studyGroup in eduContext.StudyGroups on student.StudyGroupId equals studyGroup.StudyGroupId
                                                         join subject in eduContext.Subjects on qr.SubjectId equals subject.SubjectId
                                                         where student.StudyGroupId == studyGroupId
                                                         select new PrxSubjectMark
                                                         {
                                                             Id = qr.SubjectMarkId,
                                                             Semester = qr.Semester,
                                                             Mark = qr.Mark,
                                                             State = (SubjectState)qr.State,
                                                             IsExam = qr.IsExam,
                                                             StudentName = qr.Student.StudentName,
                                                             SubjectName = qr.Subject.SubjectName
                                                         };
            List<PrxSubjectMark> subjectMarks = getSubjectMarks.ToList();
            return subjectMarks;
        }

        public static List<PrxSubjectMark> GetList(EduContext eduContext)
        {
            IQueryable<PrxSubjectMark> getSubjectMarks = from qr in eduContext.SubjectMarks
                                                         select new PrxSubjectMark
                                                         {
                                                             Id = qr.SubjectMarkId,
                                                             Semester = qr.Semester,
                                                             Mark = qr.Mark,
                                                             State = (SubjectState)qr.State,
                                                             IsExam = qr.IsExam,
                                                             StudentName = qr.Student.StudentName,
                                                             SubjectName = qr.Subject.SubjectName,
                                                         };
            List<PrxSubjectMark> subjectMarks = getSubjectMarks.ToList();
            return subjectMarks;
        }

        public static List<PrxSubjectMark> GetListBySubject(EduContext eduContext, int subjectId)
        {
            IQueryable<PrxSubjectMark> getSubjectMarks = from qr in eduContext.SubjectMarks
                                                         join subject in eduContext.Subjects on subjectId equals subject.SubjectId
                                                         join student in eduContext.Students on qr.StudentId equals student.StudentId
                                                         where qr.SubjectId == subjectId && qr.State == 2
                                                         select new PrxSubjectMark
                                                         {
                                                             Id = qr.SubjectMarkId,
                                                             Semester = qr.Semester,
                                                             Mark = qr.Mark,
                                                             State = (SubjectState)qr.State,
                                                             IsExam = qr.IsExam,
                                                             StudentName = qr.Student.StudentName,
                                                             SubjectName = qr.Subject.SubjectName
                                                         };
            List<PrxSubjectMark> subjectMarks = getSubjectMarks.ToList();
            return subjectMarks;
        }

        public static List<PrxSubjectMark> GetListByStudent(EduContext eduContext, int studentId)
        {
            IQueryable<PrxSubjectMark> getSubjectMarks = from qr in eduContext.SubjectMarks
                                                         join student in eduContext.Students on qr.StudentId equals student.StudentId
                                                         join subject in eduContext.Subjects on qr.SubjectId equals subject.SubjectId
                                                         where student.StudentId==studentId
                                                         select new PrxSubjectMark
                                                         {
                                                             Id = qr.SubjectMarkId,
                                                             Semester = qr.Semester,
                                                             Mark = qr.Mark,
                                                             State = (SubjectState)qr.State,
                                                             IsExam = qr.IsExam,
                                                             StudentName = qr.Student.StudentName,
                                                             SubjectName = qr.Subject.SubjectName
                                                         };
            List<PrxSubjectMark> subjectMarks = getSubjectMarks.ToList();
            return subjectMarks;
        }

        public static List<PrxSubjectMark> GetListByAverage(EduContext eduContext, int semester)
        {
            var getSubjectMarks = from SubjectMarks in eduContext.SubjectMarks
                                  join Students in eduContext.Students on SubjectMarks.StudentId equals Students.StudentId
                                  join Subjects in eduContext.Subjects on SubjectMarks.SubjectId equals Subjects.SubjectId
                                  group new { SubjectMarks, Students } by new
                                  {
                                      SubjectMarks.Semester,
                                      Students.StudentName,
                                      SubjectMarks.StudentId
                                  } into g
                                  where g.Key.Semester == semester
                                  select new
                                  {
                                      Expr1 = (double?)g.Average(p => p.SubjectMarks.Mark),
                                      g.Key.Semester,
                                      g.Key.StudentName,
                                      g.Key.StudentId
                                  };
            var subjectMarks = getSubjectMarks;
            List<PrxSubjectMark> newList = new List<PrxSubjectMark>();

            foreach (var item in subjectMarks)
            {
                PrxSubjectMark subjectMark = new PrxSubjectMark()
                {
                    Mark=(int)item.Expr1,
                    Semester=item.Semester,
                    StudentName=item.StudentName
                };
                newList.Add(subjectMark);
            }
            return newList;
        }


    }
}
