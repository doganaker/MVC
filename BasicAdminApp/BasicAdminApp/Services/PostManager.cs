using BasicAdminApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAdminApp.Services
{
    public class PostManager
    {
        static string data = File.ReadAllText(@"C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\wwwroot\files\posts.json");

        static List<PostVM> posts = JsonConvert.DeserializeObject<List<PostVM>>(data);

        public static List<PostVM> GetPosts()
        {
            return posts;
        }
    }
}
