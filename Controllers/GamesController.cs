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
                _context.Games.Add(new Game { Name = "Minecraft", Genre = "Sandbox", Rating = 10, HoursPlayed = 500, ImagePath = "/img/minecraft.jpg", Description = "A sandbox game where you can build, explore, and survive in a block-based world. It’s relaxing when you want it to be, but also has endless goals if you want structure." });
                _context.Games.Add(new Game { Name = "League of Legends", Genre = "MOBA", Rating = 8, HoursPlayed = 300, ImagePath = "/img/league of legends.png", Description = "A competitive team game where strategy, teamwork, and champion knowledge decide the outcome. No two matches feel the same because of how many ways the game can play out." });
                _context.Games.Add(new Game { Name = "Deadlock", Genre = "MOBA", Rating = 9, HoursPlayed = 100, ImagePath = "/img/deadlock.png", Description = "A fast-paced team shooter where coordination and positioning matter just as much as aim. Every match feels intense and requires quick decision-making." });
                _context.Games.Add(new Game { Name = "Terraria", Genre = "Adventure", Rating = 9, HoursPlayed = 200, ImagePath = "/img/terraria.png", Description = "A 2D adventure game focused on exploration, crafting, and boss fights. It starts simple but quickly turns into a deep progression experience with a lot to discover." });

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