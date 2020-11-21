using BilgeTicaret.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeTicaret.Bussiness.Manager
{
    public class ProductManager
    {
        static string data = File.ReadAllText(@"C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BilgeTicaret\BilgeTicaret.Bussiness\Files\products.json");
        static List<ProductsVM> products = JsonConvert.DeserializeObject<List<ProductsVM>>(data);


        public static void GetAllProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.AddDate);
                Console.WriteLine(item.IsActive);
                Console.WriteLine("***************************************");
            }
            Console.ReadLine();
        }

        //Dışarıdan 2 adet price alan ve bu price aralığındaki productları döndüren metot
        public static List<ProductsVM> GetProductsByPrice(decimal x, decimal y)
        {
            var result = products.Where(q => q.Price > x && q.Price < y).ToList();

            return result;
        }

        //Dışarıdan 2 adet price alan ve bu price aralığındaki IsActive true olan  productları döndüren metot
        public static List<ProductsVM> GetAvailableProducts(decimal x, decimal y)
        {
            var result = products.Where(q => q.Price > x && q.Price < y && q.IsActive == true).ToList();

            return result;
        }

        //Dışarıdan datetime alan aldığı datetime dan büyük productları veren metot
        public static List<ProductsVM> GetProductsByDate(DateTime dt)
        {
            var result = products.Where(q => q.AddDate > dt).ToList();

            return result;
        }

        //Dışarıdan name alan ve bu name e eşit product veren metot ( tek product )
        public static void GetOneProduct(string name)
        {
            var result = products.FirstOrDefault(q => q.Name == name);
        }

        //Dışarıdan name alan ve bu name productname lerde geçen ürünler? ( contains )
        public static List<ProductsVM> GetProductsByName(string name)
        {
            var result = products.Where(q => q.Name.Contains(name)).ToList();

            return result;
        }

        //First ve firstordefault metotları arasındaki fark nedir?
        public static void GetOne(string name)
        {
            var result = products.First(q => q.Name == name);
        }
    }
}
