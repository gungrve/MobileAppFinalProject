using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeeElectric
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void annRpt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnnualReport());
        }

        private async void appRpt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ApplianceReport());
        }
    }
}
