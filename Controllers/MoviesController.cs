using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticketEccommerce.Data;

namespace ticketEccommerce.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBContext _context;

        public MoviesController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
