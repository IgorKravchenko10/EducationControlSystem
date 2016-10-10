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
        public static List<PrxSubjectMark> GetSubjectMarksByGroup(EduContext eduContext, PrxStudyGroup studyGroup)
        {

            IQueryable <PrxSubjectMark> getSubjectMarks = from qr in eduContext.SubjectMarks
                                                            join student in eduContext.Students on studyGroup.Id equals student.StudyGroupId
                                                            join subjectMark in eduContext.SubjectMarks on student.StudentId equals subjectMark.StudentId
                                                            join subject in eduContext.Subjects on subjectMark.SubjectId equals subject.SubjectId
                                                            where student.StudyGroupId==studyGroup.Id
                                                            select new PrxSubjectMark
                                                            {
                                                                Id = qr.SubjectMarkId,
                                                                Semester = qr.Semester,
                                                                Mark = qr.Mark,
                                                                State = (SubjectState)qr.State,
                                                                IsExam = qr.IsExam
                                                            };
            List<PrxSubjectMark> subjectMarks = getSubjectMarks.ToList();
            return subjectMarks;
        }

        public static List<PrxSubjectMark> GetSubjectMarks(EduContext eduContext)
        {
            IQueryable<PrxSubjectMark> getSubjectMarks = from qr in eduContext.SubjectMarks
                                                         select new PrxSubjectMark
                                                         {
                                                             Id = qr.SubjectMarkId,
                                                             Semester = qr.Semester,
                                                             Mark = qr.Mark,
                                                             State = (SubjectState)qr.State,
                                                             IsExam = qr.IsExam
                                                         };
            List<PrxSubjectMark> subjectMarks = getSubjectMarks.ToList();
            return subjectMarks;
        }

    }
}
