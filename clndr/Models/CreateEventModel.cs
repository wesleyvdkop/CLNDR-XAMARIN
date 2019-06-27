using System;
using System.Collections.ObjectModel;
using clndr.Api;
using clndr.Api.Models;
using clndr.DataModels;

namespace clndr.Models
{
    public class CreateEventModel
    {
        private ApiClient apiClient = new ApiClient();

        private CreateEventData createEventData;
        public CreateEventData CreateEventData
        {
            get { return this.createEventData; }
            set { this.createEventData = value; }
        }

        private ObservableCollection<string> types;
        public ObservableCollection<string> Types

        {

            get { return types; }

            set { types = value; }

        }

        public CreateEventModel()
        {
            this.createEventData = new CreateEventData();

            Types = new ObservableCollection<string>();

            Types.Add("Birthday");
            Types.Add("Year of service");
            Types.Add("Out of Office");
            Types.Add("Holiday");
            Types.Add("Other");
        }

        public bool CreateCalendarEvent(CalendarCreateDto calendarCreateEvent)
        {
            try
            {
                apiClient.CreateCalendarEvent("5c9cc5e521b8387d32991a5c", calendarCreateEvent);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);

                return false;
            }
        }
    }
}
