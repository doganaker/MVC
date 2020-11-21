using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicAdminApp.Models;
using BasicAdminApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BasicAdminApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            var ordermodel = OrderManager.GetOrders();
            return View(ordermodel);
        }

        public IActionResult Detail(int id)
        {
            OrderVM detailmodel = OrderManager.GetOrder(id);
            return View(detailmodel);
        }
    }
}
