using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Models;
using TestDrive.ViewModels;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public partial class ListagemView : ContentPage
    {
        public ListagemViewModel ViewModel { get; set; }

        public ListagemView()
        {
            InitializeComponent();
            this.ViewModel = new ListagemViewModel();
            this.BindingContext = this.ViewModel;
        }

        private void ListViewDenuncias_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var denuncia = (Denuncia)e.Item;

            Navigation.PushAsync(new DetalheView(denuncia));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.getDenunciasHttp();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.Denuncias.Clear();
        }
    }
}
