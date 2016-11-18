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

        void BtnExcluirCLick(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

        void BtnCancelarCLick(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}
