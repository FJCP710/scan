using scan.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace scan.Data
{
    public class MedicinaRepository
    {
        private readonly SQLiteConnection _database;
        MainPage _mainPage;

        public static string DbPath { get; } =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "medicinas.db");

        public MedicinaRepository()
        {
            _database = new SQLiteConnection(DbPath);
            _database.CreateTable<MedicinasDB>();
        }

        public string GetName()
        {
            var name = _database.Query<MedicinasDB>("SELECT nombre FROM medicinas WHERE id= " + _mainPage.id);
            string nombre = name.ToString();
            return nombre;
            //_database.Table<MedicinasDB>().ToList(); String<MedicinasDB>
        }


    }
}
