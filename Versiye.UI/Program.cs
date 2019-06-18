using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Veresiye.Data;
using Veresiye.Service;

namespace Versiye.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Autofac = IoC
            var builder = new ContainerBuilder();
            builder.RegisterType<ApplicationDbContext>().As<ApplicationDbContext>();

            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            // servislerimiz
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<CompanyService>().As<ICompanyService>();
            builder.RegisterType<ActivityService>().As<IActivityService>();

            //Formlarımız
            builder.RegisterType<FrmMain>().As<FrmMain>();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var frm = scope.Resolve<FrmMain>();
                Application.Run(frm);
            }
        }
    }
}
