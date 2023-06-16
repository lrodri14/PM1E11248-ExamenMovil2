using System;
using SQLite;
using PM2E11248.Models;
using System.Threading.Tasks;

namespace PM2E11248.Controllers
{
    public class DBProc { 

        readonly SQLiteAsyncConnection _connection;

        public DBProc(){}

        public DBProc(string dbpath) {
            _connection = new SQLiteAsyncConnection(dbpath);
            _connection.CreateTableAsync<Models.Lugares>().Wait();
        }

        // Create
        public Task<int> AddLugar(Lugares lugares)
        {
            if (lugares.Id == 0)
            {
                return _connection.InsertAsync(lugares);
            }
            else
            {
                return _connection.UpdateAsync(lugares);
            }
        }



        // Read
        public Task<System.Collections.Generic.List<Lugares>> GetAll()
        {
            return _connection.Table<Lugares>().ToListAsync();
        }

        // Read
        public Task<Lugares> GetById(int id)
        {
            return _connection.Table<Lugares>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        // Delete
        public Task<int> DeleteLugar(Lugares lugar)
        {
            return _connection.DeleteAsync(lugar);
        }
    }
}
