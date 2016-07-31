namespace Day02.Core.Services
{
    public interface IKittenGenesisService
    {
        Kitten CreateNewKitten(string extra = "");
    }
}