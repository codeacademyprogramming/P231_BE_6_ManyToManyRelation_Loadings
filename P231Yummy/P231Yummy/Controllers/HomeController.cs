using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P231Yummy.DAL;
using P231Yummy.ViewModels;
using System.Diagnostics;

namespace P231Yummy.Controllers
{
    public class HomeController : Controller
    {
        private readonly YummyDbContext _context;

        public HomeController(YummyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            //var query = _context.Meals.AsQueryable();

            //query = query.Include(x => x.Category);
            //query = query.Include(x => x.MealIngredients).ThenInclude(x=>x.Ingredient);
            //query = query.OrderBy(x => x.Price);

            //var data = query.Where(x => x.Price > 10).ToList();


            var data = _context.Meals
                .Include(x => x.Category)
                .Include(x => x.MealIngredients)
                .ThenInclude(x => x.Ingredient)
                .Where(x => x.Price > 10).ToList();



            //var meal = _context.Meals.First(x=>x.Price>10);
            //meal = _context.Meals.FirstOrDefault(x => x.Price > 10);
            //meal = _context.Meals.Single(x => x.Price > 10);
            //meal = _context.Meals.SingleOrDefault(x => x.Price > 10);

            //meal = _context.Meals.Find(2);


            return View();
        }

    }
}