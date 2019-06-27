using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using clndr.Api;
using clndr.Api.Models;
using clndr.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace clndr.Repositories
{
    public class EventListItemRepository
    {
        private ObservableCollection<CalendarModel> eventListItem;
        private ApiClient apiClient = new ApiClient();

        private List<CalendarEventDto> calendarEvents = new List<CalendarEventDto>();

        public ObservableCollection<CalendarModel> EventListItem
        {
            get { return eventListItem; }
            set { eventListItem = value; }
        }

        private Command command;

        public EventListItemRepository()
        {
            eventListItem = new ObservableCollection<CalendarModel>();

            command = new Command(async () => await GenerateEventsAsync());
            command.Execute(null);
        }

        public async System.Threading.Tasks.Task GenerateEventsAsync()
        {
            eventListItem.Clear();
            calendarEvents = await apiClient.GetTodaysCalendarEvents("5c9cc5e521b8387d32991a5c");

            foreach (var calenderEvent in calendarEvents)
            {
                EventTypes type = (EventTypes)Enum.Parse(typeof(EventTypes), calenderEvent.Type.ToString());

                string json = JsonConvert.SerializeObject(calenderEvent.Data);

                object data = calenderEvent.Data;
                JObject d = JObject.FromObject(data);

                eventListItem.Add(new CalendarModel()
                {
                    EventType = type.ToString(),
                    EventDesc = d.GetValue("name").ToString()
                });
            }
        }
    }
}
