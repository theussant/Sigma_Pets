using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly AnimaisContext produtos_Context;
        public ProdutosRepository(AnimaisContext animaisContext)
        {
            produtos_Context = animaisContext;
        }

        public ProdutosModel cadastrar(ProdutosModel produtos )
        {
            produtos_Context.Produtos.Add(produtos);
            produtos_Context.SaveChanges();
            return produtos;

        }

        public ProdutosModel buscarId(int id)
        {
            return produtos_Context.Produtos.FirstOrDefault(x => x.Id == id);
        }

        public List<ProdutosModel> listarProdutos()
        {
            return produtos_Context.Produtos.ToList();
        }


        public ProdutosModel atualizar(ProdutosModel produtos)
        {
            ProdutosModel produtosDB = buscarId(produtos.Id);

            if (produtosDB == null) throw new Exception("Houve um erro");

            produtosDB.Nome = produtos.Nome;
            produtosDB.Valor = produtos.Valor;
            produtosDB.Marca = produtos.Marca;
            produtosDB.DataFabri = produtos.DataFabri;
            produtosDB.DataVali = produtos.DataVali;
            produtosDB.Funcionalidade = produtos.Funcionalidade;
            produtosDB.CodBarra = produtos.CodBarra;

            produtos_Context.Produtos.Update(produtosDB);
            produtos_Context.SaveChanges();
            return produtosDB;
        }

        public bool excluir(int id)
        {
            ProdutosModel produtosDB = buscarId(id);

            if (produtosDB == null) throw new Exception("Houve um erro");

            produtos_Context.Produtos.Remove(produtosDB);
            produtos_Context.SaveChanges();
            return true;
        }
    }
}

