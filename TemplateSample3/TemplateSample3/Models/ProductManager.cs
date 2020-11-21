using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;                              
using System.Threading.Tasks;

namespace TemplateSample3.Models
{
    public class ProductManager
    {
        static string data = File.ReadAllText(@"C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\TemplateSample3\TemplateSample3\wwwroot\json\products.json");

        static List<Product> products = JsonConvert.DeserializeObject<List<Product>>(data);

        public static List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
