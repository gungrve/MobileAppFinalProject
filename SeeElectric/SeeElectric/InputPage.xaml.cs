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
    public partial class Page1 : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public Page1()
        {
            InitializeComponent();
        }

        void onDatePickerSelected(object sender, DateChangedEventArgs e)
        {
            var selectedDate = e.NewDate.ToString();
        }

        async void OnSaveRecord(object sender, EventArgs e)
        {
            var selectdate = selectDate.Date.ToString("dd/MM/yyyy");
            var price = Double.Parse(Price.Text);
            var current = Double.Parse(Current.Text);
            string app = App.Text;
            var appTime = Double.Parse(AppTime.Text);
            await firebaseHelper.AddRecord(selectdate, price, current, app, appTime);

            await DisplayAlert("Record Saved", "Your Electricity info has been saved", "OK");

        }

        private async void homePg(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}