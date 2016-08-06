using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace Day05.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private string _hello = "Hello";
        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }

        private ICommand _myCommand;
        public ICommand MyCommand
        {
            get
            {
                _myCommand = _myCommand ?? new MvxCommand(DoMyCommand);
                return _myCommand;
            }
        }

        private void DoMyCommand()
        {
            Hello = Hello + " World";
        }

        private ICommand _goSecondCommand;
        public ICommand GoSecondCommand
        {
            get { return _goSecondCommand = _goSecondCommand ?? new MvxCommand(DoGoSecond); }
        }

        private void DoGoSecond()
        {
            ShowViewModel<SecondViewModel>();
        }
    }

}
