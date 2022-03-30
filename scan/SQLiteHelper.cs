using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using scan.Models;
using SQLite;
using System.Collections.ObjectModel;

namespace scan
{
    public class SQLiteHelper
    {

        public ObservableCollection<string> nombres;
        private readonly SQLiteAsyncConnection db;
        MainPage mainPage = new MainPage();

        public SQLiteHelper (string dbPath)
        {
            db = new SQLiteAsyncConnection (dbPath);
            db.CreateTableAsync<MedicinasModel> ();
        }

        

        public Task<int> CreateMedicinas (MedicinasModel medicinas)
        {
            return db.InsertAsync(medicinas);
        }

        public Task<List<MedicinasModel>> ReadMedicinas()
        {
            return db.Table<MedicinasModel>().ToListAsync();
        }

        public Task<int> UpdateMedicinas(MedicinasModel medicinas)
        {
            return db.UpdateAsync(medicinas);
        }

        public Task<int> DeleteMedicinas (MedicinasModel medicinas)
        {
            return db.DeleteAsync(medicinas);
        }

        public Task<List<MedicinasModel>> GetName (MedicinasModel medicinas)
        {
            return db.QueryAsync<MedicinasModel>("SELECT nombre WHERE id = "+mainPage.idMedicina);
            mainPage.ListaNombres();
        }

        public Task<List<MedicinasModel>> GetUrl(MedicinasModel medicinas)
        {
            return db.QueryAsync<MedicinasModel>("SELECT prospecto WHERE id = " + mainPage.idMedicina);
        }
        /*
        public ObservableCollection<string> GetNombre()
        {

        }
        */
    }
}
