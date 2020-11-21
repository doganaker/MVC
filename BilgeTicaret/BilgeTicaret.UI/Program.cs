using BilgeTicaret.Bussiness.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeTicaret.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager.GetAllProducts();

            //ProductManager.GetProductsByPrice(1005, 2000);

            //ProductManager.GetAvailableProducts(1005, 2000);

            //DateTime dt = new DateTime(2018, 1, 1);

            //ProductManager.GetProductsByDate(dt);

            //ProductManager.GetOneProduct("Eu LLP");

            //ProductManager.GetProductsByName("E");

            ProductManager.GetOne("Eu LLP");
        }
    }
}
