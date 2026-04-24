using Microsoft.AspNetCore.Mvc;
using WellmanFinal1.Data;

namespace WellmanFinal1.Controllers
{
    public class GamesController : Controller
    {
        private readonly AppDbContext _context;

        public GamesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var games = _context.Games.ToList();
            return View(games);
        }
    }
}