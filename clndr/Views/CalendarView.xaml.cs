using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace clndr.Views
{
    public partial class CalendarView : ContentPage
    {
        public CalendarView()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Handle_OnDateCellHolding(object sender, System.EventArgs e)
        {
            // Do nothing
        }
    }
}
