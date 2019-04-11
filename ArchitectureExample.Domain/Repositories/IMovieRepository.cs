using System.Collections.Generic;
using ArchitectureExample.Domain.Entities;

namespace ArchitectureExample.Domain.Repositories
{
    public interface IMovieRepository
    {
        void Create(Movie Movie);
        IEnumerable<Movie> GetAll();
    }
}
