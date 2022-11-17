using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sigma_Pets.Data;
using Sigma_Pets.Models;

namespace Sigma_Pets.Repository
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly AnimaisContext clientes_Context;
        public ClientesRepository(AnimaisContext animaisContext)
        {
            clientes_Context = animaisContext;
        }

        public ClientesModel cadastrar(ClientesModel clientes)
        {
            clientes_Context.Clientes.Add(clientes);
            clientes_Context.SaveChanges();
            return clientes;

        }

        public ClientesModel buscarId(int id)
        {
            return clientes_Context.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public List<ClientesModel> listarClientes()
        {
            return clientes_Context.Clientes.ToList();
        }


        public ClientesModel atualizar(ClientesModel clientes)
        {
            ClientesModel clientesDB = buscarId(clientes.Id);

            if (clientesDB == null) throw new Exception("Houve um erro");

            clientesDB.Nome = clientes.Nome;
            clientesDB.Genero = clientes.Genero;
            clientesDB.Idade = clientes.Idade;
            clientesDB.Endereco = clientes.Endereco;
            clientesDB.Telefone = clientes.Telefone;

            clientes_Context.Clientes.Update(clientesDB);
            clientes_Context.SaveChanges();
            return clientesDB;
        }

        public bool excluir(int id)
        {
            ClientesModel clientesDB = buscarId(id);

            if (clientesDB == null) throw new Exception("Houve um erro");

            clientes_Context.Clientes.Remove(clientesDB);
            clientes_Context.SaveChanges();
            return true;
        }
    }
}

