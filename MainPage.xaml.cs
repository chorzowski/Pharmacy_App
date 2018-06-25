using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace AptekaN
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void EtanolPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EtanolPage());
        }
        async void WitaminyPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WitaminyPage());
        }
        async void EstatynaPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstatynaPage());
        }
        async void OlejekMietowyPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlejekMietowyPage());
        }
    }
}
