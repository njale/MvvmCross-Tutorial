using System;

namespace Day07.Core.Services
{
    public interface ISimpleRestService
    {
        void MakeRequest<T>(string requestUrl, string verb, Action<T> succesAction,
            Action<Exception> errorAction);
    }
}