using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;
using Sigma_Pets.Repository;

namespace CRUDMVC.Controllers;

public class ProdutoController : Controller
{
    private readonly IProdutoRepository _produtoRepository;
    public ProdutoController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public IActionResult Index()
    {
        List<ProdutoModel> produto = _produtoRepository.listarProdutos();
        return View(produto);
    }

    public IActionResult Cadastrar()
    {
        return View();
    }

   public IActionResult Alterar(int id)
    {
        var produto = _produtoRepository.buscarId(id);
        return View(produto);
    }
    public IActionResult VerificarDeletar(int id)
    {
        var produto = _produtoRepository.buscarId(id);
        return View(produto);
    }

     public IActionResult deletar(int id)
    {
        _produtoRepository.deletar(id);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Cadastrar(ProdutoModel produto)
    {
        _produtoRepository.adicionar(produto);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Atualizar(ProdutoModel produto)
    {
        _produtoRepository.atualizar(produto);
        return RedirectToAction("Index");
    }
}
