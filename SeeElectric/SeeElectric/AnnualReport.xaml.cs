using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace SeeElectric
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnnualReport : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public AnnualReport()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            displayRecord.ItemsSource = await firebaseHelper.GetAllElectricRecord();
        }

        private async void appRpt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ApplianceReport());
        }

        private async void homePg(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}