using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeandoBDPreEexistente.Negocio
{
   
    public class Ator
    {

        public int Id { get; set; }        
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }


        //Sobrescrevendo o método ToString para que as informações de primeiro nome e último nome de cada ator se tornem visíveis.
        public override string ToString()
        {
            return $"Ator ({Id}): {PrimeiroNome} {UltimoNome}";
        }

    }
}
