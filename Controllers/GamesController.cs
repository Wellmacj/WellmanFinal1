using Microsoft.AspNetCore.Mvc;

namespace WellmanFinal1.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
