namespace Day17.Core.Services.Location
{
    public interface ILocationService
    {
        bool TryGetLatestLocation(out double latitude, out double longitude);
    }
}