using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticketEccommerce.Data;

namespace ticketEccommerce.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBContext _context;

        public ProducersController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
