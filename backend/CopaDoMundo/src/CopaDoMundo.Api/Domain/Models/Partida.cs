using CopaDoMundo.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDoMundo.Api.Models
{
    public class Partida
    {
        public Partida(Filme filmeA, Filme filmeB)
        {
            this.FilmeA = filmeA;
            this.FilmeB = filmeB;
        }

        public Filme FilmeA { get; private set; }
        public Filme FilmeB { get; private set; }
        public Filme Vencedor { get; private set; }

        public Filme IniciarPartida()
        {
            if (FilmeA == null || FilmeB == null) throw new Exception("Falha durante a execução das partidas. Tente Novamente!");

            // filme com a mesma nota, vence pelo titulo (ordem alfabética)
            if(FilmeA.Nota == FilmeB.Nota)
            {
                Vencedor = DesempatarPeloTitulo(FilmeA, FilmeB);
                return Vencedor;
            }

            var filmes = new Filme[2] { FilmeA, FilmeB };
            Vencedor = filmes.OrderByDescending(f => f.Nota).First();
            return Vencedor;
        }

        private Filme DesempatarPeloTitulo(Filme filmeA, Filme filmeB)
        {
            var filmes = new Filme[2]{ filmeA, filmeB };
            return filmes.OrderBy(f => f.Titulo).First();
        }
    }
}
