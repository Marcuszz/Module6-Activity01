using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PD6_Module06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectivityPage : ContentPage
    {
        public ConnectivityPage()
        {
            InitializeComponent();
        }

        private void Connectivity_Clicked(object sender, EventArgs e)
        {
            if(Connectivity.NetworkAccess != NetworkAccess.None)
            {
                DisplayAlert("No Internet", "Please Turn On Wifi", "Ok");
                return;
            }
        }
    }
}