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
    public class Student
    {
        [Key()]
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        /// <summary>
        /// Дата рождения студента
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Дата вступления в ВУЗ
        /// </summary>
        public int YearEntry { get; set; }

        /// <summary>
        /// Номер телефона студента
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Обучается ли студент за границей
        /// </summary>
        public bool IsAbroad { get; set; }

        /// <summary>
        /// Находится ли студент на контрактной форме обучения
        /// </summary>
        public bool IsContract { get; set; }

        /// <summary>
        /// Чи є студент старостою групи
        /// </summary>
        public bool IsLeader { get; set; }

        /// <summary>
        /// Внешний ключ на запись в таблице SudyGroups
        /// </summary>
        public int StudyGroupId { get; set; }

        /// <summary>
        /// Ссылка на группу, в которой обучается студент
        /// </summary>
        [ForeignKey("StudyGroupId")]
        public virtual StudyGroup StudyGroup { get; set; }

        /// <summary>
        /// Список изучаемых предметов
        /// </summary>
        public virtual ICollection<SubjectMark> SubjectMarks { get; set; }  = new HashSet<SubjectMark>();

        public PrxStudent CopyToProxy()
        {
            PrxStudent prxStudent = new PrxStudent()
            {
                Id = this.StudentId,
                Name = this.StudentName,
                PhoneNumber = this.PhoneNumber,
                YearEntry = this.YearEntry,
                DateOfBirth = this.DateOfBirth,
                IsAbroad = this.IsAbroad,
                IsContract = this.IsContract,
                IsLeader=this.IsLeader
            };
            return prxStudent;
        }
    }
}
