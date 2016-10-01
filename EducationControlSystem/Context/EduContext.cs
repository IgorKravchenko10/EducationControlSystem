namespace EducationControlSystem
{
    using DataObjects;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EduContext : DbContext
    {
        // Your context has been configured to use a 'EduContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EducationControlSystem.EduContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EduContext' 
        // connection string in the application configuration file.
        public EduContext()
            : base("name=EduContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<StudyGroup> StudyGroups { get; set; }

        public virtual DbSet<Subject> Subjects { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<SubjectMark> Marks { get; set; }

        public virtual DbSet<StudentSubject> StudentSubject { get; set; }

        public virtual DbSet<AdditionalCourse> AdditionalCourses { get; set; }
    }


}