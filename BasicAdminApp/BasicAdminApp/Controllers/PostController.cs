using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicAdminApp.Models;
using BasicAdminApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BasicAdminApp.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            var model = PostManager.GetPosts();
            return View(model);
        }

        public IActionResult Comment(int id)
        {
            List<CommentVM> commentmodel = CommentManager.GetComment(id);
            return View(commentmodel);
        }
    }
}
