using System.ComponentModel.DataAnnotations;

namespace Atividade2.Model
{
    public class Whisky
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public String Marca { get; set; }
        [Required]
        public String Volume { get; set; }
        [Required]
        public String Sabor { get; set; }

    }
}
