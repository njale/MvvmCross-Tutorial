using MvvmCross.Core.ViewModels;

namespace Day24.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public IMvxCommand BlueCommand => new MvxCommand(() => ShowViewModel<BlueViewModel>());
        public IMvxCommand RedCommand => new MvxCommand(() => ShowViewModel<RedViewModel>());

    }
}