using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Menu.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dishngredients",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishngredients", x => new { x.DishId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_Dishngredients_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dishngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Description", "IconUrl", "Title", "price" },
                values: new object[,]
                {
                    { 1, "A classic pizza with a simple yet flavorful combination of tomato sauce, mozzarella cheese, and fresh basil leaves.", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSxsG9qQnPbVfptj92kjVpfdbpL4D8suUcIN0aFP7FGRJDLUKxtdVwKTV2ItvzO", "Margherita", 7.5 },
                    { 2, "A savory pizza topped with tomato sauce, mozzarella cheese, and slices of pepperoni.", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQM7Huw9KIbgfKhUvsiYQM2rIgEiutB9C1av6QdWIN1cOylbKZBG4fO9vtrZ4yg", "Pepperoni", 8.0 },
                    { 3, "A sweet and savory pizza with a combination of tomato sauce, mozzarella cheese, ham, and pineapple chunks.", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQMr1lt-dtorMSZZ-nRdt1pXYTiIFyw67wLEPyJduDdChZFpoO2xjXHEVDemAJ1", "Hawaiian", 8.5 },
                    { 4, ".A hearty pasta dish with spaghetti noodles tossed in a rich meat sauce made with ground beef, tomatoes, and herbs.", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQcSWMzXC-JRbwX3_tFph1GKKiVZHR3rVZgLUWcRVO7C_mIziPJgVAB0KJW4GfT", "Spaghetti Bolognese", 9.0 },
                    { 5, "A layered pasta dish with lasagna noodles, ricotta cheese, mozzarella cheese, tomato sauce, and ground meat.", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcR5RXtq-tqkSkPiWN7tWoJKSrHp-2aa7HQVX8rPz4O0w_TM5dByVQwEEmPxjxF5", "Lasagna", 10.0 },
                    { 6, "A creamy pasta dish with penne noodles tossed in a Parmesan cheese sauce with butter and black pepper.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYTLZLqzRg7MzSiOxfXgHfc2kbQxXjciNHSN2T3UQY1P3cpXCFYVdg_1vE06IP", "Penne Alfredo", 8.5 },
                    { 7, "A refreshing salad with romaine lettuce, croutons, Parmesan cheese, and a creamy Caesar dressing.", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRY_eHLujovQQKHoeGQ2ho_R73kjUG-tcme2kuFnrYYFsgPenARAOmeRHv4EtNN", "Caesar Salad", 7.0 },
                    { 8, "A flavorful salad with tomatoes, cucumbers, olives, feta cheese, red onions, and a vinaigrette dressing.", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcS7BGGe7zXLXiMk3iGCL3y_KYmn_R8ix7eUmMKciJLtFYXks3sQrqlQeCacNRmh", "Greek Salad", 8.0 },
                    { 9, "A simple yet elegant salad with sliced tomatoes, fresh mozzarella cheese, basil leaves, and a drizzle of olive oil.", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRqzkSO9s8p9QHaVspPV5DjYxJokiiCPeQBRm8tdPLKI_oR11VUU-sxLQg3wUcb", "Caprese Salad", 6.5 },
                    { 10, "A healthy and flavorful dish of grilled chicken breast, seasoned and cooked to perfection.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSgN-KUvxE4w71iUPs972XH_7Xx_x_6YuavBDsEo9aBlCNCVCj-4i6K2Rbr3ZHb", "Grilled Chicken", 12.0 },
                    { 11, "A nutritious dish featuring roasted salmon served with a variety of roasted vegetables.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSg7Lk_L0otNgiJvXq7DBc7eie38_8HENKA8mJcZKRwPJcD4hKsiL4EfgXWL0JF", "Salmon with Roasted Vegetables", 14.0 },
                    { 12, "A comforting and hearty stew made with beef, vegetables, and a rich broth.", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTQ48Ukd0OSZLbGDGuBe4p3ds32NZvRhYDKxgfBMzvglgO2OnnA9aF5xbM9Pj8J", "Beef Stew", 13.5 },
                    { 13, "A decadent chocolate cake, perfect for satisfying your sweet tooth.", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTEiGGqQ2hhECMjGf7l53cQd08LaXaBhzyVVzToUY6tGmnyz6V2FFok-qmPN25g", "Chocolate Cake", 5.0 },
                    { 14, "A creamy and delicious cheesecake, a classic dessert favorite.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvcp9lQnaRjUfNivxdDDCctlee0fb7euLGUMpnnEzGkIvuaWeZ8tGHMuwrkBxp", "Cheesecake", 5.5 },
                    { 15, "An Italian coffee-flavored dessert made with ladyfingers, mascarpone cheese, cocoa powder, and coffee.", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcR03GLSb-AGl6J-BRf37jAzisO6CPUCJohEMSv4lxmkQ2FXHRohhX2iohc6UFNu", "Tiramisu", 6.0 }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "tomato sauce" },
                    { 2, "mozzarella cheese" },
                    { 3, "pepperoni" },
                    { 4, "ham" },
                    { 5, "pineapple" },
                    { 6, "ground beef" },
                    { 7, "pasta" },
                    { 8, "basil" },
                    { 9, "olive oil" },
                    { 10, "garlic" },
                    { 11, "parmesan cheese" },
                    { 12, "chicken breast" },
                    { 13, "salmon fillet" },
                    { 14, "vegetables (mixed)" },
                    { 15, "beef" },
                    { 16, "potatoes" },
                    { 17, "carrots" },
                    { 18, "celery" },
                    { 19, "eggs" },
                    { 20, "cream cheese" },
                    { 21, "cocoa powder" },
                    { 22, "ladyfingers" },
                    { 23, "mascarpone cheese" },
                    { 24, "coffee" }
                });

            migrationBuilder.InsertData(
                table: "Dishngredients",
                columns: new[] { "DishId", "IngredientId" },
                values: new object[,]
                {
                    { 1, 8 },
                    { 1, 9 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 8 },
                    { 2, 9 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 8 },
                    { 3, 9 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 2 },
                    { 5, 7 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 6, 7 },
                    { 6, 9 },
                    { 6, 11 },
                    { 6, 20 },
                    { 7, 8 },
                    { 7, 11 },
                    { 7, 19 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 14 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 8 },
                    { 9, 9 },
                    { 10, 9 },
                    { 10, 12 },
                    { 10, 14 },
                    { 11, 9 },
                    { 11, 13 },
                    { 11, 14 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 15 },
                    { 12, 16 },
                    { 12, 17 },
                    { 12, 18 },
                    { 13, 19 },
                    { 13, 20 },
                    { 13, 21 },
                    { 14, 2 },
                    { 14, 19 },
                    { 14, 20 },
                    { 15, 19 },
                    { 15, 20 },
                    { 15, 21 },
                    { 15, 22 },
                    { 15, 23 },
                    { 15, 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dishngredients_IngredientId",
                table: "Dishngredients",
                column: "IngredientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishngredients");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
