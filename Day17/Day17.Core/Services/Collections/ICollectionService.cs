using System.Collections.Generic;
using Day17.Core.Services.DataStore;

namespace Day17.Core.Services.Collections
{
    public interface ICollectionService
    {
        List<CollectedItem> All();
        CollectedItem Latest { get; }

        CollectedItem Get(int id);

        void Add(CollectedItem collectedItem);
        void Delete(CollectedItem item);
    }
}