using System.ComponentModel.DataAnnotations;

namespace CarApplication_Mudblazor.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Modello { get; set; }

        [Required]
        public string? Marca { get; set; }

    
        public int Anno { get; set; }  
    }
}
