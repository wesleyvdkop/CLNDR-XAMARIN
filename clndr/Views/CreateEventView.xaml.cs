using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using clndr.Api;
using clndr.Api.Models;
using clndr.DataModels;
using clndr.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace clndr.Views
{
    public partial class CreateEventView : ContentPage
    {

        private ApiClient apiClient = new ApiClient();
        private CalendarCreateDto calendarCreateEvent;
        private CreateEventModel createEventModel = new CreateEventModel();

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
                calendarCreateEvent = new CalendarCreateDto()
                {
                    StartDay = dateValue,
                    Type = 6,
                    Data = new { name = descValue },
                    Day = true
                };

                createEventModel.CreateCalendarEvent(calendarCreateEvent);

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
