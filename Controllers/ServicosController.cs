using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;
using Sigma_Pets.Repository;

namespace Sigma_Pets.Controllers;

public class ServicosController : Controller
{
    private readonly IServicosRepository _servicosRepository;

    public ServicosController(IServicosRepository servicosRepository)
    {
        _servicosRepository = servicosRepository;
    }

    public IActionResult Index()
    {
        List<ServicosModel> servicos = _servicosRepository.listarServicos();
        return View(servicos);
    }
    public IActionResult Alterar(int id)
    {
        var servicos = _servicosRepository.buscarId(id);
        return View(servicos);
    }
    public IActionResult VerificarExcluir(int id)
    {
        var servicos = _servicosRepository.buscarId(id);
        return View(servicos);
    }

    public IActionResult Deletar(int id)
    {
        _servicosRepository.deletar(id);
        return RedirectToAction("Index");
    }
    public IActionResult Cadastrar()
    {
        return View();
    }

   [HttpPost]
    public IActionResult Cadastrar(ServicosModel servicos)
    {
        _servicosRepository.adicionar(servicos);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Atualizar(ServicosModel servicos)
    {
        _servicosRepository.atualizar(servicos);
        return RedirectToAction("Index");
    }
}