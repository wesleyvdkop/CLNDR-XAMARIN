using System;
using System.Collections.Generic;
using clndr.Models;
using Xamarin.Forms;

namespace clndr.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginModel LoginModel;

        private string userEmail = "Wesley.vanderkop@everbridge.com";
        private string userPassword = "Test123";

        public LoginView()
        {
            InitializeComponent();
            LoginModel = new LoginModel();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var emailValue = email.Text;
            var passwordValue = password.Text;

            if ( (emailValue == userEmail) && (passwordValue == userPassword))
            {
                await Navigation.PushAsync(new TabNavigation());
            } else
            {
                emailField.HasError = true;
                passwordField.HasError = true;
            }
        }
    }
}
