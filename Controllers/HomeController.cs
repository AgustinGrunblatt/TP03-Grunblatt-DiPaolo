using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_Grunblatt_Dipaolo.Models;

namespace TP03_Grunblatt_Dipaolo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        PalabrasAhorcado palabra = new PalabrasAhorcado();
        ViewBag.Palabra = palabra.ObtenerPalabra();
        ViewBag.Intentos = 10;
        ViewBag.PalabraOculta ="";
        for (int i=0 ; i< ViewBag.Palabra.Length; i++)
        {
            ViewBag.PalabraOculta = ViewBag.PalabraOculta + "_";
        }

        return View();
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
