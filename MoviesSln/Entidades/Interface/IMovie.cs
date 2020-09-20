using Entidades.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interface
{
    public interface IMovies
    {
        Task Inserir(Movie movie);
        Task<List<Movie>> List();
        Task Delete(Movie movie);
        Task<Movie> GetMovieById(int Id);
        Task Update(Movie movie);

    }
}
