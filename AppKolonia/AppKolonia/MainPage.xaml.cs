using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppKolonia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            

            //if (profiles.Contains(ConnectionProfile.WiFi))
            //{
            //    lblNetworkProfile.Text = profiles.FirstOrDefault().ToString();
            //}
            //else
            //{
            //    lblNetworkProfile.Text = profiles.FirstOrDefault().ToString();
            //}
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ZapisyPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ONasPage());

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KontaktPage());

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WyswietlFormularzPage());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                lblNetworkStatus.Text = "Internet jest dostepny";
            }
            else
            {
                lblNetworkStatus.Text = "Internet nie jest dostępny";
            }
        }
    }
}
