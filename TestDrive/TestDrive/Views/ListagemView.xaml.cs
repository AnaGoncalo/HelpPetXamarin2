using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public partial class ListagemView : ContentPage
    {
        public ListagemView()
        {
            InitializeComponent();
        }

        private void listViewDenuncias_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var denuncia = (Denuncia)e.Item;

            Navigation.PushAsync(new DetalheView(denuncia));
        }
    }
}
