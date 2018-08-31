using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderPOS.Models;

namespace BartenderPOS.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("HomePage");
        }
        [HttpGet]
        public ViewResult DrinkMenu()
        {
            return View();
        }
        [HttpPost]
        public ViewResult DrinkMenu(DrinkOrder drink)
        {
            return View("OrderQueue", drink);
        }
        //now put the responses to the order placed here
       
        public ViewResult OrderQueue(DrinkOrder drink) {
            //orderedDrinks
            return View("OrderQueue", drink);
        }//end completedOrder
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
