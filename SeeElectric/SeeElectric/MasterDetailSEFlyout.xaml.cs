using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeeElectric
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailSEFlyout : ContentPage
    {
        public ListView ListView;

        public MasterDetailSEFlyout()
        {
            InitializeComponent();

            BindingContext = new MasterDetailSEFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailSEFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailSEFlyoutMenuItem> MenuItems { get; set; }

            public MasterDetailSEFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailSEFlyoutMenuItem>(new[]
                {
                    new MasterDetailSEFlyoutMenuItem { Id = 0, Title = "Current Usage", TargetType=typeof(MainPage)  },
                    new MasterDetailSEFlyoutMenuItem { Id = 1, Title = "Insert your bill information", TargetType=typeof(Page1) },
                    new MasterDetailSEFlyoutMenuItem { Id = 2, Title = "Annual Electricity Report", TargetType=typeof(AnnualReport) },
                    new MasterDetailSEFlyoutMenuItem { Id = 3, Title = "Electrical Appliance Usage", TargetType=typeof(ApplianceReport) },
                    new MasterDetailSEFlyoutMenuItem { Id = 4, Title = "Electric Saving Tips", TargetType=typeof(TipSelect) },
                    new MasterDetailSEFlyoutMenuItem { Id = 4, Title = "About us", TargetType=typeof(AboutPage) }
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}