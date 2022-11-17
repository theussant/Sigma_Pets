using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;
using Sigma_Pets.Repository;

namespace Sigma_Pets.Controllers;

public class AnimaisController : Controller
{
    private readonly IAnimaisRepository _animaisRepository;

    public AnimaisController(IAnimaisRepository animaisRepository)
    {
        _animaisRepository = animaisRepository;
    }

    public IActionResult Index()
    {
        List<AnimaisModel> animais = _animaisRepository.listarAnimais();
        return View(animais);
    }
    public IActionResult Alterar(int id)
    {
        var animais = _animaisRepository.buscarId(id);
        return View(animais);
    }
    public IActionResult VerificarExcluir(int id)
    {
        var animais = _animaisRepository.buscarId(id);
        return View(animais);
    }

    public IActionResult Excluir(int id)
    {
        _animaisRepository.excluir(id);
        return RedirectToAction("Index");
    }
    public IActionResult Cadastrar()
    {
        return View();
    }

   [HttpPost]
    public IActionResult Cadastrar(AnimaisModel animais)
    {
        _animaisRepository.cadastrar(animais);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Atualizar(AnimaisModel animais)
    {
        _animaisRepository.atualizar(animais);
        return RedirectToAction("Index");
    }
}
