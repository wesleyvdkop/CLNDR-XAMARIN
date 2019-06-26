using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace clndr.Views
{
    public partial class ProfileView : ContentPage
    {
        public ProfileView()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
