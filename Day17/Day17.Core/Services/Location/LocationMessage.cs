using MvvmCross.Plugins.Messenger;

namespace Day17.Core.Services.Location
{
    public class LocationMessage : MvxMessage
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public LocationMessage(object sender, double latitude, double longitude) : base(sender)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}