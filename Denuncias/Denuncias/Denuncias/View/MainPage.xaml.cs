using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Denuncias
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void BtnIniciarClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.ListaDenuncias());
        }
    }
}
