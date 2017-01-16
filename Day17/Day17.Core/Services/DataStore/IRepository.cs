using System.Collections.Generic;

namespace Day17.Core.Services.DataStore
{
    public interface IRepository
    {
        List<CollectedItem> All();
        void Add(CollectedItem collectedItem);
        void Delete(CollectedItem collectedItem);
        void Update(CollectedItem collectedItem);
        CollectedItem Latest { get; }
        CollectedItem Get(int id);
    }
}