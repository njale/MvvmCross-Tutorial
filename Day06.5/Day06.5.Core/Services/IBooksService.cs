using System;
using Day065.Core.Model;

namespace Day065.Core.Services
{
    public  interface IBooksService
    {
        void StartSearchAsync(string whatFor, Action<BookSearchResult> successAction, Action<Exception> errorAction);
    }
}