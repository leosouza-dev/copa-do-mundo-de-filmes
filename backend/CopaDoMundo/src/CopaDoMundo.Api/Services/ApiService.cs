using CopaDoMundo.Api.Domain.Models;
using CopaDoMundo.Api.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CopaDoMundo.Api.Services
{
    public class ApiService : IApiService
    {
        private HttpClient _httpClient;
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Filme>> PegarFilmes()
        {
            var resposta = await _httpClient.GetAsync("http://copafilmes.azurewebsites.net/api/filmes");
            var apiResposta = await resposta.Content.ReadAsStringAsync();
            var listaDeFilmes = JsonConvert.DeserializeObject<IEnumerable<Filme>>(apiResposta);

            // ordenar de ordem Alfabética
            var listaOrdenada = listaDeFilmes.OrderBy(f => f.Titulo);

            resposta.EnsureSuccessStatusCode(); //lança execção se der ruim
            return listaDeFilmes;
        }
    }
}
