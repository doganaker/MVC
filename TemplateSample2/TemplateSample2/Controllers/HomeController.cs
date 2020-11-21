using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TemplateSample2.Models;

namespace TemplateSample2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            PageVM page = new PageVM();

            string title1 = "about our cafe";

            page.Title = title1.ToUpper();

            page.Description = "Founded in 1987 by the Hernandez brothers, our establishment has been serving up rich coffee sourced from artisan farmers in various regions of South and Central America. We are dedicated to travelling the world, finding the best coffee, and bringing back to you here in our cafe.";

            return View(page);
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }
    }
}
