using CopaDoMundo.Api.Domain.Models;
using CopaDoMundo.Api.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace CopaDoMundo.Test
{
    public class PartidaTests
    {

        [Fact]
        public void Partida_IniciarPartida_RetornaFilmeComMaiorNota()
        {
            // Arrange
            var filmeA = new Filme { Id = "tt1825683", Titulo = "Pantera Negra", Ano = 2018, Nota = 7.5 };
            var filmeB = new Filme { Id = "tt3606756", Titulo = "Os Incr�veis 2", Ano = 2018, Nota = 8.5 };
            var partida = new Partida(filmeA, filmeB);

            // Act
            var vencedor = partida.IniciarPartida();

            // Assert
            Assert.Equal(filmeB, vencedor);
        }
    }
}
