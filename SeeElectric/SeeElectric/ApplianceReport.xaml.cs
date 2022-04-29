using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeeElectric
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplianceReport : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public ApplianceReport()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            displayRecord.ItemsSource = await firebaseHelper.GetAllElectricRecord();
        }
        private async void homePg(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void annRpt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnnualReport());
        }
    }
}