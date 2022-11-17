using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public class ServicosRepository : IServicosRepository
    {
        private readonly ContatoContext servicos_Context;
        public ServicosRepository(ContatoContext servicosContext)
        {
            servicos_Context = servicosContext;
        }
 
        public ServicosModel adicionar(ServicosModel servicos)
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

            // MATHEUS VC ESTà AQ
        public ServicosModel atualizar(ServicosModel servicos){
            ServicosModel servicosDB = buscarId(servicos.Id);

            if(servicosDB == null) throw new Exception("Houve um erro");
            
            servicosDB.Nome = servicos.Nome;
            servicosDB.Valor = servicos.Valor;
            servicosDB.Tipo = servicos.Tipo;
           
            servicos_Context.Servicos.Update(servicosDB);
            servicos_Context.SaveChanges();
            return servicosDB;
        }

        public bool deletar(int id)
        {
            ServicosModel servicosDB = buscarId(id);

            if(servicosDB == null) throw new Exception("Houve um erro");
            
            servicos_Context.Servicos.Remove(servicosDB);
            servicos_Context.SaveChanges();
            return true;
        }
    }
}