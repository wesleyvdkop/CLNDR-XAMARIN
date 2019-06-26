using System;

namespace clndr.DataModels
{
    public class CreateEventData
    {
        private DateTime? date;
        private string type;
        private string desc;

        public CreateEventData()
        {

        }

        public DateTime? Date
        {
            get { return date; }
            set
            {
                date = value;
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }

        public string Desc
        {
            get { return desc; }
            set
            {
                desc = value;
            }
        }
        
    }
}
