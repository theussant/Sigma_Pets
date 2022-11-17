using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Models;
using Sigma_Pets.Repository;

namespace CRUDMVC.Controllers;

public class AnimaisController : Controller
{
    private readonly IAnimaisRepository _animaisRepository;
    public AnimaisController(IAnimaisRepository animalRepository)
    {
        _animaisRepository = animalRepository;
    }

    public IActionResult Index()
    {
        List<AnimaisModel> animais = _animaisRepository.listarAnimais();
        return View(animais);
    }

    public IActionResult Cadastrar()
    {
        return View();
    }

   public IActionResult Alterar(int id)
    {
        var animal = _animaisRepository.buscarId(id);
        return View(animal);
    }
    public IActionResult VerificarDeletar(int id)
    {
        var animal = _animaisRepository.buscarId(id);
        return View(animal);
    }

     public IActionResult deletar(int id)
    {
        _animaisRepository.deletar(id);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Cadastrar(AnimaisModel animal)
    {
        _animaisRepository.adicionar(animal);
        return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Atualizar(AnimaisModel animal)
    {
        _animaisRepository.atualizar(animal);
        return RedirectToAction("Index");
    }
}
