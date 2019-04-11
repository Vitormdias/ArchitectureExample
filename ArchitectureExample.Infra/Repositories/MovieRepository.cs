using System.Collections.Generic;
using ArchitectureExample.Domain.Entities;
using ArchitectureExample.Domain.Repositories;
using System.Linq;

namespace ArchitectureExample.Infra.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public ICollection<Movie> Movies { get; set; }

        public MovieRepository()
        {
            Movies = new List<Movie>();
        }

        public IEnumerable<Movie> GetAll()
        {
            return Movies;
        }

        public void Create(Movie Movie)
        {
            Movies.Add(Movie);
        }
    }
}
