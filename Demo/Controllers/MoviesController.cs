using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly DataContext _context;
        public MoviesController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<Movie>> Get()
        {
            var movies =await _context.Movies.ToListAsync();

            return Ok(movies);
        }

    }
}