using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace Day26.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        public ICommand First => new MvxCommand(() => ShowViewModel<FirstViewModel>());
        public ICommand Second => new MvxCommand(() => ShowViewModel<SecondViewModel>());
    }

    public class FirstViewModel : MvxViewModel
    {
        private SubViewModel _sub = new SubViewModel();
        public SubViewModel Sub
        {
            get => _sub;
            set => SetProperty(ref _sub, value);
        }
    }

    public class SecondViewModel : MvxViewModel
    {
        private SubViewModel _sub = new SubViewModel();
        public SubViewModel Sub
        {
            get => _sub;
            set => SetProperty(ref _sub, value);
        }
    }



    public class SubViewModel : MvxViewModel
    {
        private string _hello;

        public SubViewModel()
        {
            _hello = "Hello MvvmCross";
        }

        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }

    }
}