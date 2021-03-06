﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			InitializeComponent ();
        }
        public void Btn_ListarDenuncias(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ListagemView());
        }

        public void Btn_Sobre(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new Sobre());
        }

    }
}