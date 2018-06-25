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
	public partial class WitaminyPage : ContentPage
	{
		public WitaminyPage ()
		{
			InitializeComponent ();
		}
        async void MainMenu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
  
        void InitPickerWitaminy(object sender, EventArgs e)
        {
            double liczba1;
            double liczba2;
            double liczba3;

            double.TryParse(Liczba1.Text, out liczba1);
            double.TryParse(Liczba2.Text, out liczba2);
            double.TryParse(Liczba3.Text, out liczba3);

            double ml = 0;
            double g;
            double kropli;

            if (picWitaminy.Items[picWitaminy.SelectedIndex] == "Witamina A Hasco")
            {
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba2.Text))
                {
                    ml = liczba3  / 28;
                    g = ml * 1.15;
                    DisplayAlert("Witamina A Hasco - dla " + Liczba3.Text + " kropli", "musisz użyć " + ml + "ml lub " + g + "g", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba2.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    ml = 0.85 * liczba1; 
                    kropli = ml * 28;
                    DisplayAlert("Witamina A Hasco - dla " + Liczba3.Text + " gram", "musisz użyć " + ml + "ml lub " + kropli + "kropli", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    g = 1.15 * liczba2; 
                    kropli = liczba2 * 28;
                    DisplayAlert("Witamina A Hasco - dla " + Liczba3.Text + " kropel", "musisz użyć " + g + "g lub " + kropli + "kropli", "Zamknij");
                }      
            }
            if (picWitaminy.Items[picWitaminy.SelectedIndex] == "Witamina A Medana")
            {
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba2.Text))
                {
                    ml = liczba3 / 30;
                    g = ml * 1.08;
                    DisplayAlert("Witamina A Medana - dla " + Liczba3.Text + " kropli", "musisz użyć " + ml + "ml lub " + g + "g", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba2.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    ml = 0.92 * liczba1;
                    kropli = ml * 30;
                    DisplayAlert("Witamina A Medana - dla " + Liczba3.Text + " gram", "musisz użyć " + ml + "ml lub " + kropli + "kropli", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    g = 1.08 * liczba2;
                    kropli = liczba2 * 30;
                    DisplayAlert("Witamina A Medama - dla " + Liczba3.Text + " kropel", "musisz użyć " + g + "g lub " + ml + "ml", "Zamknij");
                }
            }
            if (picWitaminy.Items[picWitaminy.SelectedIndex] == "Witamina E Hasco")
            {
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba2.Text))
                {
                    ml = liczba3 / 30;
                    g = ml * 0.93;
                    DisplayAlert("Witamina E Hasco - dla " + Liczba3.Text + " kropli", "musisz użyć " + ml + "ml lub " + g + "g", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba2.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    ml = 1.07 * liczba1;
                    kropli = ml * 30;
                    DisplayAlert("Witamina E Hasco - dla " + Liczba3.Text + " gram", "musisz użyć " + ml + "ml lub " + kropli + "kropli", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    g = 0.93 * liczba2;
                    kropli = liczba2 * 30;
                    DisplayAlert("Witamina E Hasco - dla " + Liczba3.Text + " kropel", "musisz użyć " + g + "g lub " + ml + "ml", "Zamknij");
                }  
            }
            if (picWitaminy.Items[picWitaminy.SelectedIndex] == "Witamina E Medana")
            {
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba2.Text))
                {
                    ml = liczba3 / 27;
                    g = ml * 0.93;
                    DisplayAlert("Witamina E Medana - dla " + Liczba3.Text + " kropli", "musisz użyć " + ml + "ml lub " + g + "g", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba2.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    ml = 1.07 * liczba1;
                    kropli = ml * 27;
                    DisplayAlert("Witamina E Medana - dla " + Liczba3.Text + " gram", "musisz użyć " + ml + "ml lub " + kropli + "kropli", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    g = 0.93 * liczba2;
                    kropli = liczba2 * 27;
                    DisplayAlert("Witamina E Medana - dla " + Liczba3.Text + " kropel", "musisz użyć " + g + "g lub " + ml + "ml", "Zamknij");
                }
            }
            if (picWitaminy.Items[picWitaminy.SelectedIndex] == "Witamina A + D3")
            {
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba2.Text))
                {
                    ml = liczba3 / 34;
                    g = ml * 1.09;
                    DisplayAlert("Witamina A + D3 - dla " + Liczba3.Text + " kropli", "musisz użyć " + ml + "ml lub " + g + "g", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba2.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    ml = 0.91 * liczba1;
                    kropli = ml * 34;
                    DisplayAlert("Witamina A + D3 - dla " + Liczba3.Text + " gram", "musisz użyć " + ml + "ml lub " + kropli + "kropli", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    g = 1.09 * liczba2;
                    kropli = liczba2 * 34;
                    DisplayAlert("Witamina A + D3 - dla " + Liczba3.Text + " kropel", "musisz użyć " + g + "g lub " + ml + "ml", "Zamknij");
                }
            }
            if (picWitaminy.Items[picWitaminy.SelectedIndex] == "Witamina D3 (DEVICAD)")
            {
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba2.Text))
                {
                    ml = liczba3 / 30;
                    g = ml * 1.1;
                    DisplayAlert("Witamina D3 (DEVICAD) - dla " + Liczba3.Text + " kropli", "musisz użyć " + ml + "ml lub " + g + "g", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba2.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    ml = 0.90 * liczba1;
                    kropli = ml * 30;
                    DisplayAlert("Witamina D3 (DEVICAD) - dla " + Liczba3.Text + " gram", "musisz użyć " + ml + "ml lub " + kropli + "kropli", "Zamknij");
                }
                if (string.IsNullOrWhiteSpace(Liczba1.Text) && string.IsNullOrWhiteSpace(Liczba3.Text))
                {
                    g = 1.1 * liczba2;
                    kropli = liczba2 * 30;
                    DisplayAlert("Witamina D3 (DEVICAD) - dla " + Liczba3.Text + " kropel", "musisz użyć " + g + "g lub " + ml + "ml", "Zamknij");
                }
            }
        }
    }
}