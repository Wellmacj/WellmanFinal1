using Microsoft.AspNetCore.Mvc;
using WellmanFinal1.Data;
using WellmanFinal1.Models;

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
            if (!_context.Games.Any())
            {
                _context.Games.Add(new Game { Name = "Minecraft", Genre = "Sandbox", Rating = 10, HoursPlayed = 500, ImagePath = "/img/minecraft.jpg" });
                _context.Games.Add(new Game { Name = "League of Legends", Genre = "MOBA", Rating = 8, HoursPlayed = 300, ImagePath = "/img/league of legends.png" });
                _context.Games.Add(new Game { Name = "Deadlock", Genre = "MOBA", Rating = 9, HoursPlayed = 100, ImagePath = "/img/deadlock.png" });
                _context.Games.Add(new Game { Name = "Terraria", Genre = "Adventure", Rating = 9, HoursPlayed = 200, ImagePath = "/img/terraria.png" });

                _context.SaveChanges();
            }

            var games = _context.Games.ToList();
            return View(games);
        }
        public IActionResult Details(int id)
        {
            var game = _context.Games.FirstOrDefault(g => g.Id == id);

            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }
    }
}