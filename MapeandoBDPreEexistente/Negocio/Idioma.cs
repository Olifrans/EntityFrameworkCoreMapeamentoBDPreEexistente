using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeandoBDPreEexistente.Negocio
{
    public class Idioma
    {
        public byte Id { get; set; }
        public string Nome { get; set; }

        public IList<Filme> FilmeFalados { get; set; }
        public IList<Filme> FilmeOriginal { get; set; }

        public Idioma()
        {
            FilmeFalados = new List<Filme>();
            FilmeFalados = new List<Filme>();
        }

        //Sobrescrevendo o método ToString para que as informações de Titulo e Decricao do filme se tornem visíveis.
        public override string ToString()
        {
            return $"Ator ({Id}): {Nome} ";
        }
    }    
}
