using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models.ORM;
using WTechCoreSample.Models.VM;

namespace WTechCoreSample.Controllers
{
    public class CommentController : Controller
    {
        WTechContext wTechContext;

        public CommentController()
        {
            wTechContext = new WTechContext();
        }

        [HttpPost]
        public IActionResult AddComment(CommentVM model)
        {
            if (ModelState.IsValid)
            {
                Comment comment = new Comment();

                comment.Title = model.Title;
                comment.Content = model.Content;
                comment.WebUserId = 1;
                comment.BlogPostId = model.BlogPostId;

                wTechContext.Comments.Add(comment);
                wTechContext.SaveChanges();


            }

            return RedirectToAction("Index", "Home");


        }
    }
}
