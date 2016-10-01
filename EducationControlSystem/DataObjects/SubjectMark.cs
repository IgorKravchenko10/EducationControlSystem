using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.DataObjects
{
    public class SubjectMark
    {
        [Key()]
        public int SubjectMarkId { get; set; }

        public int Mark { get; set; }
                                
        public int StudentSubjectId { get; set; }

        /// <summary>
        /// Ссылка на предмет
        /// </summary>
        [ForeignKey("StudentSubjectId")]
        public virtual StudentSubject StudentSubject { get; set; }

    }
}
