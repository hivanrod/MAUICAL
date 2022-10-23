﻿using Newtonsoft.Json;
using System.Text;
using MAUICAL.Models;


namespace MAUICAL.Services
{
    public class TipoRepeticionesServices
    {
        //string baseUrl = "https://localhost:7119/";
        string baseUrl = "http://apicalCore/";
        public async Task<TipoRepeticion[]> GetTipoRepeticionesAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/TipoRepeticiones");
            return JsonConvert.DeserializeObject<TipoRepeticion[]>(json);
        }
        public async Task<TipoRepeticion> GetTipoRepeticionAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/TipoRepeticiones/{id}");
            return JsonConvert.DeserializeObject<TipoRepeticion>(json);
        }
        public async Task<TipoRepeticion[]> GetTipoRepeticionPrioridadAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/TipoRepeticiones/Prioridad/{id}");
            return JsonConvert.DeserializeObject<TipoRepeticion[]>(json);
        }

        public async Task<HttpResponseMessage> InsertTipoRepeticionesAsync(TipoRepeticion TipoRepeticion)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/TipoRepeticiones", getStringContentFromObject(TipoRepeticion));
        }
        public async Task<HttpResponseMessage> UpdateTipoRepeticionesAsync(string id, TipoRepeticion TipoRepeticion)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/TipoRepeticiones/{id}", getStringContentFromObject(TipoRepeticion));
        }
        public async Task<HttpResponseMessage> DeleteTipoRepeticionesAsync(string id, TipoRepeticion TipoRepeticion)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/TipoRepeticiones/{id}");
        }
        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }

    }
}
