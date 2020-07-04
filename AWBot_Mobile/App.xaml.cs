using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AWBot_Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Xamarin.Forms.PlatformConfiguration.AndroidSpecific.Application.SetWindowSoftInputModeAdjust(this, Xamarin.Forms.PlatformConfiguration.AndroidSpecific.WindowSoftInputModeAdjust.Resize);
            MainPage = new NavigationPage(new Views.BotWebViewPage());
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
