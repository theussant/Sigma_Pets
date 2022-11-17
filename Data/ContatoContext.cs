using Microsoft.EntityFrameworkCore;
using Sigma_Pets.Models;

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
    }

}