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
	public partial class WyswietlFormularzPage : ContentPage
	{
        private UczestnikData data;

		public WyswietlFormularzPage ()
		{
			InitializeComponent ();
            data = new UczestnikData();
            BindingContext = data;
		}

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            bool agreed = await DisplayAlert("Usuwanie", "Czy napewno usunąć?", "OK", "Anuluj");
            if(agreed)
                data.Usuwanie_Listy();

        }
    }
}