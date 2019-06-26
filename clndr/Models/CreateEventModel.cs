using System;
using System.Collections.ObjectModel;
using clndr.DataModels;

namespace clndr.Models
{
    public class CreateEventModel
    {
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
    }
}
