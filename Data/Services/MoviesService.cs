using Microsoft.EntityFrameworkCore;
using ticketEccommerce.Data.Base;
using ticketEccommerce.Data.ViewModels;
using ticketEccommerce.Models;

namespace ticketEccommerce.Data.Services
{
    public class MoviesService:EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDBContext _context;
        public MoviesService(AppDBContext context):base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var MovieDetails = await _context.Movies
                    .Include(c => c.Cinema)
                    .Include(p => p.Producer)
                    .Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                    .FirstOrDefaultAsync(n => n.Id == id);

            return MovieDetails;
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var response = new NewMovieDropdownsVM()
            {
                Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }
    }
}
