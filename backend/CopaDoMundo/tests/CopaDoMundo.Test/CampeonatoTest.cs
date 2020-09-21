using CopaDoMundo.Api.Domain.Models;
using CopaDoMundo.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CopaDoMundo.Test
{
    public class CampeonatoTest
    {
        [Fact]
        public void Campeonato_IniciarCampeonato_RetornaFilmesCamepões()
        {
            // Arrange
            var filme1 = new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 };
            var filme2 = new Filme { Id = "tt4881806", Titulo = "Jurassic World: Reino Ameaçado", Ano = 2018, Nota = 6.7 };
            var filme3 = new Filme { Id = "tt5164214", Titulo = "Oito Mulheres e um Segredo", Ano = 2018, Nota = 6.3 };
            var filme4 = new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 };
            var filme5 = new Filme { Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8 };
            var filme6 = new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 };
            var filme7 = new Filme { Id = "tt3778644", Titulo = "Han Solo: Uma História Star Wars", Ano = 2018, Nota = 7.2 };
            var filme8 = new Filme { Id = "tt3501632", Titulo = "Thor: Ragnarok", Ano = 2017, Nota = 7.9 };

            var filmes = new List<Filme>
            {
                filme1,
                filme2,
                filme3,
                filme4,
                filme5,
                filme6,
                filme7,
                filme8
            };

            var campeonato = new Campeonato(filmes);

            // Act
            var camepeos = campeonato.IniciarCampeonato();

            // Assert
            Assert.Equal(filme5, camepeos[0]);
            Assert.Equal(filme1, camepeos[1]);
        }
    }
}
