using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicAdminApp.Models;
using BasicAdminApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BasicAdminApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var categorymodel = CategoryManager.GetCategories();
            return View(categorymodel);
        }

        public IActionResult Detail(int id)
        {
            CategoryVM detailmodel = CategoryManager.GetCategory(id);

            if(detailmodel != null)
            {
                return View(detailmodel);

            }
            else
            {
                return View(new CategoryVM());
            }
        }
    }
}
