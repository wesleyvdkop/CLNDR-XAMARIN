using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
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
            _client = new RestClient("https://4a60a5a4.ngrok.io/v1");
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

        public IRestResponse CreateCalendarEvent(string officeId, CalendarCreateDto calendarEvent)
        {
            var request = new RestRequest($"/office/{officeId}/calendarEvent", Method.POST);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new {
                startDay = calendarEvent.StartDay,
                data = calendarEvent.Data,
                type = calendarEvent.Type,
                day = calendarEvent.Day,
            });

            var response = _client.Execute(request);

            Console.WriteLine(response);

            return response;
        }
    }
}
