using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new GreetingsPage();
            //InitializeComponent();

            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children =
            //        {
            //            new Label
            //            {
            //                HorizontalTextAlignment=TextAlignment.Center,
            //                Text="Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
