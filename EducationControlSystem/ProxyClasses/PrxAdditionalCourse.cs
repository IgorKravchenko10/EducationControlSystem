﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.ProxyClasses
{
    public class PrxAdditionalCourse
    {
        public int AdditionalCourseId { get; set; }

        public string AdditionalCourseName { get; set; }

        public int StudyCourse { get; set; }

        public PrxTeacher Teacher { get; set; }

        public PrxSubject Subject { get; set; }

        public string TeacherName { get; set; }

        public string SubjectName{ get; set; }
    }
}
