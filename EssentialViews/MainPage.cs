using System;
using Xamarin.Forms;

namespace EssentialViews
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            var navigationPageGoogle = new NavigationPage(new GoogleView());
            navigationPageGoogle.Title = "Google";
            var navigationPageYoutube = new NavigationPage(new YoutubeView());
            navigationPageYoutube.Title = "Youtube";
            var navigationPageFacebook = new NavigationPage(new FacebookView());
            navigationPageFacebook.Title = "Facebook";

            var navigationPageTwitter = new NavigationPage(new TwitterView());
            navigationPageTwitter.Title = "Twitter";


            //navigationPage.Icon = "schedule.png";
            //navigationPage.Title = "Schedule";

            Children.Add(navigationPageGoogle);
            Children.Add(navigationPageYoutube);
            Children.Add(navigationPageFacebook);
            Children.Add(navigationPageTwitter);

        }
    }
}
