using System.ComponentModel.DataAnnotations;

namespace Sigma_Pets.Models
{
    public class ProdutosModel
    {
        [Key]
        public int Id {get; set; }
        public string Nome {get; set;}
        public float Valor {get; set;}
        public string Marca {get; set;}
        public DateOnly DataFabri {get; set;}
        public DateOnly DataVali {get; set;}
        public string Funcionalidade {get; set;}
        public string Fornecedor {get; set;}
        public int CodBarra {get; set;}

        
    }
}