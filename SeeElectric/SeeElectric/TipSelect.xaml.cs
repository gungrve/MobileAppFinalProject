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
    public partial class TipSelect : ContentPage
    {
        public TipSelect()
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

        private async void tip1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tips1());
        }
        private async void tip2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tips2());
        }
        private async void tip3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tips3());
        }

        private async void tip4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tips4());
        }
        private async void tip5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tips5());
        }
        private async void tip6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tips6());
        }
        private async void tip7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tips7());
        }
    }
}