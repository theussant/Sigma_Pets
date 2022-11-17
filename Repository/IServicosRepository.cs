

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public interface IServicosRepository
    {
        ServicosModel adicionar(ServicosModel servicos);

        List<ServicosModel> listarServicos();
        bool deletar(int id);

        ServicosModel buscarId(int id);

        ServicosModel atualizar(ServicosModel servicos);

        
    }
}