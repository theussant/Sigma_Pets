using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;

namespace Sigma_Pets.Controllers;

public class ProdutosController : Controller
{
    private readonly ILogger<ProdutosController> _logger;

    public ProdutosController(ILogger<ProdutosController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
