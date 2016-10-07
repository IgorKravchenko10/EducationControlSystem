using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationControlSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseAlways<EduContext>());
            //using (var eduContext = new EduContext())
            //{
            //  eduContext.Database.Initialize(force: true);
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
