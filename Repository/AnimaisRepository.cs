using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public class AnimaisRepository : IAnimaisRepository
    {
        private readonly AnimaisContext animais_Context;
        public AnimaisRepository(AnimaisContext animaisContext)
        {
            animais_Context = animaisContext;
        }

        public AnimaisModel cadastrar(AnimaisModel animais)
        {
            animais_Context.Animais.Add(animais);
            animais_Context.SaveChanges();
            return animais;

        }

        public AnimaisModel buscarId(int id)
        {
            return animais_Context.Animais.FirstOrDefault(x => x.Id == id);
        }

        public List<AnimaisModel> listarAnimais()
        {
            return animais_Context.Animais.ToList();
        }


        public AnimaisModel atualizar(AnimaisModel animais)
        {
            AnimaisModel animaisDB = buscarId(animais.Id);

            if (animaisDB == null) throw new Exception("Houve um erro");

            animaisDB.Nome = animais.Nome;
            animaisDB.Genero = animais.Genero;
            animaisDB.Idade = animais.Idade;
            animaisDB.Tipo = animais.Tipo;
            animaisDB.Raca = animais.Raca;
            animaisDB.Porte = animais.Porte;
            animaisDB.Castrado = animais.Castrado;

            animais_Context.Animais.Update(animaisDB);
            animais_Context.SaveChanges();
            return animaisDB;
        }

        public bool excluir(int id)
        {
            AnimaisModel animaisDB = buscarId(id);

            if (animaisDB == null) throw new Exception("Houve um erro");

            animais_Context.Animais.Remove(animaisDB);
            animais_Context.SaveChanges();
            return true;
        }
    }
}

