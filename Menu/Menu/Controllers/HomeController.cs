using Menu.DataContext;
using Menu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Menu.Controllers
{
    public class HomeController : Controller
    {
        private readonly FoodFoolioContext foodFoolio;

        public HomeController(FoodFoolioContext foodFoolio)
        {
            this.foodFoolio = foodFoolio;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var dishes = from d in foodFoolio.Dishes
                       select d;
            if (!string.IsNullOrEmpty(searchString))
            {
                dishes=dishes.Where(d => d.Title.Contains(searchString));
                return View(await dishes.ToListAsync());

            }

            return View(await dishes.ToListAsync());
        }

     

        public async Task<IActionResult> Details(int? id)
        {
            var dish = await foodFoolio.Dishes.Include(di => di.dishngredients).ThenInclude(i => i.Ingredients).FirstOrDefaultAsync(x=>x.Id==id);
            if (dish == null)
            {
                return NotFound();
            }
            return View(dish);
        }

          }
}
