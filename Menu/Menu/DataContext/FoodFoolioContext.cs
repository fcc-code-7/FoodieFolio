using Menu.Models;
using Microsoft.EntityFrameworkCore;

namespace Menu.DataContext
{
    public class FoodFoolioContext: DbContext
    {
        public FoodFoolioContext(DbContextOptions<FoodFoolioContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Setting has ForeignKey */

            modelBuilder.Entity<Dishngredients>().HasKey(di => new
            {
                di.DishId,
                di.IngredientId
            });

            /*Setting Relatioship */
            modelBuilder.Entity<Dishngredients>().HasOne(d => d.dishes).WithMany(di => di.dishngredients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<Dishngredients>().HasOne(i => i.Ingredients).WithMany(di => di.Dishngredients).HasForeignKey(i => i.IngredientId);
            base.OnModelCreating(modelBuilder);

            /*Setting Data in Databse */
            modelBuilder.Entity<Dishes>().HasData(new Dishes
            {
                Id=1,
                Title= "Margherita",
                Description= "Pizza Margherita or Margherita pizza is a typical Neapolitan pizza, roundish in shape with a raised edge and garnished with hand-crushed peeled tomatoes, mozzarella, fresh basil leaves, and extra virgin olive oil. The dough is made by mixing water, salt and yeast with flour.",
                IconUrl= "https://www.google.com/imgres?q=margherita%20pizza&imgurl=https%3A%2F%2Fau.ooni.com%2Fcdn%2Fshop%2Farticles%2F20220211142645-margherita-9920.jpg%3Fcrop%3Dcenter%26height%3D800%26v%3D1662539926%26width%3D800&imgrefurl=https%3A%2F%2Fau.ooni.com%2Fblogs%2Frecipes%2Fmargherita-pizza&docid=QnwZSuVaEWOuDM&tbnid=QpzZoTwQ6JhOtM&vet=12ahUKEwi1v5GK2fWFAxW88bsIHeiKAKEQM3oECGUQAA..i&w=800&h=800&hcb=2&ved=2ahUKEwi1v5GK2fWFAxW88bsIHeiKAKEQM3oECGUQAA",
                price= 7.50
            });

            modelBuilder.Entity<Ingredients>().HasData(new Ingredients
            {
                Id = 1,
                Name= "fresh mozzarella"
            }
            ,new Ingredients
            {
                Id=2,
                Name= "olive oil"
            }
            );
            modelBuilder.Entity<Dishngredients>().HasData(new Dishngredients
            {
                DishId=1,
                IngredientId=1
            },
              new Dishngredients
              {
                  DishId =1,
                  IngredientId = 2
              } 
            );

        }

        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<Ingredients> Ingredients { get; set;}
        public DbSet<Dishngredients> Dishngredients { get; set; }
    }
}
