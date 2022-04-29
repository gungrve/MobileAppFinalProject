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
    public partial class Tips3 : ContentPage
    {
        public Tips3()
        {
            InitializeComponent();
        }
        private async void homePg(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}