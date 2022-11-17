using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ContatoContext produto_Context;
        public ProdutoRepository(ContatoContext produtoContext)
        {
            produto_Context = produtoContext;
        }
 
        public ProdutoModel adicionar(ProdutoModel produto)
        {
            produto_Context.Produto.Add(produto);
            produto_Context.SaveChanges();
            return produto;
         
        }

        public ProdutoModel buscarId(int id)
        {
            return produto_Context.Produto.FirstOrDefault(x => x.Id == id);
        }

        public List<ProdutoModel> listarProdutos()
        {
            return produto_Context.Produto.ToList();
        }


        public ProdutoModel atualizar(ProdutoModel produto){
            ProdutoModel produtoDB = buscarId(produto.Id);

            if(produtoDB == null) throw new Exception("Houve um erro");
            
            produtoDB.Nome = produto.Nome;
            produtoDB.Valor = produto.Valor;
            produtoDB.Marca = produto.Marca;
            produtoDB.Dt_Fab = produto.Dt_Fab;
            produtoDB.Dt_Val = produto.Dt_Val;
            produtoDB.Funcionalidade = produto.Funcionalidade;
           
        
            produto_Context.Produto.Update(produtoDB);
            produto_Context.SaveChanges();
            return produtoDB;
        }

        public bool deletar(int id)
        {
            ProdutoModel produtoDB = buscarId(id);

            if(produtoDB == null) throw new Exception("Houve um erro");
            
            produto_Context.Produto.Remove(produtoDB);
            produto_Context.SaveChanges();
            return true;
        }
    }
}