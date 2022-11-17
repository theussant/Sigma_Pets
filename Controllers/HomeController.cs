﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;

namespace Sigma_Pets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Obrigado()
    {
        return View();
    }
    public IActionResult Contatos()
    {
        return View();
    }

    public IActionResult Produtos()
    {
        return View();
    }
    public IActionResult Servicos()
    {
        return View();
    }
    public IActionResult Clientes()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
