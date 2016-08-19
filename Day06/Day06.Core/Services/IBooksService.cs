using System;
using Day06.Core.Model;

namespace Day06.Core.Services
{
    public  interface IBooksService
    {
        void StartSearchAsync(string whatFor, Action<BookSearchResult> successAction, Action<Exception> errorAction);
    }
}