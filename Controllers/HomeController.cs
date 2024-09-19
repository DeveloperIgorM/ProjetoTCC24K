using Aula14DAAWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Aula14DAAWW.Data;

namespace Aula14DAAWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Aula14DAAWWContext _context; //criando para poder acessar o db
        public HomeController(ILogger<HomeController> logger, Aula14DAAWWContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Jogo.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}