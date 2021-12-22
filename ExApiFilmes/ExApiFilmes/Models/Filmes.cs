using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExApiFilmes.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string AnoLancamento { get; set; }
        public int ?IdadeMinima { get; set; }

    }
}
