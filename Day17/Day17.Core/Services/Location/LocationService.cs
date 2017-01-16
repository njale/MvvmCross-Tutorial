using MvvmCross.Platform;
using MvvmCross.Plugins.Location;
using MvvmCross.Plugins.Messenger;

namespace Day17.Core.Services.Location
{
    public class LocationService : ILocationService
    {
        private readonly IMvxLocationWatcher _locationWatcher;
        private readonly IMvxMessenger _messenger;
        private MvxGeoLocation _lastKnowLocation;
        private readonly object _lock = new object();

        public LocationService(IMvxLocationWatcher locationWatcher, IMvxMessenger messenger)
        {
            _locationWatcher = locationWatcher;
            _messenger = messenger;
            _locationWatcher.Start(new MvxLocationOptions(), OnSuccess, OnError);
        }

        private void OnSuccess(MvxGeoLocation geoLocation)
        {
            lock (_lock)
            {
                _lastKnowLocation = geoLocation;
            }

            var message = new LocationMessage(this, geoLocation.Coordinates.Latitude, geoLocation.Coordinates.Longitude);
            _messenger.Publish(message);
        }

        private void OnError(MvxLocationError locationError)
        {
            Mvx.Warning("Error seen during location {0}", locationError.Code);
        }

        public bool TryGetLatestLocation(out double latitude, out double longitude)
        {
            lock (_lock)
            {
                if (_lastKnowLocation == null)
                {
                    latitude = longitude = 0;
                    return false;
                }

                latitude = _lastKnowLocation.Coordinates.Latitude;
                longitude= _lastKnowLocation.Coordinates.Longitude;
                return true;
            }
        }
    }
}
