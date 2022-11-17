using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public class ServicosRepository : IServicosRepository
    {
        private readonly AnimaisContext servicos_Context;
        public ServicosRepository(AnimaisContext animaisContext)
        {
            servicos_Context = animaisContext;
        }

        public ServicosModel cadastrar(ServicosModel servicos)
        {
            servicos_Context.Servicos.Add(servicos);
            servicos_Context.SaveChanges();
            return servicos;

        }

        public ServicosModel buscarId(int id)
        {
            return servicos_Context.Servicos.FirstOrDefault(x => x.Id == id);
        }

        public List<ServicosModel> listarServicos()
        {
            return servicos_Context.Servicos.ToList();
        }


        public ServicosModel atualizar(ServicosModel servicos)
        {
            ServicosModel servicosDB = buscarId(servicos.Id);

            if (servicosDB == null) throw new Exception("Houve um erro");

            servicosDB.Nome = servicos.Nome;
            servicosDB.Tipo = servicos.Tipo;
            servicosDB.Valor = servicos.Valor;

            servicos_Context.Servicos.Update(servicosDB);
            servicos_Context.SaveChanges();
            return servicosDB;
        }

        public bool excluir(int id)
        {
            ServicosModel servicosDB = buscarId(id);

            if (servicosDB == null) throw new Exception("Houve um erro");

            servicos_Context.Servicos.Remove(servicosDB);
            servicos_Context.SaveChanges();
            return true;
        }
    }
}

