using EducationControlSystem.ProxyClasses;
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

        public PrxSubject CopyToProxy()
        {
            PrxSubject prxSubject = new PrxSubject()
            {
                Id = this.SubjectId,
                Name = this.SubjectName,
            };
            return prxSubject;
        }
    }
}
