

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public interface IProdutoRepository
    {
        ProdutoModel adicionar(ProdutoModel produto);

        List<ProdutoModel> listarProdutos();
        bool deletar(int id);

        ProdutoModel buscarId(int id);

        ProdutoModel atualizar(ProdutoModel produto);

        
    }
}