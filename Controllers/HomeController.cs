using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AS_CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace AS_CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllDishes = _context.Dishes.ToList().OrderByDescending(a => a.UpdatedAT);
            return View();
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            
            return View();
        }

        [HttpGet("{DishID}")]
        public IActionResult OneDish(int DishID)
        {
            ViewBag.OneDish = _context.Dishes.FirstOrDefault(b => b.DishID == DishID);
            return View();
        }

        //Edit Dish
        [HttpGet("Edit/{DishID}")]
        public IActionResult Edit(int DishID)
        {
            ViewBag.OneDish = _context.Dishes.FirstOrDefault(f => f.DishID == DishID);

            return View();
        }

        [HttpPost("UpdateDish/{DishID}")]
        public IActionResult Update(Dish upDish, int DishID)
        {
            if(ModelState.IsValid)
            {
                Dish oldDish = _context.Dishes.FirstOrDefault(g => g.DishID == DishID);
                oldDish.Name = upDish.Name;
                oldDish.ChefName = upDish.ChefName;
                oldDish.Calories = upDish.Calories;
                oldDish.Tastiness = upDish.Tastiness;
                oldDish.Description = upDish.Description;
                oldDish.UpdatedAT = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OneDish = _context.Dishes.FirstOrDefault(f => f.DishID == DishID);
            return View("Edit", upDish);
        }



        [HttpPost("postmethod")]
        public IActionResult postmethod(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }



    }
}
