﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Denuncias.View
{
    public partial class TelaPrincipal : ContentPage
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        async void BtnIniciarClick(object sender, EventArgs e)
        {
            //await Navigation.PushAsync (new ListaDenuncias()); por algum motivo deu problema

            await Navigation.PushModalAsync(new ListaDenuncias());
        }
    }
}
