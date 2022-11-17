using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository{
    public interface IProdutosRepository{

        ProdutosModel cadastrar(ProdutosModel produtos);

        List<ProdutosModel> listarProdutos();
        bool excluir(int id);

        ProdutosModel buscarId(int id);

        ProdutosModel atualizar(ProdutosModel produtos);
 
        
    }
}