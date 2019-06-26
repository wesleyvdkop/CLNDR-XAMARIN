using System;
namespace clndr.DataModels
{
    public class UserData
    {

        private string firstname;
        private string lastname;
        private string jobTitle;
        private string location;

        public UserData()
        {
        }

        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
            }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set
            {
                jobTitle = value;
            }
        }

        public string Location
        {
            get { return location; }
            set
            {
                location = value;
            }
        }
    }
}
