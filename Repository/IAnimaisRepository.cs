using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository{
    public interface IAnimaisRepository{

        AnimaisModel cadastrar(AnimaisModel animais);

        List<AnimaisModel> listarAnimais();
        bool excluir(int id);

        AnimaisModel buscarId(int id);

        AnimaisModel atualizar(AnimaisModel animais);
 
        
    }
}