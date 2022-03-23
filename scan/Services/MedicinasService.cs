using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace scan.Services
{
    public class MedicinasServices
    {
        static SQLiteAsyncConnection conn;

        public MedicinasServices()
        {

        }
        public const string DatabaseFilename = "medicinas.db";
        public const SQLiteOpenFlags flags = SQLiteOpenFlags.ReadWrite;
        /*
        static async Task Init()
        {
            if (conn == null) return;
            
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "medicinas.db");
            //Path.Combine(FileSystem.AppDataDirectory, "medicinas.db");
            //ApplicationData.Current.LocalFolder.Path + "/medicinas.db";

            conn = new SQLiteAsyncConnection(databasePath);
            

        }
        */
        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
        
    }
}
