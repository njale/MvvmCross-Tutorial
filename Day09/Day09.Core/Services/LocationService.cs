using MvvmCross.Platform;
using MvvmCross.Plugins.Location;
using MvvmCross.Plugins.Messenger;

namespace Day09.Core.Services
{
    public class LocationService : ILocationService
    {
        public LocationService(IMvxLocationWatcher locationWatcher, IMvxMessenger messenger)
        {
            LocationWatcher = locationWatcher;
            _messenger = messenger;

            var options = new MvxLocationOptions { TrackingMode = MvxLocationTrackingMode.Foreground };
            LocationWatcher.Start(options, OnLocation, OnError);
        }

        public readonly IMvxLocationWatcher LocationWatcher;
        private readonly IMvxMessenger _messenger;
        
        private void OnError(MvxLocationError locationError)
        {
            Mvx.Error($"Seen location error {locationError.Code}");
        }

        private void OnLocation(MvxGeoLocation location)
        {
            var message = new LocationMessage(this, location.Coordinates.Latitude, location.Coordinates.Longitude);
            _messenger.Publish(message);
        }
    }
}
