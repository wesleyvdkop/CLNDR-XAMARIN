using System;

using Xamarin.Forms;

namespace clndr.Views
{
    public class Login : ContentPage
    {
        public Login()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

