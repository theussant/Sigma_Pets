using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;

namespace Sigma_Pets.Controllers;

public class AnimaisController : Controller
{
    private readonly ILogger<AnimaisController> _logger;

    public AnimaisController(ILogger<AnimaisController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Alterar()
    {
        return View();
    }
    public IActionResult VerificarExcluir()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
