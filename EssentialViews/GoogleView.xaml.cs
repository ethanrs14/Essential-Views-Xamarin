using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EssentialViews
{
    public partial class GoogleView : ContentPage
    {
        public GoogleView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
