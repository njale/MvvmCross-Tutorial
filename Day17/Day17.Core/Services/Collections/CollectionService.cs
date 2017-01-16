using System.Collections.Generic;
using Day17.Core.Services.DataStore;
using MvvmCross.Plugins.Messenger;

namespace Day17.Core.Services.Collections
{
    public class CollectionService : ICollectionService
    {
        private readonly IRepository _repository;
        private readonly IMvxMessenger _messenger;

        public CollectionService(IRepository repository, IMvxMessenger messenger)
        {
            _repository = repository;
            _messenger = messenger;
        }

        public List<CollectedItem> All()
        {
            return _repository.All();
        }

        CollectedItem ICollectionService.Latest => _repository.Latest;

        public CollectedItem Get(int id)
        {
            return _repository.Get(id);
        }

        public void Add(CollectedItem collectedItem)
        {
            _repository.Add(collectedItem);
            _messenger.Publish(new CollectionChangedMessage(this));
        }

        public void Delete(CollectedItem item)
        {
            _repository.Delete(item);
            _messenger.Publish(new CollectionChangedMessage(this));
        }
    }
}
