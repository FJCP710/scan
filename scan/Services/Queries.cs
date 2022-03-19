using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace scan.Services
{
    public class Queries
    {
        readonly SQLiteAsyncConnection database;

        public Queries(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);

        }

        public Task<List<MedicinasDB>> GetMedicinas()
        {
            return database.QueryAsync<MedicinasDB>("Select * From MedicinasDB");
        }
    }
}
