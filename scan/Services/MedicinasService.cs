using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace scan.Services
{
    public static class MedicinasService
    {
        static SQLiteAsyncConnection db;
        static MedicinasDB medicinas;
        static async Task Init()
        {
            if (db == null) return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            
        }

        public static async Task AddMedicina(MedicinasDB medicinas)
        {
            await Init();
            
            
        }

        public static async Task CreateNotification(MedicinasDB medicinas)
        {
            await Init();
        }

        public static async Task CreateReminder(MedicinasDB medicinas)
        {
            await Init();
        }
    }
}
