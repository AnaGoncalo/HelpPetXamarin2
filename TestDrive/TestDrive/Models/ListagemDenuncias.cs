using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrive.Models
{
    public class ListagemDenuncias
    {
        const string URL_GET_DENUNCIAS = "http://helppettads-appnerd.rhcloud.com/HelpPetMaven/rest/denuncia";
        public List<Denuncia> Denuncias { get; set; }

        public ListagemDenuncias()
        {
            this.Denuncias = new List<Denuncia>
            {
                new Denuncia { Titulo = "Denuncia A", Data = "29/07/2017", Texto = "Testando" },
                new Denuncia {Titulo = "Denuncia B", Data = "29/07/2017", Texto = "Testando" }
            };
            //this.Denuncias = GetDenuncias();
        }
        /*
        public async List<Denuncia> GetDenuncias()
        {
            try
            {
                HttpClient cliente = new HttpClient();
                var resultado = await cliente.GetStringAsync(URL_GET_DENUNCIAS);
                var denunciasJson = JsonConvert.DeserializeObject<DenunciaJson[]>(resultado);
                List<Denuncia> lista = new List<Denuncia>();
                foreach (var denunciaJson in denunciasJson)
                {
                    lista.Add(new Denuncia
                    {
                        Titulo = denunciaJson.titulo,
                        Texto = denunciaJson.texto,
                        Data = denunciaJson.data
                    });
                }
                return lista;
            }
            catch (Exception exc)
            {
                MessagingCenter.Send<Exception>(exc, "FalhaListagem");
            }
        }
        */
    }
    class DenunciaJson
    {
        public string titulo { get; set; }
        public string texto { get; set; }
        public string data { get; set; }
    }
}
