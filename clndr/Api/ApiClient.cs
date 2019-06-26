using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using clndr.Api.Models;
using RestSharp;

namespace clndr.Api
{
    public class ApiClient
    {
        private RestClient _client;

        public ApiClient()
        {
            _client = new RestClient("https://54dd727d.ngrok.io/v1");
        }

        private Task<T> AsyncCall<T>(string url, Method method) where T : new()
        {
            var taskCompletionSource = new TaskCompletionSource<T>();
            _client.ExecuteAsync<T>(new RestRequest(url, method, DataFormat.Json),
            response =>
            {
                HandleException(response);
                taskCompletionSource.SetResult(response.Data);
            });
            return taskCompletionSource.Task;
        }

        private void HandleException(IRestResponse response)
        {
            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public Task<List<CalendarEventDto>> GetTodaysCalendarEvents(string officeId)
        {
            return AsyncCall<List<CalendarEventDto>>($"/office/{officeId}/calendarEvent", Method.GET);
        }
    }
}
