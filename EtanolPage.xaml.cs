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
    public partial class EtanolPage : ContentPage
    {
        //List<ListViewItem> Items;
        Dictionary<String, String> dic = new Dictionary<string, string>()
            {
                {"30 stopni","Musisz użyć 262 gramy Etanulu 96 oraz 738 gramów wody"},
                {"40 stopni","Musisz użyć 355 gramy Etanulu 96 oraz 645 gramów wody"},
                {"50 stopni","Musisz użyć 452 gramy Etanulu 96 oraz 548 gramów wody"},
                {"60 stopni","Musisz użyć 555 gramy Etanulu 96 oraz 445 gramów wody"},
                {"70 stopni","Musisz użyć 655 gramy Etanulu 96 oraz 335 gramów wody"},
                {"80 stopni","Musisz użyć 783 gramy Etanulu 96 oraz 217 gramów wody"},
                {"90 stopni","Musisz użyć 913 gramy Etanulu 96 oraz 87 gramów wody"},
            };
        public EtanolPage()
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
         //   int l2 = int.Parse(Liczba2.Text);
           // int wynik = l1 + l2;
        //    DisplayAlert("Wynik", wynik.ToString(), "Zamknij");
        }

        private void Button1_Focused(object sender, FocusEventArgs e)
        {

        }

        void InitPicker(object sender, EventArgs e)
        {
            if (pic.Items[pic.SelectedIndex] =="30")
            {
                int etanol = 262;
                int woda = 738;
                int l1 = int.Parse(Liczba1.Text);
                double wynikEtanolu = (etanol * l1) * 0.001;
                double wynikWody = (woda * l1) * 0.001;

                DisplayAlert("Obliczanie składu lekarstwa dla 30 stopnii", "Jeżeli chcesz otrzymać: " + l1 + "gr roztworu, to musisz użyć: " + wynikEtanolu.ToString() + " g etanolu 96 oraz: " + wynikWody.ToString() + " g wody", "powrót");
            }
            else if (pic.Items[pic.SelectedIndex] == "40")
            {
                int etanol = 355;
                int woda = 645;
                int l1 = int.Parse(Liczba1.Text);
                double wynikEtanolu = (etanol * l1) * 0.001;
                double wynikWody = (woda * l1) * 0.001;

                DisplayAlert("Obliczanie składu lekarstwa dla 40 stopni", "Jeżeli chcesz otrzymać: " + l1 + "gr roztworu, to musisz użyć: " + wynikEtanolu.ToString() + " g etanolu 96 oraz: " + wynikWody.ToString() + " g wody", "powrót");
            }
            else if (pic.Items[pic.SelectedIndex] == "50")
            {
                int etanol = 452;
                int woda = 548;
                int l1 = int.Parse(Liczba1.Text);
                double wynikEtanolu = (etanol * l1) * 0.001;
                double wynikWody = (woda * l1) * 0.001;

                DisplayAlert("Obliczanie składu lekarstwa dla 50 stopni", "Jeżeli chcesz otrzymać: " + l1 + "gr roztworu, to musisz użyć: " + wynikEtanolu.ToString() + " g etanolu 96 oraz: " + wynikWody.ToString() + " g wody", "powrót");
            }

            else if (pic.Items[pic.SelectedIndex] == "60")
            {
                int etanol = 555;
                int woda = 445;
                int l1 = int.Parse(Liczba1.Text);
                double wynikEtanolu = (etanol * l1) * 0.001;
                double wynikWody = (woda * l1) * 0.001;

                DisplayAlert("Obliczanie składu lekarstwa dla 60 stopni", "Jeżeli chcesz otrzymać: " + l1 + "gr roztworu, to musisz użyć: " + wynikEtanolu.ToString() + " g etanolu 96 oraz: " + wynikWody.ToString() + " g wody", "powrót");
            }
            else if (pic.Items[pic.SelectedIndex] == "70")
            {
                int etanol = 665;
                int woda = 335;
                int l1 = int.Parse(Liczba1.Text);
                double wynikEtanolu = (etanol * l1) * 0.001;
                double wynikWody = (woda * l1) * 0.001;

                DisplayAlert("Obliczanie składu lekarstwa dla 70 stopni", "Jeżeli chcesz otrzymać: " + l1 + "gr roztworu, to musisz użyć: " + wynikEtanolu.ToString() + " g etanolu 96 oraz: " + wynikWody.ToString() + " g wody", "powrót");
            }
            else if (pic.Items[pic.SelectedIndex] == "80")
            {
                int etanol = 783;
                int woda = 217;
                int l1 = int.Parse(Liczba1.Text);
                double wynikEtanolu = (etanol * l1) * 0.001;
                double wynikWody = (woda * l1) * 0.001;

                DisplayAlert("Obliczanie składu lekarstwa dla 80 stopni", "Jeżeli chcesz otrzymać: " + l1 + "gr roztworu, to musisz użyć: " + wynikEtanolu.ToString() + " g etanolu 96 oraz: " + wynikWody.ToString() + " g wody", "powrót");
            }
            else if (pic.Items[pic.SelectedIndex] == "90")
            {
                int etanol = 913;
                int woda = 87;
                int l1 = int.Parse(Liczba1.Text);
                double wynikEtanolu = (etanol * l1) * 0.001;
                double wynikWody = (woda * l1) * 0.001;

                DisplayAlert("Obliczanie składu lekarstwa dla 90 stopni", "Jeżeli chcesz otrzymać: " + l1 + "gr roztworu, to musisz użyć: " + wynikEtanolu.ToString() + " g etanolu 96 oraz: " + wynikWody.ToString() + " g wody", "powrót");
            }
            // Picker pic = (Picker)sender;

            //  int mode = pic.SelectedIndex;
            //  pic.Items.Clear();
            /*
            switch (mode)
            {
                case 0:
                    {
                        //        rolePicker.IsEnabled = true;

                        //     Console.WriteLine("dziala");
                        DisplayAlert("Wynik", "kupa", "Zamknij");
                        break;
                    }
            }
            */
        }
    }
}
       
	
