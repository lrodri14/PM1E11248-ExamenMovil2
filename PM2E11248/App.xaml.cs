using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PM2E11248.Controllers;
using System.IO;

namespace PM2E11248
{
    public partial class App : Application
    {

        static PM2E11248.Controllers.DBProc dbProc;

        public static PM2E11248.Controllers.DBProc Instancia
        {
            get
            {
                if (dbProc == null)
                {
                    String dbName = "Proc.db3";
                    String dbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String dbfulp = Path.Combine(dbPath, dbName);
                    dbProc = new PM2E11248.Controllers.DBProc(dbfulp);
                }
                return dbProc;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PageLugaresGrid());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
