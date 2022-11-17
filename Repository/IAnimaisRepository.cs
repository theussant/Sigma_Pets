using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public interface IAnimaisRepository
    {
        AnimaisModel adicionar(AnimaisModel animal);

        List<AnimaisModel> listarAnimais();
        bool deletar(int id);

        AnimaisModel buscarId(int id);

        AnimaisModel atualizar(AnimaisModel animal);

        
    }
}