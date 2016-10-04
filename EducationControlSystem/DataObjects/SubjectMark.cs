using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DataObjects
{
    public enum State
    {
        InProcessing = 0,
        Completed = 1,
        Retaking = 2
    }

    public class SubjectMark
    {
        [Key()]
        public int SubjectMarkId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        public int StudentId { get; set; }

        public int Mark { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        public int SubjectId { get; set; }

        public int Semester { get; set; }

        public bool IsExam { get; set; }

        public State State { get; set; }
    }
}