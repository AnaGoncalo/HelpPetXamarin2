using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Models;

namespace TestDrive.ViewModels
{
    public class ListagemViewModel
    {
        public List<Denuncia> Denuncias { get; set; }

        public ListagemViewModel()
        {
            this.Denuncias = new ListagemDenuncias().Denuncias;
        }
    }
}
