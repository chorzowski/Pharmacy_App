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
        public EtanolPage()
        {
            InitializeComponent();

        }
            async void MainMenu(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
	}
