using System;
using System.Collections.ObjectModel;
using clndr.Models;

namespace clndr.Repositories
{
    public class UserRepository
    {

        private ObservableCollection<ProfileModel> userProfile;

        public ObservableCollection<ProfileModel> UserProfile
        {
            get { return userProfile; }
            set { userProfile = value; }
        }

        public UserRepository()
        {
            GenerateEvents();
        }

        internal void GenerateEvents()
        {
            userProfile = new ObservableCollection<ProfileModel>();
            userProfile.Add(new ProfileModel() {
                Firstname = "BirthDay",
                Lastname = "Wesley van der Kop",
                JobTitle = "Software Engineer",
                Location = "Tilburg" });
        }
    }
}
