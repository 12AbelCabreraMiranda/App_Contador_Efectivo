using Cash.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cash.Data
{
    public class DataBaseContext
    {
        public readonly SQLiteAsyncConnection Connection;
        public DataBaseContext(string path)
        {
            Connection = new SQLiteAsyncConnection(path);
            Connection.CreateTableAsync<CashItem>().Wait();
        }

        //Method Insert
        public async Task<int> InsertItemAsync(CashItem item)
        {
            return await Connection.InsertAsync(item);
        }
        //Method List View
        public async Task<List<CashItem>> GetItemsAsync()
        {
            return await Connection.Table<CashItem>().ToListAsync();
        }
        //Method delete
        public async Task<int> DeleteItemAzync(CashItem item)
        {
            return await Connection.DeleteAsync(item);
        }

    }
}
