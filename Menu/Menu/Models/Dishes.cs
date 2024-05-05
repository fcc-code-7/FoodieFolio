using System.ComponentModel.DataAnnotations;

namespace Menu.Models
{
    public class Dishes
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public string Description { get; set; } = string.Empty;

        public string IconUrl { get; set; } = string.Empty;

        public double price { get; set; }

        public List<Dishngredients>? dishngredients { get; set; }
    }
}
