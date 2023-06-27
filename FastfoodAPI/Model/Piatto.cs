using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastFoodAPI.Model
{

    [Table("piatto")]
    public class Piatto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Descrizione { get; set; }
        public bool is_Vegetariano { get; set; }
        [Required]
        public int prezzo { get; set; }
    }
}
