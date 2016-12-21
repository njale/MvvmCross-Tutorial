using System.Collections.Generic;
using System.Linq;
using MvvmCross.Plugins.Sqlite;
using SQLite;

namespace Day10.Core.Services
{
    public class KittenDataService : IKittenDataService
    {
        private readonly SQLiteConnection _connection;

        public KittenDataService(IMvxSqliteConnectionFactory factory)
        {
            _connection = factory.GetConnection("one.sql");
            _connection.CreateTable<Kitten>();
        }

        public List<Kitten> KittensMatching(string nameFilter)
        {
            if (nameFilter == null)
                nameFilter = string.Empty;

            return _connection.Table<Kitten>()
                              .OrderBy(x => x.Price)
                              .Where(x => x.Name.Contains(nameFilter))
                              .ToList();
        }

        public void Insert(Kitten kitten)
        {
            _connection.Insert(kitten);
        }

        public void Update(Kitten kitten)
        {
            _connection.Update(kitten);
        }

        public void Delete(Kitten kitten)
        {
            // _connection.Delete(kitten);
            _connection.Delete<Kitten>(kitten.Id);
        }

        public int Count => _connection.Table<Kitten>().Count();
    }
}