using MvvmCross.Plugins.Messenger;

namespace Day09.Core.Services
{
    public class LocationMessage : MvxMessage
    {
        public LocationMessage(object sender, double latiture, double longtitude) : base(sender)
        {
            Latitude = latiture;
            Longtitude = longtitude;
        }

        public double Longtitude;
        public double Latitude;
    }
}