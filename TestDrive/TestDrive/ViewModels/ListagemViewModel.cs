using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive.ViewModels
{
    public class ListagemViewModel
    {
        const string URL_GET_DENUNCIAS = "http://helppettads-appnerd.rhcloud.com/HelpPetMaven/rest/denuncia";

        public ObservableCollection<Denuncia> Denuncias { get; set; }

        public ListagemViewModel()
        {
            this.Denuncias = new ObservableCollection<Denuncia>();
        }

        public async Task getDenunciasHttp()
        {            
            try
            {
                HttpClient cliente = new HttpClient();
                var resultado = await cliente.GetStringAsync(URL_GET_DENUNCIAS);
                var denunciasJson = JsonConvert.DeserializeObject<DenunciaJson[]>(resultado);
                
                foreach (var denunciaJson in denunciasJson)
                {
                    this.Denuncias.Add(new Denuncia
                    {
                        Titulo = denunciaJson.titulo,
                        Texto = denunciaJson.texto,
                        Data = denunciaJson.data
                    });
                }
            }
            catch (Exception exc)
            {
                MessagingCenter.Send<Exception>(exc, "FalhaListagem");
            }
        }
    }

    class DenunciaJson
    {
        public string titulo { get; set; }
        public string texto { get; set; }
        public string data { get; set; }
    }
}
