namespace Menu.Models
{
    public class Dishngredients
    {
        public int DishId { get; set; }
        public Dishes dishes { get; set; }

        public int IngredientId { get; set; }
        public Ingredients Ingredients { get; set; }

    }
}
