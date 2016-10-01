using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DataObjects
{
    public class Teacher
    {
        [Key()]
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }

        /// <summary>
        /// Номер телефона преподавателя
        /// </summary>
        public string Phone { get; set; }
                
    }
}
