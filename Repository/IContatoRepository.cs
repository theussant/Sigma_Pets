using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public interface IContatoRepository
    {
        ContatoModel adicionar(ContatoModel contato);

        List<ContatoModel> listarContatos();
        bool deletar(int id);

        ContatoModel buscarId(int id);

        ContatoModel atualizar(ContatoModel contato);

        
    }
}