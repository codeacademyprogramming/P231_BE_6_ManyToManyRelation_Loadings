using System.ComponentModel.DataAnnotations;

namespace P231Yummy.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
