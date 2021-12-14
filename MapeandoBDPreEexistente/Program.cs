using MapeandoBDPreEexistente.Dados;
using MapeandoBDPreEexistente.Extensions;
using MapeandoBDPreEexistente.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MapeandoBDPreEexistente
{
    class Program
    {
        static void Main(string[] args)
        {
            //select *from filmeator
            using (var contexto = new AluraFilmesContext())
            {

                //Log sql enviado para o BD
                contexto.LogSQLToConsole();

                var idiomas = contexto.Idiomas
                    .Include(i => i.FilmesFalados); //select com Join

                foreach (var idioma in idiomas)
                {
                    Console.WriteLine(idioma);

                    foreach (var filme in idioma.FilmesFalados)
                    {
                        Console.WriteLine(filme);
                    }
                    Console.WriteLine("\n");
                }
                









                ////Log sql enviado para o BD
                //contexto.LogSQLToConsole();

                //var filme = contexto.Filmes
                //    .Include(f => f.Atores) //inclusão de Join
                //    .ThenInclude(fa => fa.Ator) //inclusão de Join
                //    .First();
                //Console.WriteLine(filme);
                //Console.WriteLine("Elenco:");

                ////Shadow Property ToTable("film_actor")
                //foreach (var ator in filme.Atores) 
                //{
                //    Console.WriteLine(ator.Ator);                   
                //}





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



                ////select *from actor
                //using (var contexto = new AluraFilmesContext())
                //{
                //    //vendo o log sql enviado para o BD
                //    contexto.LogSQLToConsole();

                //    ////Lendo e ordenando valores de Shadow Property
                //    var atores = contexto.Atores
                //        .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                //        .Take(10);
                //    foreach (var ator in atores)
                //    {
                //        Console.WriteLine(ator + " - " + contexto.Entry(ator).Property("last_update").CurrentValue);
                //    }
                //}


                ////select *from filme
                //using (var contexto = new AluraFilmesContext())
                //{
                //    //vendo o log sql enviado para o BD
                //    contexto.LogSQLToConsole();

                //    foreach (var filme in contexto.Filmes)
                //    {
                //        Console.WriteLine(filme);
                //    }
                //}

            }
        }
    }
}





//select a.*
//from actor a
//inner join film_actor fa on fa.actor_id = a.actor_id
//where film_id = 1



//select a.*
//from actor a
//inner join film_actor fa on fa.actor_id = a.actor_id
//inner join film f on f.film_id = fa.film_id
//where fa.film_id = 1