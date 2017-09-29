using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace Day25.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
            Child1 = new Child1ViewModel();
            Child2 = new Child2ViewModel();
            Child3 = new Child3ViewModel();
        }

        private Child1ViewModel _child1;
        public Child1ViewModel Child1
        {
            get { return _child1; }
            set { SetProperty(ref _child1, value); }
        }

        private Child2ViewModel _child2;
        public Child2ViewModel Child2
        {
            get { return _child2; }
            set { SetProperty(ref _child2, value); }
        }

        private Child3ViewModel _child3;
        public Child3ViewModel Child3
        {
            get { return _child3; }
            set { SetProperty(ref _child3, value); }
        }
    }

    public class Child1ViewModel : MvxViewModel
    {
        public string _foo = "Hello Foo";
        public string Foo
        {
            get { return _foo; }
            set { SetProperty(ref _foo, value); }
        }

        public ICommand GoCommand => new MvxCommand(() => ShowViewModel<GrandChildViewModel>());
    }

    public class GrandChildViewModel : MvxViewModel
    {
        public string _life = "Heidi";
        public string Life
        {
            get { return _life; }
            set { SetProperty(ref _life, value); }
        }
    }

    public class Child2ViewModel : MvxViewModel
    {
        public string _bar = "Hello Bar";
        public string Bar
        {
            get { return _bar; }
            set { SetProperty(ref _bar, value); }
        }
    }

    public class Child3ViewModel : MvxViewModel
    {
        public string _oink = "Hello Oink";
        public string Oink
        {
            get { return _oink; }
            set { SetProperty(ref _oink, value); }
        }
    }
}