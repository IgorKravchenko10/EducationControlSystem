using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DataObjects
{
    public class AdditionalCourse
    {
        [Key()]
        public int AdditionalCourseId { get; set; }

        public string AdditionalCourseName { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        public int SubjectId { get; set; }

        public int StudyCourse { get; set; }

        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
    }
}
