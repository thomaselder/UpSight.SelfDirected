using SelfDirected.TimeKeeper.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace SelfDirected.TimeKeeper.Databases
{
    public class TaskDatabase
    {
        SQLiteAsyncConnection Database;

        public TaskDatabase()
        {

        }

        public TaskDatabase(SQLiteAsyncConnection connection) 
        {
            Database = connection;
        }

        async Task Init()
        {
            if (Database is not null)
            {
                return;
            }

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

            var result = await Database.CreateTableAsync<TaskModel>();
        }

        public async Task<List<TaskModel>> GetItemsAsync()
        {
            await Init();
            return await Database.Table<TaskModel>().ToListAsync();
        }

        public async Task<TaskModel> GetItemAsync(int id)
        {
            await Init();

            return await Database.Table<TaskModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(TaskModel item)
        {
            await Init();
            if(item.Id != 0)
            {
                return await Database.UpdateAsync(item);
            }
            else
            {
                return await Database.InsertAsync(item);
            }
        }  

        public async Task<int> DeleteItemAsync(TaskModel itemm)
        {
            await Init();
            return await Database.DeleteAsync(itemm);
        }
    }
}

