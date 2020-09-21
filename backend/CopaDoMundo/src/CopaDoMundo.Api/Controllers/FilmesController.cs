using System.Collections.Generic;
using System.Threading.Tasks;
using CopaDoMundo.Api.Domain.Models;
using CopaDoMundo.Api.Models;
using CopaDoMundo.Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CopaDoMundo.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class FilmesController : ControllerBase
    {
        private IApiService _apiService;
        public FilmesController(IApiService apiService)
        {
            this._apiService = apiService;
        }

        /// <summary>
        /// Listagem de FIlmes
        /// </summary>
        /// <returns>Lista de FIlmes</returns>
        /// <response code="200">Retorna uma listagem de FIlme</response>
        /// <response code="400">Retorna erro quando ocorrer algum erro no consumo da Api</response>  
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Filme>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public async Task<IActionResult> Index()
        {
            var filmes = await _apiService.PegarFilmes();
            return Ok(filmes);
        }

        /// <summary>
        /// Inicia Cameponato
        /// </summary>
        /// <param name="filmes">Obrigatóriamente uma Lista com 8 Filmes</param>
        /// <returns>Lista FIlme com o Campeão e Vice-Campeão</returns>
        /// <response code="200">Retorna uma listagem com o Campeão e Vice-Campeão</response>
        /// <response code="400">Retorna erro quando ocorrer algum erro no consumo da Api</response>  
        [HttpPost("campeonato")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Filme>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public IActionResult IniciaCameponato(IList<Filme> filmes)
        {
            var campeonato = new Campeonato(filmes);
            var resultado = campeonato.IniciarCampeonato();
            return Ok(resultado);
        }
    }
}
