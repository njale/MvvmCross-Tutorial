namespace Day10.Core.Services
{
    public interface IKittenGenesissService
    {
        Kitten CreateNewKitten(string extra = "");
    }
}