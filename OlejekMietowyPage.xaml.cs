using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AptekaN
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OlejekMietowyPage : ContentPage
	{
		public OlejekMietowyPage ()
		{
			InitializeComponent ();
		}
        async void MainMenu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        void Licz(object sender, EventArgs e)
        {
            double g;
            double.TryParse(Liczba1.Text, out g);
            double ml;
            double.TryParse(Liczba2.Text, out ml);
            double krople;
            double.TryParse(Liczba3.Text, out krople);
         
            if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba2.Text))
            {
                    ml = 0.021 * krople;
                    g = 0.019 * krople;
                DisplayAlert("Dla " + Liczba3.Text + " kropel", "musisz użyć " + g + "g lub " + ml + "ml", "Zamknij");
            }
            if (string.IsNullOrWhiteSpace(Liczba2.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
            {
                krople = g * 52.631578947;
                krople = Math.Round(krople, 2);
                ml = g * 1.1;
                ml = Math.Round(ml, 3);
                DisplayAlert("Dla " + Liczba1.Text + " gram", "musisz użyć " + krople + " kropli lub " + ml + " ml", "Zamknij");
            }
            if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba2.Text))
            {
                g = krople * 0.019;
                ml = krople * 0.021;
                DisplayAlert("Dla " + Liczba3.Text + " kropel", "musisz użyć " + g + "g lub " + ml + "ml", "Zamknij");
            }
        }
    }
}