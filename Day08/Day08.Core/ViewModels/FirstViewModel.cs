using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Plugins.Location;

namespace Day08.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public FirstViewModel(IMvxLocationWatcher locationWatcher)
        {
            LocationWatcher = locationWatcher;
            LocationWatcher.Start(new MvxLocationOptions(), OnLocation, OnError);
        }

        public readonly IMvxLocationWatcher LocationWatcher;
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

        private void OnError(MvxLocationError locationError)
        {
            Mvx.Error($"Seen location error {locationError.Code}");
        }

        private void OnLocation(MvxGeoLocation location)
        {
            Latitude = location.Coordinates.Latitude;
            Longtitude = location.Coordinates.Longitude;
        }
    }
}
