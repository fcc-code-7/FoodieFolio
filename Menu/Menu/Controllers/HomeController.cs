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

        public async Task<IActionResult> Index()
        {
            var dish = await foodFoolio.Dishes.ToListAsync();
            return View(dish);
        }

          }
}
