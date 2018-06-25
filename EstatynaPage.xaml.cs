using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AptekaN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstatynaPage : ContentPage
    {
        public EstatynaPage()
        {
            InitializeComponent();
        }
        async void MainMenu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        void Licz(object sender, EventArgs e)
        {
            int l1 = int.Parse(Liczba1.Text);
            int l2 = int.Parse(Liczba2.Text);
            double wynik = (l1 / l2) * 0.1;
            DisplayAlert("Wynik: ", "Należy użyć: " + wynik.ToString() +"mg", "Zamknij");
        }
    }
}