using System;
using System.IO;
using System.Net;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;

namespace Day07.Core.Services
{
    public class SimpleRestService : ISimpleRestService
    {
        public SimpleRestService(IMvxJsonConverter jsonConverter)
        {
            _jsonConverter = jsonConverter;
        }

        private readonly IMvxJsonConverter _jsonConverter;


        public void MakeRequest<T>(string requestUrl, string verb, Action<T> succesAction, Action<Exception> errorAction)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Method = verb;
            request.Accept = "application/json";

            MakeRequest(request,
                (response) =>
                {
                    try
                    {
                        T toReturn = Deserialize<T>(response);
                        succesAction(toReturn);
                    }
                    catch (Exception ex)
                    {
                        errorAction?.Invoke(ex);
                    }
                },
                error => errorAction?.Invoke(error));
        }

        private void MakeRequest(HttpWebRequest request, Action<string> successAction, Action<Exception> errorAction)
        {
            request.BeginGetResponse(token =>
            {
                GetResponse(request, successAction, errorAction, token);
            }, null);
        }

        private static void GetResponse(HttpWebRequest request, Action<string> successAction, Action<Exception> errorAction, IAsyncResult token)
        {
            try
            {
                using (var response = request.EndGetResponse(token))
                {
                    using (var stream = response.GetResponseStream())
                    {
                        var reader = new StreamReader(stream);
                        successAction(reader.ReadToEnd());
                    }
                }
            }
            catch (WebException ex)
            {
                Mvx.Error("Error: {0} when making {1} request to {2}", ex.Message, request.Method, request.RequestUri);
                errorAction?.Invoke(ex);
            }
        }

        private T Deserialize<T>(string responseBody)
        {
            var toReturn = _jsonConverter.DeserializeObject<T>(responseBody);
            return toReturn;
        }


    }
}
