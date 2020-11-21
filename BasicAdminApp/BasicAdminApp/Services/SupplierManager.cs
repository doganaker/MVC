using BasicAdminApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAdminApp.Services
{
    public class SupplierManager
    {
        static string data = File.ReadAllText(@"C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\wwwroot\files\suppliers.json");

        static List<SupplierVM> suppliers = JsonConvert.DeserializeObject<List<SupplierVM>>(data);

        public static List<SupplierVM> GetSuppliers()
        {
            return suppliers;
        }

        public static SupplierVM GetSupplier(int id)
        {
            SupplierVM supplier = suppliers.FirstOrDefault(q => q.id == id);
            return supplier;
        }
    }
}
