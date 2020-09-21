using CopaDoMundo.Api.Domain.Models;
using CopaDoMundo.Api.Models;
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
            var filmeB = new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 };
            var partida = new Partida(filmeA, filmeB);

            // Act
            var vencedor = partida.IniciarPartida();

            // Assert
            Assert.Equal(filmeB, vencedor);
        }

        [Fact]
        public void Partida_IniciarPartida_RetornaFilmePelaOrdemAlfabetica()
        {
            // Arrange
            var filmeA = new Filme { Id = "tt6499752", Titulo = "Upgrade", Ano = 2018, Nota = 7.8 };
            var filmeB = new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 };
            var partida = new Partida(filmeA, filmeB);

            // Act
            var vencedor = partida.IniciarPartida();

            // Assert
            Assert.Equal(filmeB, vencedor);
        }
    }
}
