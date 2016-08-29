using System;
using System.Collections.Generic;
using System.Threading;
using Day07.Core.Model;
using Day07.Core.Services;
using MvvmCross.Core.ViewModels;

namespace Day07.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public FirstViewModel(IBooksService booksService)
        {
            _booksService = booksService;
        }

        private readonly object _lock = new object();
        private readonly IBooksService _booksService;
        private string _searchTerm;
        private List<BookSearchItem> _results;
        private bool _isLoading;
        private Timer _timer;

        public Timer Timer
        {
            get { return _timer ?? (_timer = new Timer(OnTimerTick, null, TimeSpan.FromSeconds(1), TimeSpan.Zero)); }
            set { _timer = value; }
        }

        public bool IsLoading
        {
            get { return _isLoading; }
            set { SetProperty(ref _isLoading, value); }
        }

        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                SetProperty(ref _searchTerm, value);
                ScheduleUpdate();
            }
        }

        public List<BookSearchItem> Results
        {
            get { return _results; }
            set { SetProperty(ref _results, value); }
        }

        private void ScheduleUpdate()
        {
            lock (_lock)
            {
                Timer.Change(TimeSpan.FromSeconds(1), TimeSpan.Zero);
            }
        }

        private void OnTimerTick(object state)
        {
            lock (_lock)
            {
                _timer?.Dispose();
                _timer = null;
                Update();
            }
        }

        private void Update()
        {
            IsLoading = true;
            _booksService.StartSearchAsync(SearchTerm,
                result =>
                {
                    IsLoading = false;
                    Results = result.Items;
                }, 
                error => IsLoading = false);
        }
    }
}
