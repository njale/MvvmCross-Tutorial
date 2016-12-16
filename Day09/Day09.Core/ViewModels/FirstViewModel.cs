using System;
using Day09.Core.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;

namespace Day09.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public FirstViewModel(ILocationService locationService, IMvxMessenger messenger)
        {
            LocationService = locationService;
            _token = messenger.Subscribe<LocationMessage>(OnLocationMessage);
        }

        private void OnLocationMessage(LocationMessage locationMessage)
        {
            Latitude = locationMessage.Latitude;
            Longtitude = locationMessage.Longtitude;
        }

        public readonly ILocationService LocationService;
        private readonly MvxSubscriptionToken _token; // Must keep a ref to avoid GC
        private double _longtitude;
        private double _latitude;
        
        public double Latitude
        {
            get { return _latitude; }
            set { SetProperty(ref _latitude, value); }
        }

        public double Longtitude
        {
            get { return _longtitude; }
            set { SetProperty(ref _longtitude, value); }
        }
    }
}
