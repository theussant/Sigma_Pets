using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SigmaPets.Models;

namespace SigmaPets.Controllers;

public class AlterarController : Controller
{
    private readonly ILogger<AlterarController> _logger;

    public AlterarController(ILogger<AlterarController> logger)
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
