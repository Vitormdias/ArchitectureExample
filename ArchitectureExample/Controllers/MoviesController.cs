using System.Collections.Generic;
using ArchitectureExample.Domain.Entities;
using ArchitectureExample.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureExample.API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController (IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }

        // GET: api/movies
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return Ok(_movieRepository.GetAll());
        }

        // POST: api/movies
        [HttpPost]
        public ActionResult<IEnumerable<Movie>> Post([FromBody] Movie Movie)
        {
            _movieRepository.Create(Movie);

            return Ok();
        }
    }
}
