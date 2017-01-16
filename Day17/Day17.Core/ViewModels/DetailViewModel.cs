using System.Windows.Input;
using Day17.Core.Services.Collections;
using Day17.Core.Services.DataStore;
using MvvmCross.Core.ViewModels;

namespace Day17.Core.ViewModels
{
    public class DetailViewModel : MvxViewModel
    {
        private readonly ICollectionService _collectionService;
        private CollectedItem _item;

        public DetailViewModel(ICollectionService collectionService)
        {
            _collectionService = collectionService;
        }

        public CollectedItem Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    _collectionService.Delete(Item);
                    Close(this);
                });
            }
        }

        public void Init(Nav navigation)
        {
            Item = _collectionService.Get(navigation.Id);
        }

        public class Nav
        {
            public int Id { get; set; }
        }


    }
}