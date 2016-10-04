using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DataObjects
{
    public class Subject
    {
        [Key()]
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

    }
}
