using CopaDoMundo.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDoMundo.Api.Models
{
    public class Campeonato
    {
        // lembrar de validar....
        public Campeonato(IList<Filme> filmes)
        {
            Filmes = filmes;
        }

        public IList<Filme> Filmes { get; set; }
        public Filme Camepão { get; set; }
        public Filme ViceCampeão { get; set; }

        public IList<Filme> IniciarCampeonato()
        {
            if (Filmes.Count() != 8) throw new Exception("É preciso selecionar 8 filmes!");

            var filmes = OrndenarFilmesPorNota();
            var resultadoQuartasdeFinal = IniciarQuartasDeFinal(filmes);
            var resultadoSemiFInal = IniciarSemiFinal(resultadoQuartasdeFinal);
            var resultadoFinal = IniciarFinal(resultadoSemiFInal);

            Camepão = resultadoFinal[0];
            ViceCampeão = resultadoFinal[1];

            return resultadoFinal;
        }

        private IList<Filme> OrndenarFilmesPorNota()
        {
            var filmesOrdenados = Filmes.OrderBy(f => f.Titulo).ToList();
            return filmesOrdenados;
        }

        private IList<Filme> IniciarQuartasDeFinal(IList<Filme> filmes)
        {
            var partidas = new List<Partida>
            {
                new Partida(filmes[0], filmes[7]),
                new Partida(filmes[1], filmes[6]),
                new Partida(filmes[2], filmes[5]),
                new Partida(filmes[3], filmes[4])
            };

            return InicarRodadaEliminatoria(partidas);
        }

        private IList<Filme> IniciarSemiFinal(IList<Filme> filmes)
        {
            var partidas = new List<Partida>
            {
                new Partida(filmes[0], filmes[1]),
                new Partida(filmes[2], filmes[3]),
            };

            return InicarRodadaEliminatoria(partidas);
        }

        private IList<Filme> IniciarFinal(IList<Filme> filmes)
        {
            var partida = new Partida(filmes[0], filmes[1]);
            var primeiroColocado = partida.IniciarPartida();
            var segundoColocado = primeiroColocado == filmes[0] ? filmes[1] : filmes[0];

            return new List<Filme> { primeiroColocado, segundoColocado };
        }

        private IList<Filme> InicarRodadaEliminatoria(IList<Partida> partidas)
        {
            var vencedores = new List<Filme>();
            foreach (var partida in partidas)
            {
                vencedores.Add(partida.IniciarPartida());
            }

            return vencedores;
        }
    }
}
