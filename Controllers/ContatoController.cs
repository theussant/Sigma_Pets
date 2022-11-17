using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;
using Sigma_Pets.Repository;

namespace Sigma_Pets.Controllers;

public class ContatoController : Controller
{
    private readonly IContatoRepository _contatoRepository;
    public ContatoController(IContatoRepository contatoRepository)
    {
        _contatoRepository = contatoRepository;
    }

    public IActionResult Index()
    {
        List<ContatoModel> contatos = _contatoRepository.listarContatos();
        return View(contatos);
    }

    public IActionResult Criar()
    {
        return View();
    }
    public IActionResult Editar(int id)
    {
        var contato = _contatoRepository.buscarId(id);
        return View(contato);
    }
    public IActionResult VerificarDeletar(int id)
    {
        var contato = _contatoRepository.buscarId(id);
        return View(contato);
    }

     public IActionResult deletar(int id)
    {
        _contatoRepository.deletar(id);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Criar(ContatoModel contato)
    {
        _contatoRepository.adicionar(contato);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Atualizar(ContatoModel contato)
    {
        _contatoRepository.atualizar(contato);
        return RedirectToAction("Index");
    }


}
