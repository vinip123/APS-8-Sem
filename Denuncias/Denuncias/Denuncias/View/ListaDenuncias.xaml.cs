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
        List<Model.Denuncia> contacts;

        public ListaDenuncias()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = contacts;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var detailPage = new CadDenuncias();
                detailPage.BindingContext = e.SelectedItem as Model.Denuncia;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Model.Denuncia>();
            contacts.Add(new Model.Denuncia
            {
                Id = 1,
                Nome = "Vinicius R",
                Texto = "Absurdo!",
                Endereco = "Vila Belmiro"
            });
            contacts.Add(new Model.Denuncia
            {
                Id = 1,
                Nome = "Matheus M",
                Texto = "Cade as autoridades?!",
                Endereco = "Rangel Pestana"
            });
            contacts.Add(new Model.Denuncia
            {
                Id = 1,
                Nome = "Sergio S",
                Texto = "Queimada na oca!",
                Endereco = "Bertioga"
            });

        }
    }
}
