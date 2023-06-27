using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastFoodAPI.Model
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }
        [Required]
        public bool is_Vegetariano { get; set; }
        [Required]
        public int Eta { get; set; }
    }
}
