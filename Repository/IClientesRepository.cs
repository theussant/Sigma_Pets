using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository{
    public interface IClientesRepository{

        ClientesModel cadastrar(ClientesModel clientes);

        List<ClientesModel> listarClientes();
        bool excluir(int id);

        ClientesModel buscarId(int id);

        ClientesModel atualizar(ClientesModel clientes);
 
        
    }
}