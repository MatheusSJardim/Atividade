using System.ComponentModel.DataAnnotations;

namespace Atividade2.Model
{
    public class Cliente
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; } 
        [Required]
        public String CPF { get; set; }
        [Required]
        public int CEP { get; set; }
        [Required]
        public String Endereco { get; set; }

    }
}
