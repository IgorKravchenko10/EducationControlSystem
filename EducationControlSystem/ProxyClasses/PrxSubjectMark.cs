﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.ProxyClasses
{
    public enum SubjectState : int
    {
        Вивчається = 0,
        Залік = 1,
        Переекзаменовка = 2
    }

    public class PrxSubjectMark : PrxBaseClass
    {
        public int Mark { get; set; }

        public int Semester { get; set; }

        public bool IsExam { get; set; }

        public SubjectState State { get; set; }

        public string StudentName { get; set; }

        public string SubjectName { get; set; }

    }
}
