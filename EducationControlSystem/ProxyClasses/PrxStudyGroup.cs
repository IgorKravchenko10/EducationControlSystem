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
        /// <summary>
        /// Количество студентов, обучаемых в группе
        /// </summary>
        public int StudentsCount { get; set; }

    }
}
