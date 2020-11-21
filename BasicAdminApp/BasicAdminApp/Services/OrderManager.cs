using BasicAdminApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAdminApp.Services
{
    public class OrderManager
    {
        static string data = File.ReadAllText(@"C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\wwwroot\files\orders.json");
        
        static List<OrderVM> orders = JsonConvert.DeserializeObject<List<OrderVM>>(data);

        public static List<OrderVM> GetOrders()
        {
            return orders;
        }

        public static OrderVM GetOrder(int id)
        {
            OrderVM order = orders.FirstOrDefault(q => q.id == id);
            return order;
        }

    }
}
