using System.Collections.Generic;
using System.Linq;
using MvvmCross.Plugins.Sqlite;
using SQLite;

namespace Day17.Core.Services.DataStore
{
    public class Repository : IRepository
    {
        private readonly SQLiteConnection _connection;

        public Repository(IMvxSqliteConnectionFactory connectionFactory)
        {
            _connection = connectionFactory.GetConnection("Collect.sql");
            _connection.CreateTable<CollectedItem>();
        }

        public List<CollectedItem> All()
        {
            return _connection.Table<CollectedItem>().OrderByDescending(x => x.WhenUtc).ToList();
        }

        public void Add(CollectedItem collectedItem)
        {
            _connection.Insert(collectedItem);
        }

        public void Delete(CollectedItem collectedItem)
        {
            _connection.Delete<CollectedItem>(collectedItem.Id);
        }

        public void Update(CollectedItem collectedItem)
        {
            _connection.Update(collectedItem);
        }

        public CollectedItem Latest
        {
            get { return _connection.Table<CollectedItem>().OrderByDescending(item => item.WhenUtc).FirstOrDefault(); }
        }

        public CollectedItem Get(int id)
        {
            return _connection.Get<CollectedItem>(id);
        }
    }
}
