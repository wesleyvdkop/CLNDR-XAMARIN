using clndr.Api;
using clndr.Api.Models;
using clndr.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
namespace clndr.UnitTest
{
    [TestFixture()]
    public class CalendarEvent
    {
        private ApiClient apiClient = new ApiClient();
        private CreateEventModel createEventModel = new CreateEventModel();
        private RestClient _client;

        public CalendarEvent()
        {
            _client = new RestClient("https://54dd727d.ngrok.io/v1");
        }

        [Test()]
        public void Create()
        {
            // Arrange
            var calendarEvent = new CalendarCreateDto()
            {
                StartDay = DateTime.Now,
                Type = 6,
                Data = new { name = "Test create event" },
                Day = true
            };
            var officeId = "5c9cc5e521b8387d32991a5c";

            // Act
            var returnedEvent = createEventModel.CreateCalendarEvent(calendarEvent);


            // Assert
            Assert.IsTrue(returnedEvent);
        }

        [Test()]
        public void Get()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(1, 1);
        }
    }
}
