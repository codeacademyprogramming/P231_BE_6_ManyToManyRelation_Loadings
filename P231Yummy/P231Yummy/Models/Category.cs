using System.ComponentModel.DataAnnotations;

namespace P231Yummy.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

    }
}
