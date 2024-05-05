using Menu.Models;
using Microsoft.EntityFrameworkCore;

namespace Menu.DataContext
{
    public class FoodFoolioContext : DbContext
    {
        public FoodFoolioContext(DbContextOptions<FoodFoolioContext> options) : base(options)
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

            modelBuilder.Entity<Dishes>().HasData(
   // **Pizza (3)**
   new Dishes { Id = 1, Title = "Margherita", Description = "A classic pizza with a simple yet flavorful combination of tomato sauce, mozzarella cheese, and fresh basil leaves.", IconUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSxsG9qQnPbVfptj92kjVpfdbpL4D8suUcIN0aFP7FGRJDLUKxtdVwKTV2ItvzO", price = 7.50 },
   new Dishes { Id = 2, Title = "Pepperoni", Description = "A savory pizza topped with tomato sauce, mozzarella cheese, and slices of pepperoni.", IconUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQM7Huw9KIbgfKhUvsiYQM2rIgEiutB9C1av6QdWIN1cOylbKZBG4fO9vtrZ4yg", price = 8.00 },
   new Dishes { Id = 3, Title = "Hawaiian", Description = "A sweet and savory pizza with a combination of tomato sauce, mozzarella cheese, ham, and pineapple chunks.", IconUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQMr1lt-dtorMSZZ-nRdt1pXYTiIFyw67wLEPyJduDdChZFpoO2xjXHEVDemAJ1", price = 8.50 },

   // **Pasta (3)**
   new Dishes { Id = 4, Title = "Spaghetti Bolognese", Description = ".A hearty pasta dish with spaghetti noodles tossed in a rich meat sauce made with ground beef, tomatoes, and herbs.", IconUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQcSWMzXC-JRbwX3_tFph1GKKiVZHR3rVZgLUWcRVO7C_mIziPJgVAB0KJW4GfT", price = 9.00 },
   new Dishes { Id = 5, Title = "Lasagna", Description = "A layered pasta dish with lasagna noodles, ricotta cheese, mozzarella cheese, tomato sauce, and ground meat.", IconUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcR5RXtq-tqkSkPiWN7tWoJKSrHp-2aa7HQVX8rPz4O0w_TM5dByVQwEEmPxjxF5", price = 10.00 },
   new Dishes { Id = 6, Title = "Penne Alfredo", Description = "A creamy pasta dish with penne noodles tossed in a Parmesan cheese sauce with butter and black pepper.", IconUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYTLZLqzRg7MzSiOxfXgHfc2kbQxXjciNHSN2T3UQY1P3cpXCFYVdg_1vE06IP", price = 8.50 },

   // **Salads (3)**
   new Dishes { Id = 7, Title = "Caesar Salad", Description = "A refreshing salad with romaine lettuce, croutons, Parmesan cheese, and a creamy Caesar dressing.", IconUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRY_eHLujovQQKHoeGQ2ho_R73kjUG-tcme2kuFnrYYFsgPenARAOmeRHv4EtNN", price = 7.00 },
   new Dishes { Id = 8, Title = "Greek Salad", Description = "A flavorful salad with tomatoes, cucumbers, olives, feta cheese, red onions, and a vinaigrette dressing.", IconUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcS7BGGe7zXLXiMk3iGCL3y_KYmn_R8ix7eUmMKciJLtFYXks3sQrqlQeCacNRmh", price = 8.00 },
   new Dishes { Id = 9, Title = "Caprese Salad", Description = "A simple yet elegant salad with sliced tomatoes, fresh mozzarella cheese, basil leaves, and a drizzle of olive oil.", IconUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRqzkSO9s8p9QHaVspPV5DjYxJokiiCPeQBRm8tdPLKI_oR11VUU-sxLQg3wUcb", price = 6.50 },

   // **Main Courses (3)**
   new Dishes { Id = 10, Title = "Grilled Chicken", Description = "A healthy and flavorful dish of grilled chicken breast, seasoned and cooked to perfection.", IconUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSgN-KUvxE4w71iUPs972XH_7Xx_x_6YuavBDsEo9aBlCNCVCj-4i6K2Rbr3ZHb", price = 12.00 },
   new Dishes { Id = 11, Title = "Salmon with Roasted Vegetables", Description = "A nutritious dish featuring roasted salmon served with a variety of roasted vegetables.", IconUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSg7Lk_L0otNgiJvXq7DBc7eie38_8HENKA8mJcZKRwPJcD4hKsiL4EfgXWL0JF", price = 14.00 },
   new Dishes { Id = 12, Title = "Beef Stew", Description = "A comforting and hearty stew made with beef, vegetables, and a rich broth.", IconUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTQ48Ukd0OSZLbGDGuBe4p3ds32NZvRhYDKxgfBMzvglgO2OnnA9aF5xbM9Pj8J", price = 13.50 },

   // **Desserts (3)**
   new Dishes { Id = 13, Title = "Chocolate Cake", Description = "A decadent chocolate cake, perfect for satisfying your sweet tooth.", IconUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTEiGGqQ2hhECMjGf7l53cQd08LaXaBhzyVVzToUY6tGmnyz6V2FFok-qmPN25g", price = 5.00 },
   new Dishes { Id = 14, Title = "Cheesecake", Description = "A creamy and delicious cheesecake, a classic dessert favorite.", IconUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvcp9lQnaRjUfNivxdDDCctlee0fb7euLGUMpnnEzGkIvuaWeZ8tGHMuwrkBxp", price = 5.50 },
   new Dishes { Id = 15, Title = "Tiramisu", Description = "An Italian coffee-flavored dessert made with ladyfingers, mascarpone cheese, cocoa powder, and coffee.", IconUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcR03GLSb-AGl6J-BRf37jAzisO6CPUCJohEMSv4lxmkQ2FXHRohhX2iohc6UFNu", price = 6.00 }
 );


            modelBuilder.Entity<Ingredients>().HasData(
     // General ingredients
     new Ingredients { Id = 1, Name = "tomato sauce" },
     new Ingredients { Id = 2, Name = "mozzarella cheese" },
     new Ingredients { Id = 3, Name = "pepperoni" },
     new Ingredients { Id = 4, Name = "ham" },
     new Ingredients { Id = 5, Name = "pineapple" },
     new Ingredients { Id = 6, Name = "ground beef" },
     new Ingredients { Id = 7, Name = "pasta" },
     new Ingredients { Id = 8, Name = "basil" },
     new Ingredients { Id = 9, Name = "olive oil" },
     new Ingredients { Id = 10, Name = "garlic" },
     new Ingredients { Id = 11, Name = "parmesan cheese" },
     new Ingredients { Id = 12, Name = "chicken breast" },
     new Ingredients { Id = 13, Name = "salmon fillet" },
     new Ingredients { Id = 14, Name = "vegetables (mixed)" },
     new Ingredients { Id = 15, Name = "beef" },
     new Ingredients { Id = 16, Name = "potatoes" },
     new Ingredients { Id = 17, Name = "carrots" },
     new Ingredients { Id = 18, Name = "celery" },
     new Ingredients { Id = 19, Name = "eggs" },
     new Ingredients { Id = 20, Name = "cream cheese" },
     new Ingredients { Id = 21, Name = "cocoa powder" },
     new Ingredients { Id = 22, Name = "ladyfingers" },
     new Ingredients { Id = 23, Name = "mascarpone cheese" },
     new Ingredients { Id = 24, Name = "coffee" }
   );

            modelBuilder.Entity<Dishngredients>().HasData(
   // Pizzas
   new Dishngredients { DishId = 1, IngredientId = 8 },  // Margherita - basil
   new Dishngredients { DishId = 1, IngredientId = 9 },  // Margherita - olive oil
   new Dishngredients { DishId = 2, IngredientId = 1 },  // Pepperoni - tomato sauce
   new Dishngredients { DishId = 2, IngredientId = 2 },  // Pepperoni - mozzarella cheese
   new Dishngredients { DishId = 2, IngredientId = 3 },  // Pepperoni - pepperoni
   new Dishngredients { DishId = 2, IngredientId = 8 },  // Pepperoni - basil
   new Dishngredients { DishId = 2, IngredientId = 9 },  // Pepperoni - olive oil
   new Dishngredients { DishId = 3, IngredientId = 1 },  // Hawaiian - tomato sauce
   new Dishngredients { DishId = 3, IngredientId = 2 },  // Hawaiian - mozzarella cheese
   new Dishngredients { DishId = 3, IngredientId = 4 },  // Hawaiian - ham
   new Dishngredients { DishId = 3, IngredientId = 5 },  // Hawaiian - pineapple
   new Dishngredients { DishId = 3, IngredientId = 8 },  // Hawaiian - basil
   new Dishngredients { DishId = 3, IngredientId = 9 },  // Hawaiian - olive oil

   // Pastas
   new Dishngredients { DishId = 4, IngredientId = 7 },  // Spaghetti Bolognese - pasta
   new Dishngredients { DishId = 4, IngredientId = 6 },  // Spaghetti Bolognese - ground beef
   new Dishngredients { DishId = 4, IngredientId = 10 }, // Spaghetti Bolognese - garlic
   new Dishngredients { DishId = 4, IngredientId = 11 }, // Spaghetti Bolognese - parmesan cheese
   new Dishngredients { DishId = 4, IngredientId = 9 },  // Spaghetti Bolognese - olive oil
   new Dishngredients { DishId = 5, IngredientId = 7 },
  new Dishngredients { DishId = 5, IngredientId = 11 }, // Lasagna - parmesan cheese
  new Dishngredients { DishId = 5, IngredientId = 2 },  // Lasagna - mozzarella cheese
  new Dishngredients { DishId = 5, IngredientId = 10 }, // Lasagna - garlic
  new Dishngredients { DishId = 5, IngredientId = 9 },  // Lasagna - olive oil
  new Dishngredients { DishId = 6, IngredientId = 7 },  // Penne Alfredo - pasta
  new Dishngredients { DishId = 6, IngredientId = 20 }, // Penne Alfredo - cream cheese
  new Dishngredients { DishId = 6, IngredientId = 11 }, // Penne Alfredo - parmesan cheese
  new Dishngredients { DishId = 6, IngredientId = 9 },  // Penne Alfredo - olive oil

  // Salads
  new Dishngredients { DishId = 7, IngredientId = 8 }, // Caesar Salad - basil
  new Dishngredients { DishId = 7, IngredientId = 11 }, // Caesar Salad - parmesan cheese
  new Dishngredients { DishId = 7, IngredientId = 19 }, // Caesar Salad - eggs
  new Dishngredients { DishId = 8, IngredientId = 8 }, // Greek Salad - basil
  new Dishngredients { DishId = 8, IngredientId = 14 }, // Greek Salad - vegetables (mixed)
  new Dishngredients { DishId = 8, IngredientId = 10 }, // Greek Salad - garlic
  new Dishngredients { DishId = 8, IngredientId = 9 },  // Greek Salad - olive oil
  new Dishngredients { DishId = 9, IngredientId = 8 }, // Caprese Salad - basil
  new Dishngredients { DishId = 9, IngredientId = 2 },  // Caprese Salad - mozzarella cheese
  new Dishngredients { DishId = 9, IngredientId = 1 },  // Caprese Salad - tomato sauce (optional)
  new Dishngredients { DishId = 9, IngredientId = 9 },  // Caprese Salad - olive oil

  // Main Courses
  new Dishngredients { DishId = 10, IngredientId = 12 }, // Grilled Chicken - chicken breast
  new Dishngredients { DishId = 10, IngredientId = 14 }, // Grilled Chicken - vegetables (mixed) (optional)
  new Dishngredients { DishId = 10, IngredientId = 9 },  // Grilled Chicken - olive oil
  new Dishngredients { DishId = 11, IngredientId = 13 }, // Salmon with Roasted Vegetables - salmon fillet
  new Dishngredients { DishId = 11, IngredientId = 14 }, // Salmon with Roasted Vegetables - vegetables (mixed)
  new Dishngredients { DishId = 11, IngredientId = 9 },  // Salmon with Roasted Vegetables - olive oil
  new Dishngredients { DishId = 12, IngredientId = 15 }, // Beef Stew - beef
  new Dishngredients { DishId = 12, IngredientId = 16 }, // Beef Stew - potatoes
  new Dishngredients { DishId = 12, IngredientId = 17 }, // Beef Stew - carrots
  new Dishngredients { DishId = 12, IngredientId = 18 }, // Beef Stew - celery
  new Dishngredients { DishId = 12, IngredientId = 10 }, // Beef Stew - garlic
  new Dishngredients { DishId = 12, IngredientId = 9 },  // Beef Stew - olive oil

  // Desserts
  new Dishngredients { DishId = 13, IngredientId = 19 }, // Chocolate Cake - eggs
  new Dishngredients { DishId = 13, IngredientId = 20 }, // Chocolate Cake - cream cheese
  new Dishngredients { DishId = 13, IngredientId = 21 }, // Chocolate Cake - cocoa powder
  new Dishngredients { DishId = 14, IngredientId = 19 }, // Cheesecake - eggs
  new Dishngredients { DishId = 14, IngredientId = 20 }, // Cheesecake - cream cheese
  new Dishngredients { DishId = 14, IngredientId = 2 },  // Cheesecake - mozzarella cheese (optional)
  new Dishngredients { DishId = 15, IngredientId = 19 }, // Tiramisu - eggs
  new Dishngredients { DishId = 15, IngredientId = 23 }, // Tiramisu - mascarpone cheese
  new Dishngredients { DishId = 15, IngredientId = 22 }, // Tiramisu - ladyfingers
  new Dishngredients { DishId = 15, IngredientId = 24 }, // Tiramisu - coffee
  new Dishngredients { DishId = 15, IngredientId = 20 }, // Tiramisu - cream cheese (optional)
  new Dishngredients { DishId = 15, IngredientId = 21 }  // Tiramisu - cocoa powder (optional)

  );

        }
       

        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Dishngredients> Dishngredients { get; set; }
    }
}
