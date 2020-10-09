using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            Content = new Label
            {
                Text = "Greetings, Xamarin.Forms!"
            };

#if __IOS__
            Padding = new Thickness(0, 20, 0, 0);
#endif

            Padding = GetPadding();
        }

        private static Thickness GetPadding()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    return new Thickness(5, 5, 5, 0);
                default:
                    return new Thickness(5, 5, 5, 0);
            }
        }
    }
}