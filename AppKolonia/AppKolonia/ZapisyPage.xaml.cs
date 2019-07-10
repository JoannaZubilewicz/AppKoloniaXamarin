using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppKolonia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ZapisyPage : ContentPage
	{
        UczestnikData data;

		public ZapisyPage ()
		{
			InitializeComponent ();
            data = new UczestnikData();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {   
            bool validated = true;
            if (ImieEntry.Text==null||ImieEntry.Text==string.Empty)
            {
                ImieEntry.BackgroundColor = Color.BlueViolet;
                validated = false;


            }
            if (NazwiskoEntry.Text == null || NazwiskoEntry.Text == string.Empty)
            {
                NazwiskoEntry.BackgroundColor = Color.BlueViolet;
                validated = false; 
            }
            if (AdresEntry.Text == null || AdresEntry.Text == string.Empty)
            {
                AdresEntry.BackgroundColor = Color.BlueViolet;
                validated = false;
            }
            if (UroEntry.Text == null || UroEntry.Text == string.Empty)
            {
                UroEntry.BackgroundColor = Color.BlueViolet;
                validated = false;
            }
            if (KontaktEntry.Text == null || KontaktEntry.Text == string.Empty)
            {
                KontaktEntry.BackgroundColor = Color.BlueViolet;
                validated = false; 
            }
            if (EmailEntry.Text == null || EmailEntry.Text == string.Empty)
            {
                EmailEntry.BackgroundColor = Color.BlueViolet;
                validated = false;
            }

            if (!validated)
            {
                DisplayAlert("UWAGA", "Uzupełnij formularz", "OK");
                return;
            }


            Uczestnik ucz1 = new Uczestnik()
            {
                Imie = ImieEntry.Text ,
                Nazwisko = NazwiskoEntry.Text,
                Adres = AdresEntry.Text,
                Urodziny = UroEntry.Text,
                Tel = KontaktEntry.Text,
                Email = EmailEntry.Text

            };
            data.AddUczestnik(ucz1);
            DisplayAlert("UWAGA","Dodano użytkownika","OK");
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as Entry).BackgroundColor = Color.Default;
        }
    }
}