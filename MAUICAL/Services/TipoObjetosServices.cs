using MAUICAL.Models;
using Newtonsoft.Json;
using System.Text;


namespace MAUICAL.Services
{
    public class TipoObjetosServices
    {
        //string baseUrl = "https://localhost:7119/";
        string baseUrl = "http://apicalCore/";
        public async Task<TipoObjeto[]> GetTipoObjetoAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/TipoObjetos");
            return JsonConvert.DeserializeObject<TipoObjeto[]>(json);
        }
        public async Task<TipoObjeto> GetTipoObjetoAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/TipoObjetos/{id}");
            return JsonConvert.DeserializeObject<TipoObjeto>(json);
        }
        public async Task<TipoObjeto[]> GetTipoObjetoPrioridadAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/TipoObjetos/Prioridad/{id}");
            return JsonConvert.DeserializeObject<TipoObjeto[]>(json);
        }

        public async Task<HttpResponseMessage> InsertTipoObjetoAsync(TipoObjeto TipoObjeto)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/TipoObjetos", getStringContentFromObject(TipoObjeto));
        }
        public async Task<HttpResponseMessage> UpdateTipoObjetoAsync(string id, TipoObjeto TipoObjeto)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/TipoObjetos/{id}", getStringContentFromObject(TipoObjeto));
        }
        public async Task<HttpResponseMessage> DeleteTipoObjetoAsync(string id, TipoObjeto TipoObjeto)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/TipoObjetos/{id}");
        }
        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }

    }
}
