using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace clndr.Views
{
    public partial class CalendarView : ContentPage
    {

        private Repositories.EventListItemRepository eventListItemRepository;

        public CalendarView()
        {
            InitializeComponent();
            eventListItemRepository = new Repositories.EventListItemRepository();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Handle_OnDateCellHolding(object sender, System.EventArgs e)
        {
            // Do nothing
        }
    }
}
