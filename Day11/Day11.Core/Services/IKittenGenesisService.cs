namespace Day11.Core.Services
{
    public interface IKittenGenesisService
    {
        Kitten CreateNewKitten(string extra = "");
    }
}