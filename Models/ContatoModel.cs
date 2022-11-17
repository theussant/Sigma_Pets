using System.ComponentModel.DataAnnotations;

namespace Sigma_Pets.Models
{
    public class ContatoModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}