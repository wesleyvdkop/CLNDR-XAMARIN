using System;
using clndr.Views;
using Microsoft.Identity.Client;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace clndr
{
    public partial class App : Application
    {
        //public static string[] Scopes = { "User.Read" };
        //IPublicClientApplication app;
        //string clientId = "0b6667b2-b6ac-4666-bb94-8684080ab9cb";

        public App()
        {
            //InitializeComponent();

            //app = PublicClientApplicationBuilder.Create(clientId)
            //    .WithIosKeychainSecurityGroup("com.evbg.clndr")
            //    .Build();

            //var content = new LoginView();
            //MainPage = new NavigationPage(content);
            MainPage = new NavigationPage(new TabNavigation());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
