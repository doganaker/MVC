using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TemplateSample.Models;

namespace TemplateSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<PostVm> posts = new List<PostVm>();
            PostVm post1 = new PostVm();
            post1.Title = "Title1";
            post1.Description = "Description 1";
            post1.User = "User1";
            post1.AddDate = "26 Sep, 2020";

            PostVm post2 = new PostVm();
            post2.Title = "Title2";
            post2.Description = "Description 2";
            post2.User = "User2";
            post2.AddDate = "28 Sep, 2020";

            PostVm post3 = new PostVm();
            post3.Title = "Title3";
            post3.Description = "Description 3";
            post3.User = "User3";
            post3.AddDate = "29 Sep, 2020";

            PostVm post4 = new PostVm();
            post4.Title = "Title4";
            post4.Description = "Description 4";
            post4.User = "User4";
            post4.AddDate = "30 Sep, 2020";

            posts.Add(post1);
            posts.Add(post2);
            posts.Add(post3);
            posts.Add(post4);


            return View(posts);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
