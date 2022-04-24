using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WebApp.Models.Cultivo
{
    public class CultivoModel
    {
        private String UriApi;
        MediaTypeWithQualityHeaderValue mediaheader;

        public CultivoModel()
        {
            this.UriApi = "https://localhost:44344/"; // Local API
            this.mediaheader = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<bool> AddCultivo(CultivoEntity l)
        {

            using (HttpClient client = new HttpClient())
            {
                String peticion = "/api/v1/Cultivo";
                client.BaseAddress = new Uri(this.UriApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(mediaheader);
                HttpResponseMessage respuesta = await client.PostAsJsonAsync(peticion, l);
                if (respuesta.IsSuccessStatusCode)
                {
                    return true;
                }
                else { return false; }
            }


        }
    }
}
