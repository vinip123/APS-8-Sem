using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Denuncias.View
{
    public partial class ListaDenuncias : ContentPage
    {
        List<Model.Denuncia> denuncia;

        public ListaDenuncias()
        {
            InitializeComponent();

            CarregaDados();
            listView.ItemsSource = denuncia;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var cadadtro = new CadDenuncias();
                cadadtro.BindingContext = e.SelectedItem as Model.Denuncia;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(cadadtro);
            }
        }

        void CarregaDados()
        {
            denuncia = new List<Model.Denuncia>();
            denuncia.Add(new Model.Denuncia
            {
                Id = 1,
                Nome = "Vinicius R",
                Texto = "Absurdo!",
                Endereco = "Rua Santa Maria de Jesus, 188",
                Cidade = "Praia Grande",
                Estado = "SP"
            });
            denuncia.Add(new Model.Denuncia
            {
                Id = 2,
                Nome = "Matheus M",
                Texto = "Cade as autoridades?!",
                Endereco = "Av Rangel Pestana, s/n",
                Cidade = "Santos",
                Estado = "SP"

            });
            denuncia.Add(new Model.Denuncia
            {
                Id = 3,
                Nome = "Sergio S",
                Texto = "Queimada na oca!",
                Endereco = "Avenida Anchieta, 8203",
                Cidade = "Bertioga",
                Estado = "SP"
            });

        }
    }
}
