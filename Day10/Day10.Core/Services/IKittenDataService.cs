using System.Collections.Generic;

namespace Day10.Core.Services
{
    public interface IKittenDataService
    {
        List<Kitten> KittensMatching(string nameFilter);
        void Insert(Kitten kitten);
        void Update(Kitten kitten);
        void Delete(Kitten kitten);
        int Count { get; }
    }
}