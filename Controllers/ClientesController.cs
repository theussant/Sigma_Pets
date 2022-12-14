using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;

namespace Sigma_Pets.Controllers;

public class ClientesController : Controller
{
    private readonly ILogger<ClientesController> _logger;

    public ClientesController(ILogger<ClientesController> logger)
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
     public IActionResult CadastrarCliente()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
