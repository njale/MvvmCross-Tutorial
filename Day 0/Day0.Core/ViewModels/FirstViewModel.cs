using MvvmCross.Core.ViewModels;

namespace Day0.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                SetProperty(ref _firstName, value);
                RaisePropertyChanged(()=>FullName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                SetProperty(ref _lastName, value);
                RaisePropertyChanged(() => FullName);
            }
        }

        public string FullName => $"{FirstName} {LastName}";
    }
}
