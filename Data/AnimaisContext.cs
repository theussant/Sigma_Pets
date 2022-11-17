using Sigma_Pets.Models;
using Microsoft.EntityFrameworkCore;

namespace Sigma_Pets.Data
{
    public class AnimaisContext : DbContext
    {
        public AnimaisContext(DbContextOptions<AnimaisContext> options) : base (options)
        {

        }
        public DbSet<AnimaisModel> Animais {get;set;}
        public DbSet<ProdutosModel> Produtos {get;set;}
        public DbSet<ServicosModel> Servicos {get;set;}
        public DbSet<ClientesModel> Clientes {get;set;}
    }
    
}