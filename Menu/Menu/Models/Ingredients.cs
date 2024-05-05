using System.ComponentModel.DataAnnotations;

namespace Menu.Models
{
    public class Ingredients
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Dishngredients>? Dishngredients { get; set; }
    }
}
