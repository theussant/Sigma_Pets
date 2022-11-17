using System.ComponentModel.DataAnnotations;

namespace Sigma_Pets.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public string Marca { get; set; }
        public string Dt_Fab { get; set; }
        public string Dt_Val { get; set; }
        public string Funcionalidade { get; set; }
    

    }
}