using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakeryProject.Models.Buns;
using BakeryProject.Models.Buns.Elements;
using BakeryProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Bun b1 = new Loaf("Батон 1", 90, DateTime.Now.AddHours(-4), 10, 1);
            Bun b2 = new Baguette("Багет 1", 90, DateTime.Now.AddHours(-4), 10, 1);
            Bun b3 = new Croissant("Круассан 1", 90, DateTime.Now.AddHours(-4), 10, 1);
            Bun b4 = new SourCream("Сметанник 1", 90, DateTime.Now.AddHours(-4), 10, 1);
            Bun b5 = new Pretzel("Крендель 1", 90, DateTime.Now.AddHours(-4), 10, 1);

            List<BunViewModel> BunsList = new List<BunViewModel>();
            BunsList.Add( new BunViewModel
            {
                Number = 1,
                Name = b1.Name,
                Price = b1.Price,
                PriceCurrent = b1.GetPriceCurrent(),
                PriceForecast = 0,
                Period = 0
            });
            BunsList.Add(new BunViewModel
            {
                Number = 2,
                Name = b2.Name,
                Price = b2.Price,
                PriceCurrent = b2.GetPriceCurrent(),
                PriceForecast = 0,
                Period = 0
            });
            BunsList.Add(new BunViewModel
            {
                Number = 3,
                Name = b3.Name,
                Price = b3.Price,
                PriceCurrent = b3.GetPriceCurrent(),
                PriceForecast = 0,
                Period = 0
            });
            BunsList.Add(new BunViewModel
            {
                Number = 4,
                Name = b4.Name,
                Price = b4.Price,
                PriceCurrent = b4.GetPriceCurrent(),
                PriceForecast = 0,
                Period = 0
            });
            BunsList.Add(new BunViewModel
            {
                Number = 5,
                Name = b5.Name,
                Price = b5.Price,
                PriceCurrent = b5.GetPriceCurrent(),
                PriceForecast = 0,
                Period = 0
            });
            return View(BunsList);
        }

        
        public IActionResult Error()
        {
            return View();
        }
    }
}
