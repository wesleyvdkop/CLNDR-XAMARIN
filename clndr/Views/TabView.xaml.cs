using System;
using System.Collections.Generic;
using Syncfusion.XForms.TabView;
using Xamarin.Forms;

namespace clndr.Views
{
    public partial class TabView : ContentPage
    {
        private SfTabView tabView;

        public TabView()
        {
            InitializeComponent();
            tabView = new SfTabView();
            this.Content = tabView;
        }
    }
}
