using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TemplateSample3.Models;

namespace TemplateSample3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = ProductManager.GetAllProducts();

            return View(products);
        }
    }
}
