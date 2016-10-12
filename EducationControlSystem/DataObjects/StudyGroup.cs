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
    public class StudyGroup
    {
        [Key()]
        public int StudyGroupId { get; set; }

        public string GroupName { get; set; }            

        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher Curator { get; set; }

        /// <summary>
        /// Список студентов, обучающихся в группе
        /// </summary>
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

        public PrxStudyGroup CopyToProxy()
        {
            PrxStudyGroup prxStudyGroup = new PrxStudyGroup()
            {
                Id = this.StudyGroupId,
                Name=this.GroupName,
            };
            return prxStudyGroup;
        }
    }
}
