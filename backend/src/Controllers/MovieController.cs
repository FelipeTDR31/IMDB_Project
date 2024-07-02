using backend.Data;
using backend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    /// <summary>
    /// MovieController provides endpoints for CRUD operations on Movies
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    
    public class MovieController : ControllerBase
    {
        private readonly MovieContext _context;

        /// <summary>
        /// Constructor for MovieController
        /// </summary>
        /// <param name="context">MovieContext</param>
        public MovieController(MovieContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all movies
        /// </summary>
        /// <returns>List of movies</returns>
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> Get()
        {
            return await _context.Movie.ToListAsync();
        }

        /// <summary>
        /// Get a movie by id
        /// </summary>
        /// <param name="id">Movie id</param>
        /// <returns>Movie</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> Get(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        /// <summary>
        /// Create a new movie
        /// </summary>
        /// <param name="movie">Movie</param>
        /// <returns>Created movie</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Movie movie)
        {
            _context.Movie.Add(movie);
            await _context.SaveChangesAsync();
            return Ok(movie);
        }

        /// <summary>
        /// Update a movie
        /// </summary>
        /// <param name="id">Movie id</param>
        /// <param name="movie">Movie</param>
        /// <returns>No content</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Movie movie)
        {
            movie.Id = id;
            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        /// <summary>
        /// Delete a movie
        /// </summary>
        /// <param name="id">Movie id</param>
        /// <returns>No content</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

