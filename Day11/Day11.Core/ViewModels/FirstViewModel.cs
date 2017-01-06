using System.Collections.Generic;
using Day11.Core.Services;
using MvvmCross.Core.ViewModels;

namespace Day11.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IKittenGenesisService _kittenGenesisService;

        public FirstViewModel(IKittenGenesisService kittenGenesisService)
        {
            _kittenGenesisService = kittenGenesisService;

            var kittens = new List<Kitten>();
            for (var i = 0; i < 100; i++)
            {
                var newKitten = _kittenGenesisService.CreateNewKitten(i.ToString());
                kittens.Add(newKitten);
            }
            Kittens = kittens;
        }

        private List<Kitten> _kittens;
        public List<Kitten> Kittens
        {
            get { return _kittens; }
            set { SetProperty(ref _kittens, value); }
        }
    }
}
