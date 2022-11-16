using System.ComponentModel.DataAnnotations;

namespace Sigma_Pets.Models
{
    public class ClientesModel
    {
        [Key]
        public int Id {get; set; }
        public string Nome {get; set;}
        public string Endereco {get; set;}
        public DateOnly DataNasc {get; set;}
        public string Genero {get; set;}
        public string Telefone {get; set;}
        public int Idade {get; set;}
     
    }
}