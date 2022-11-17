using Sigma_Pets.Models;
using Microsoft.EntityFrameworkCore;

namespace Sigma_Pets.Data
{
    public class ContatoContext : DbContext
    {
        public ContatoContext(DbContextOptions<ContatoContext> options) : base(options)
        {
        }
        public DbSet<ContatoModel> Contato {get;set;}
        public DbSet<AnimaisModel> Animais {get;set;}
        public DbSet<ProdutoModel> Produto {get;set;}
        public DbSet<ServicosModel> Servicos {get;set;}
        public DbSet<ClientesModel> Clientes {get;set;}
    }

}