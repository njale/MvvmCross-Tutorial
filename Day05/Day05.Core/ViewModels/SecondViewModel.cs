using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace Day05.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        private string _name = "Njål Eide";
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private ICommand _goThirdCommand;
        public ICommand GoThirdCommand
        {
            get { return _goThirdCommand = _goThirdCommand ?? new MvxCommand(DoGoThird); }
        }

        private void DoGoThird()
        {
            ShowViewModel<ThirdViewModel>(new {question = "What time is it?"});
        }
    }
}
