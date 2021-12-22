using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExApiFilmes.Service;
using ExApiFilmes.Models;

namespace ExApiFilmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        //Instanciando o filme service apenas leitura |conceito de injeção de dependencia| //
        private readonly FilmesService service;

        //construtor para acessar o service//
        public FilmesController(FilmesService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Filmes> Get()
        {
            return service.GetFilmes();
        }

        [HttpGet("{titulo}", Name ="SelecionarFilme")]
        public Filmes Get(string titulo)
        {
            return service.GetFilme(titulo);
        }
        
        [HttpPost]
        public IActionResult Create(Filmes filme)
        {
            service.AddFilmes(filme);
            return Ok();
        }

    }
}
