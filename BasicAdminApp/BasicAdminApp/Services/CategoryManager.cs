using BasicAdminApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAdminApp.Services
{
    public class CategoryManager
    {
        static string data = File.ReadAllText(@"C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\wwwroot\files\categories.json");

        static List<CategoryVM> categories = JsonConvert.DeserializeObject<List<CategoryVM>>(data);

        public static List<CategoryVM> GetCategories()
        {
            return categories;
        }

        public static CategoryVM GetCategory(int id)
        {
            CategoryVM category = categories.FirstOrDefault(q => q.id == id);
            return category;
        }
    }
}
