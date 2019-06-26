using System;
using System.ComponentModel;

namespace clndr.Models
{
    public class CalendarModel : INotifyPropertyChanged
    {
        public CalendarModel()
        {
        }

        private string eventType;
        private string eventDesc;

        public string EventType
        {
            get => eventType;
            set
            {
                eventType = value;
                OnPropertyChanged(nameof(EventType));
            }
        }

        public string EventDesc
        {
            get => eventDesc;
            set
            {
                eventDesc = value;
                OnPropertyChanged(nameof(EventDesc));
            }
        }

        private void OnPropertyChanged(string value)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
