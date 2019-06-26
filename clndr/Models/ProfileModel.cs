using System;
using System.ComponentModel;

namespace clndr.Models
{
    public class ProfileModel : INotifyPropertyChanged
    {
        public ProfileModel()
        {
        }

        private string firstname;
        private string lastname;
        private string jobTitle;
        private string location;

        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                OnPropertyChanged(nameof(Firstname));
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set
            {
                jobTitle = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }

        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }

        private void OnPropertyChanged(string value)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
