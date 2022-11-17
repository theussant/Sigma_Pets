using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public class AnimaisRepository : IAnimaisRepository
    {
        private readonly ContatoContext animal_Context;
        public AnimaisRepository(ContatoContext animalContext)
        {
            animal_Context = animalContext;
        }
 
        public AnimaisModel adicionar(AnimaisModel animal)
        {
            animal_Context.Animais.Add(animal);
            animal_Context.SaveChanges();
            return animal;
         
        }

        public AnimaisModel buscarId(int id)
        {
            return animal_Context.Animais.FirstOrDefault(x => x.Id == id);
        }

        public List<AnimaisModel> listarAnimais()
        {
            return animal_Context.Animais.ToList();
        }


        public AnimaisModel atualizar(AnimaisModel animal){
            AnimaisModel animalDB = buscarId(animal.Id);

            if(animalDB == null) throw new Exception("Houve um erro");
            
            animalDB.Nome = animal.Nome;
            animalDB.Genero = animal.Genero;
            animalDB.Idade = animal.Idade;
            animalDB.Tipo = animal.Tipo;
            animalDB.Raca = animal.Raca;
            animalDB.Porte = animal.Porte;
            animalDB.Castrado = animal.Castrado;
        
            animal_Context.Animais.Update(animalDB);
            animal_Context.SaveChanges();
            return animalDB;
        }

        public bool deletar(int id)
        {
            AnimaisModel animalDB = buscarId(id);

            if(animalDB == null) throw new Exception("Houve um erro");
            
            animal_Context.Animais.Remove(animalDB);
            animal_Context.SaveChanges();
            return true;
        }
    }
}