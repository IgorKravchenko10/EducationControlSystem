using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationControlSystem.ProxyClasses
{
    public class PrxStudent : PrxPerson
    {
        /// <summary>
        /// Дата рождения студента
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Дата вступления в ВУЗ
        /// </summary>
        public int YearEntry { get; set; }

        /// <summary>
        /// Обучается ли студент за границей
        /// </summary>
        public bool IsAbroad { get; set; }

        /// <summary>
        /// Находится ли студент на контрактной форме обучения
        /// </summary>
        public bool IsContract { get; set; }

        public bool IsLeader { get; set; }

        public PrxStudyGroup StudyGroup { get; set; }

    }
}
