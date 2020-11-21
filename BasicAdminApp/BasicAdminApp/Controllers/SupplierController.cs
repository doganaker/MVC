using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicAdminApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BasicAdminApp.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            var suppliermodel = SupplierManager.GetSuppliers();
            return View(suppliermodel);
        }

        public IActionResult Detail(int id)
        {
            var detailmodel = SupplierManager.GetSupplier(id);
            return View(detailmodel);
        }
    }
}
