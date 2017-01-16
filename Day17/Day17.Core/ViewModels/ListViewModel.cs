using System.Windows.Input;
using Day17.Core.Services.Collections;
using Day17.Core.Services.DataStore;
using Day17.Core.Services.Location;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;

namespace Day17.Core.ViewModels
{
    public class ListViewModel : BaseViewModel
    {
        public ListViewModel(ICollectionService collectionService, ILocationService locationService, IMvxMessenger messenger) 
            : base(collectionService, locationService, messenger)
        {
            Items = CollectionService.All();
        }

        public ICommand ShowDetailCommand => new MvxCommand<CollectedItem>(ShowDetailView);

        private void ShowDetailView(CollectedItem item)
        {
            var param = new DetailViewModel.Nav {Id = item.Id};
            ShowViewModel<DetailViewModel>(param);
        }
    }
}
