using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestDrive.Models
{
    public class ListagemDenuncias
    {
        public List<Denuncia> Denuncias { get; set; }

        public ListagemDenuncias()
        {
            this.Denuncias = new List<Denuncia>
            {
                new Denuncia { Titulo = "Denuncia A", Data = "29/07/2017", Texto = "Testando" },
                new Denuncia {Titulo = "Denuncia B", Data = "29/07/2017", Texto = "Testando" }
            };
        }
        
    }
    class DenunciaJson
    {
        public string titulo { get; set; }
        public string texto { get; set; }
        public string data { get; set; }
    }
}
