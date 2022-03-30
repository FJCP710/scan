using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace scan
{
    public partial class App : Application
    {
        private static SQLiteHelper db;
        public static SQLiteHelper MyDatabase
        {
            get
            {
                if(db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"medicinas.db3"));

                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedBottom();
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
