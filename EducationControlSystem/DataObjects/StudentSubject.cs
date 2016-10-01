﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DataObjects
{
    public class StudentSubject
    {
        [Key()]
        public int StudentSubjectId { get; set; }

        public int SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        public bool IsCompleted { get; set; }
    }
}
