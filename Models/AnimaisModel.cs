using System.ComponentModel.DataAnnotations;

namespace Sigma_Pets.Models
{
    public class AnimaisModel
    {
        [Key]
        public int Id {get; set; }
        public string Nome {get; set;}
        public string Genero {get; set;}
        public int Idade {get; set;}
        public string Tipo {get; set;}
        public string Raça {get; set;}
        public string Porte {get; set;}
        public string Castrado {get; set;}
        public string ClienteId {get; set;}

        
    }
}