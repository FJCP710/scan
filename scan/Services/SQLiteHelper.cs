using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace scan.Services
{
    public class SQLiteHelper
    {
        
        string nombre;
        static MainPage mainPage;
        private readonly SQLiteAsyncConnection database;

        public SQLiteHelper(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<MedicinasDB>();
        }

        public Task<int> CreateMedicine (MedicinasDB medicinas)
        {
            return database.InsertAsync(medicinas);
        }

        public Task<List<MedicinasDB>> ReadMedicine()
        {
            return database.Table<MedicinasDB>().ToListAsync();
        }

        public Task<int> UpdateMedicine(MedicinasDB medicinas)
        {
            return database.UpdateAsync(medicinas);
        }

        public Task<int> DeleteMedicine(MedicinasDB medicinas)
        {
            return database.DeleteAsync(medicinas);
        }







        /*
        public string GetAddMedicinas(String nombre)
        {
            nombre = database.QueryAsync<MedicinasDB>("SELECT NOMBRE FROM Medicinas WHERE ID= " + mainPage.id).ToString();



            return nombre;
        }

        public List<string> AddMedicina(List<string>[] medicines)
        {
            
        }

        public async Task CreateNotification(MedicinasDB medicinas)
        {
            
        }

        public async Task CreateReminder(MedicinasDB medicinas)
        {
            
        }
        */
    } 
}
