﻿using EducationControlSystem.ProxyClasses;
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
                                                                       SubjectName=qr.Subject.SubjectName,
                                                                       Teacher = new PrxTeacher
                                                                       {
                                                                           Id = qr.TeacherId,
                                                                           Name = qr.Teacher.TeacherName,
                                                                           PhoneNumber = qr.Teacher.Phone
                                                                       },
                                                                       TeacherName=qr.Teacher.TeacherName
                                                                   };
            List<PrxAdditionalCourse> additionalCourses = getAdditionalCourses.ToList();
            return additionalCourses;
        }

        public static List<PrxAdditionalCourse> GetAdditionalCoursesBySubjectAndTeacher(EduContext eduContext, int subjectId, int teacherId)
        {
            IQueryable<PrxAdditionalCourse> getAdditionalCourses = from qr in eduContext.AdditionalCourses
                                                                   where qr.SubjectId==subjectId || qr.TeacherId==teacherId
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
                                                                       SubjectName = qr.Subject.SubjectName,
                                                                       Teacher = new PrxTeacher
                                                                       {
                                                                           Id = qr.TeacherId,
                                                                           Name = qr.Teacher.TeacherName,
                                                                           PhoneNumber = qr.Teacher.Phone
                                                                       },
                                                                       TeacherName = qr.Teacher.TeacherName
                                                                   };
            List<PrxAdditionalCourse> additionalCourses = getAdditionalCourses.ToList();
            return additionalCourses;
        }
    }
}
