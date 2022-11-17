using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;
using Sigma_Pets.Repository;

namespace Sigma_Pets.Controllers;

public class ProdutosController : Controller
{
    private readonly IProdutosRepository _produtosRepository;

    public ProdutosController(IProdutosRepository produtosRepository)
    {
        _produtosRepository = produtosRepository;
    }

    public IActionResult Index()
    {
        List<ProdutosModel> produtos = _produtosRepository.listarProdutos();
        return View(produtos);
    }
    public IActionResult Alterar(int id)
    {
        var produtos = _produtosRepository.buscarId(id);
        return View(produtos);
    }
    public IActionResult VerificarExcluir(int id)
    {
        var produtos = _produtosRepository.buscarId(id);
        return View(produtos);
    }

    public IActionResult Excluir(int id)
    {
        _produtosRepository.excluir(id);
        return RedirectToAction("Index");
    }
    public IActionResult Cadastrar()
    {
        return View();
    }

   [HttpPost]
    public IActionResult Cadastrar(ProdutosModel produtos)
    {
        _produtosRepository.cadastrar(produtos);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Atualizar(ProdutosModel produtos)
    {
        _produtosRepository.atualizar(produtos);
        return RedirectToAction("Index");
    }
}
