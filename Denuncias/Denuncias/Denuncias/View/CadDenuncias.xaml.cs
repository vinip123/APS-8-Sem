using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Denuncias.View
{
    public partial class CadDenuncias : ContentPage
    {
        public CadDenuncias()
        {
            InitializeComponent();
        }

        void BtnSalvarClick(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

        async void BtnMapaCLick(object sender, EventArgs e)
        {
            if (txtEndereco.Text != "" && txtCidade.Text != "" && txtEstado.Text != "")
            {
                var lat = API.ApiMaps.Getlat(txtEndereco.Text, txtCidade.Text, txtEstado.Text);

                foreach (var singleResult in lat.results)
                {
                    var location = singleResult.geometry.location;
                    var latitude = location.lat;
                    var longitude = location.lng;

                    var mapa = new ViewMapa(latitude, longitude);
                    await Navigation.PushModalAsync(mapa);
                }
            }
        }

        void BtnCancelarCLick(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}
