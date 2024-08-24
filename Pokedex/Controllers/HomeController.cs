using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Data;
using Pokedex.Models;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

        //Injeção de dependência
    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        List<Pokemon> pokemons = _context.Pokemons
            .Include(p => p.Tipos)
            .ThenInclude(pt => pt.Tipo)
            .ToList();
        return View(pokemons);
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
