using System.ComponentModel.DataAnnotations;

namespace Sigma_Pets.Models
{
    public class ServicosModel
    {
        [Key]
        public int Id {get; set; }
        public string Nome {get; set;}
        public string Tipo {get; set;}
        public float Valor {get; set;}
   
    }
}