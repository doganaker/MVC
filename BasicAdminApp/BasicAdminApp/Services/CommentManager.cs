using BasicAdminApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAdminApp.Services
{
    public class CommentManager
    {
        static string data = File.ReadAllText(@"C:\Users\dogan\OneDrive\Masaüstü\BilgeAdam Boost (Doğan)\BasicAdminApp\BasicAdminApp\wwwroot\files\comments.json");

        static List<CommentVM> comments = JsonConvert.DeserializeObject<List<CommentVM>>(data);

        public static List<CommentVM> GetComment(int id)
        {
            List<CommentVM> comment = comments.Where(q => q.postId == id).ToList();
            return comment;
        }

    }
}
