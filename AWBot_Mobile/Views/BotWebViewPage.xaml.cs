using Xamarin.Forms;

using AWBot_Mobile.Helpers;
using AWBot_Mobile.Services;

namespace AWBot_Mobile.Views
{
    public partial class BotWebViewPage : ContentPage
    {
        public BotWebViewPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var tokenExists = Application.Current.Properties.ContainsKey(Constants.TokenName);
            string token;

            if (!tokenExists)
            {
                token = await BotService.GetToken();
                Application.Current.Properties[Constants.TokenName] = token;
            }
            else
                token = Application.Current.Properties[Constants.TokenName].ToString();

            string botWebViewUrl = $"{Constants.BotUrl}?s=" + token;
            BotWebView.Source = botWebViewUrl;
        }
    }
}
