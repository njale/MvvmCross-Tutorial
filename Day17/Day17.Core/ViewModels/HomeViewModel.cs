using Day17.Core.Services.Collections;
using Day17.Core.Services.Location;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;

namespace Day17.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(ICollectionService collectionService, ILocationService locationService, IMvxMessenger messenger)
        : base(collectionService, locationService, messenger)
        {
            UpdateLatest();
        }

        private MvxCommand _addCommand, _listCommand;

        public MvxCommand AddCommand
        {
            get { return _addCommand ?? new MvxCommand(DoAdd); }
            set { SetProperty(ref _addCommand, value); }
        }

        private void DoAdd()
        {
            ShowViewModel<AddViewModel>();
        }

        public MvxCommand ListCommand
        {
            get { return _listCommand ?? new MvxCommand(DoList); }
            set { SetProperty(ref _listCommand, value); }
        }

        private void DoList()
        {
            ShowViewModel<ListViewModel>();
        }
    }
}
