using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.ProxyClasses
{
    public class PrxTeacher : PrxPerson
    {
        
        /// <summary>
        /// Является ли преподаватель куратором
        /// </summary>
        public bool IsCurator { get; set; }
       
    }
}
