using EducationControlSystem.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.ProxyClasses
{
    public class PrxStudyGroup : PrxBaseClass
    {
        public PrxTeacher Teacher { get; set; }
          
        public StudyGroup CopyToData()
        {
            StudyGroup studyGroup = new StudyGroup()
            {
                GroupName = this.Name,
                StudyGroupId = this.Id,
            };
            return studyGroup;
        }
    }
}
