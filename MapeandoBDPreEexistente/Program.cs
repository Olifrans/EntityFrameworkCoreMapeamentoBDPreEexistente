using MapeandoBDPreEexistente.Dados;
using MapeandoBDPreEexistente.Extensions;
using MapeandoBDPreEexistente.Negocio;
using System;

namespace MapeandoBDPreEexistente
{
    class Program
    {
        static void Main(string[] args)
        {
            ////select *from category
            //using (var contexto = new AluraFilmesContext())
            //{
            //    //vendo o log sql enviado para o BD
            //    contexto.LogSQLToConsole();

            //    foreach (var categoria in contexto.Categorias)
            //    {
            //        System.Console.WriteLine(categoria);
            //    }
            //}






            //select *from actor
            using (var contexto = new AluraFilmesContext())
            {
                //vendo o log sql enviado para o BD
                contexto.LogSQLToConsole();

                var ator = new Ator();
                ator.PrimeiroNome = "Olifrans";
                ator.UltimoNome = "Oliveira";

                //Setando Property Shadow Property
                contexto.Entry(ator).Property("last_update").CurrentValue = DateTime.Now;

                contexto.Atores.Add(ator);
                contexto.SaveChanges();
            }
        }
    }
}
