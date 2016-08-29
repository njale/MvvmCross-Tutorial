using System;
using Day07.Core.Model;

namespace Day07.Core.Services
{
    public class BooksService : IBooksService
    {
        private readonly ISimpleRestService _simpleRestService;

        public BooksService(ISimpleRestService simpleRestService)
        {
            _simpleRestService = simpleRestService;
        }

        public void StartSearchAsync(string whatFor, Action<BookSearchResult> successAction, Action<Exception> errorAction)
        {
            string address = $"https://www.googleapis.com/books/v1/volumes?q={Uri.EscapeDataString(whatFor)}";
            _simpleRestService.MakeRequest(address, "GET", successAction, errorAction);
        }
    }
}
