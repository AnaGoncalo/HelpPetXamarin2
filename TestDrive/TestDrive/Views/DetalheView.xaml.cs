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
    public partial class DetalheView : ContentPage
    {
        public Denuncia Denuncia { get; set; }

        public DetalheView(Denuncia denuncia)
        {
            InitializeComponent();
            this.Denuncia = denuncia;
            this.BindingContext = new DetalheViewModel(Denuncia);
        }

    }
}
