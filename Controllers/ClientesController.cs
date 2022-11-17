using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;
using Sigma_Pets.Repository;

namespace Sigma_Pets.Controllers;

public class ClientesController : Controller
{
    private readonly IClientesRepository _clientesRepository;

    public ClientesController(IClientesRepository clientesRepository)
    {
        _clientesRepository = clientesRepository;
    }

    public IActionResult Index()
    {
        List<ClientesModel> clientes = _clientesRepository.listarClientes();
        return View(clientes);
    }
    public IActionResult Alterar(int id)
    {
        var clientes = _clientesRepository.buscarId(id);
        return View(clientes);
    }
    public IActionResult VerificarExcluir(int id)
    {
        var clientes = _clientesRepository.buscarId(id);
        return View(clientes);
    }

    public IActionResult Excluir(int id)
    {
        _clientesRepository.excluir(id);
        return RedirectToAction("Index");
    }
    public IActionResult Cadastrar()
    {
        return View();
    }

   [HttpPost]
    public IActionResult Cadastrar(ClientesModel clientes)
    {
        _clientesRepository.cadastrar(clientes);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Atualizar(ClientesModel clientes)
    {
        _clientesRepository.atualizar(clientes);
        return RedirectToAction("Index");
    }
}
