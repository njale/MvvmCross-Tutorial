using MvvmCross.Core.ViewModels;

namespace Day04.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private string _foo;
        public string Foo
        { 
            get { return _foo; }
            set { SetProperty (ref _foo, value); }
        }
    }
}
