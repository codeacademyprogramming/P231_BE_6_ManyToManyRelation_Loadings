using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P231Yummy.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(35)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [MaxLength(100)]
        public string ImageName { get; set; }
        public Category Category { get; set; }
        public List<MealIngredient> MealIngredients { get; set; }

    }
}
