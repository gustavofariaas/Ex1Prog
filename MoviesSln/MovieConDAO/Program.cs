
using Dominio;
using Entidades.Model;
using Entidades.ViewModel;
using Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieConDAO
{
    class Program
    {
        static async Task Main(string[] args)
        {
            FachadaDominio fachada = new FachadaDominio();


            Genre g1 = new Genre()
            {
                Name = "Comedia",
                Description = DateTime.Now.ToLongTimeString()
            };

            Genre g2 = new Genre()
            {
                Name = "Terror",
                Description = DateTime.Now.ToLongTimeString()
            };

            Genre g3 = new Genre()
            {
                Name = "Romance",
                Description = DateTime.Now.ToLongTimeString()
            };

            await fachada.Inserir(g1);
            await fachada.Inserir(g2);
            await fachada.Inserir(g3);

            await fachada.Delete(g3);


            Movie m1 = new Movie()
            {
                Title = "Titanic",
                Director = "James Cameron"
            };

            Movie m2 = new Movie()
            {
                Title = "Django",
                Director = "Quentin Tarantino"
            };

            Movie m3 = new Movie()
            {
                Title = "Batman Begins",
                Director = "Christopher Nolan"
            };

            await fachada.Inserir(m1);
            await fachada.Inserir(m2);
            await fachada.Inserir(m3);

            await fachada.Delete(m2);

        }

    }
}
