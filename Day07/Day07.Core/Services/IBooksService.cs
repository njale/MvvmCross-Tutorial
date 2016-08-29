using System;
using Day07.Core.Model;

namespace Day07.Core.Services
{
    public  interface IBooksService
    {
        void StartSearchAsync(string whatFor, Action<BookSearchResult> successAction, Action<Exception> errorAction);
    }
}