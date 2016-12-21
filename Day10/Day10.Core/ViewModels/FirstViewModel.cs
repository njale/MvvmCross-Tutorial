using System.Collections.Generic;
using Day10.Core.Services;
using MvvmCross.Core.ViewModels;

namespace Day10.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IKittenDataService _kittenDataService;
        private readonly IKittenGenesissService _kittenGenesissService;

        public FirstViewModel(IKittenDataService kittenDataService, IKittenGenesissService kittenGenesissService)
        {
            _kittenDataService = kittenDataService;
            _kittenGenesissService = kittenGenesissService;
            RefreshDataCount();
            DoApplyFilter();
        }

        private string _filter;
        private List<Kitten> _kittens;
        MvxCommand _applyFilterCommand;
        MvxCommand _insertCommand;
        private int _totalCount, _countAdded;

        public string Filter
        {
            get { return _filter; }
            set { SetProperty(ref _filter, value); }
        }

        public List<Kitten> Kittens
        {
            get { return _kittens; }
            set { SetProperty(ref _kittens,  value); }
        }


        public MvxCommand ApplyFilterCommand => _applyFilterCommand ?? (_applyFilterCommand = new MvxCommand(DoApplyFilter));

        private void DoApplyFilter()
        {
            // Apply filter, get new list of kittens
            Kittens = _kittenDataService.KittensMatching(Filter);
        }

        public MvxCommand InsertCommand => _insertCommand ?? (_insertCommand = new MvxCommand(DoInsert));

        private void DoInsert()
        {
            _countAdded++;
            var kitten = _kittenGenesissService.CreateNewKitten(_countAdded.ToString());
            _kittenDataService.Insert(kitten);
            RefreshDataCount();
            DoApplyFilter();
        }

        private void RefreshDataCount()
        {
            TotalCount = _kittenDataService.Count;
        }

        public int TotalCount
        {
            get { return _totalCount; }
            set { SetProperty(ref _totalCount, value); }
        }
    }
}
