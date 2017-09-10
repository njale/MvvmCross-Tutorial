using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using System;


namespace Day23.Core.ViewModels
{
	public class MainViewModel : MvxViewModel
	{
		public MainViewModel()
		{
		}

		public override Task Initialize()
		{
			//TODO: Add starting logic here

			return base.Initialize();
		}

		private string _hello = "Hello";
		public string Hello
		{
			get { return _hello; }
			set
			{
				SetProperty(ref _hello, value);
				RaisePropertyChanged(() => Combined);
			}
		}

		private string _another = "MvvmCross";
		public string Another
		{
			get { return _another; }
			set
			{
				SetProperty(ref _another, value); 
				RaisePropertyChanged(()=>Combined);
			}
		}

		public string Combined
		{
			get { return _hello + " " + _another; }
		}

		private DateTime _theDate = DateTime.Today;
		public DateTime TheDate
		{
			get { return _theDate; }
			set { SetProperty(ref _theDate, value); }
		}

		private bool _option1;
		public bool Option1
		{
			get { return _option1; }
			set { SetProperty(ref _option1, value); }
		}

	}
}