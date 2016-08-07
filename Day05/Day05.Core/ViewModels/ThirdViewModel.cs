using MvvmCross.Core.ViewModels;

namespace Day05.Core.ViewModels
{
    public class ThirdViewModel : MvxViewModel
    {
        public void Init(string question)
        {
            TheAnswer = "I dont know " + question;
        }
        private string _theAnswer = "Njål Eide";
        public string TheAnswer
        {
            get { return _theAnswer; }
            set { SetProperty(ref _theAnswer, value); }
        }
    }
}