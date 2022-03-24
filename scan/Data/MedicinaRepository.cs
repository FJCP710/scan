﻿using scan.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace scan.Data
{
    public class MedicinaRepository
    {
        MainPage mainPage;
        public ObservableCollection<string> names { get; set; } = new ObservableCollection<string>();
        private readonly SQLiteConnection _database;

        public static string DbPath { get; } =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "medicinas.db");

        public MedicinaRepository()
        {
            _database = new SQLiteConnection(DbPath);
            _database.CreateTable<MedicinasDB>();
        }

        public List<MedicinasDB> List()
        {
            return _database.Table<MedicinasDB>().ToList();
        }

        public ObservableCollection<string> GetName()
        {
            string nombre = _database.Query<MedicinasDB>("SELECT nombre FROM MEDICINAS WHERE id = "+mainPage.id).ToString();
            
            names.Add(nombre);

            return names;
        }

        
    }
}
