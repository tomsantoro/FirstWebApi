using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExApiFilmes.Models;

namespace ExApiFilmes.Service
{
    public class FilmesService
    {
        //Criando a instancia de filmes//
        private List<Filmes> filmes;

        //construtor que gera a lista de filmes//
        public FilmesService()
        {
            filmes = new List<Filmes>();
            filmes.Add(new Filmes() { Id = 1, Titulo = "Duna", AnoLancamento = "2021", IdadeMinima = 18 });
            filmes.Add(new Filmes() { Id = 2, Titulo = "Star Wars I", AnoLancamento = "1977", IdadeMinima = 18 });
            filmes.Add(new Filmes() { Id = 3, Titulo = "Star Wars II", AnoLancamento = "1980", IdadeMinima = 18 });
            filmes.Add(new Filmes() { Id = 4, Titulo = "Star Wars III", AnoLancamento = "1983", IdadeMinima = 18 });
            filmes.Add(new Filmes() { Id = 5, Titulo = "Spider Man - Homecoming", AnoLancamento = "2021", IdadeMinima = 16 });
            filmes.Add(new Filmes() { Id = 6, Titulo = "BraveHeart", AnoLancamento = "1995", IdadeMinima = 16 });
            filmes.Add(new Filmes() { Id = 7, Titulo = "Madagascar", AnoLancamento = "2005", IdadeMinima = null });
            filmes.Add(new Filmes() { Id = 8, Titulo = "A Era do Gelo", AnoLancamento = "2002", IdadeMinima = null });
        }
        /// <summary>
        /// Retorna uma lista de filmes
        /// </summary>
        /// <returns></returns>
        public List<Filmes> GetFilmes()
        {
            return filmes;
        }
        /// <summary>
        /// Retorna um único filme recebendo o titulo do filme como parametro
        /// </summary>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public Filmes GetFilme(string titulo)
        {
            return filmes.Where(f => f.Titulo == titulo).FirstOrDefault();
        }
       
    }
}
