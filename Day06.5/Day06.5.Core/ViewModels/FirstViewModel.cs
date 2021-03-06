using System.Collections.Generic;
using Day065.Core.Model;
using Day065.Core.Services;
using MvvmCross.Core.ViewModels;

namespace Day065.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IBooksService _booksService;
        private string _searchTerm;
        private List<BookSearchItem> _results;

        public FirstViewModel(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                SetProperty(ref _searchTerm, value);
                Update();
            }
        }

        public List<BookSearchItem> Results
        {
            get { return _results; }
            set { SetProperty(ref _results, value); }
        }

        private void Update()
        {
            _booksService.StartSearchAsync(SearchTerm, result => Results = result.Items, null);
        }
    }
}
