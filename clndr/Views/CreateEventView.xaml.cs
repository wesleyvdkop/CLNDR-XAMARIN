using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace clndr.Views
{
    public partial class CreateEventView : ContentPage
    {
        public CreateEventView()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Handle_Create_Clicked(object sender, System.EventArgs e)
        {
            var dateValue = date.Date;
            var typeValue = type.Text;
            var descValue = desc.Text;

            if (dateValue != null &&
                typeValue != null &&
                descValue != null)
            {
                dateField.HasError = false;
                typeField.HasError = false;
                descField.HasError = false;

                type.Text = null;
                desc.Text = null;

                await Navigation.PushAsync(new CalendarView());
            } else {
                dateField.HasError = true;
                typeField.HasError = true;
                descField.HasError = true;
            }
        }
    }
}
