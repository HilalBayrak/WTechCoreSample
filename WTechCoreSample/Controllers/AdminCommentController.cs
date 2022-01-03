using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models.ORM;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WTechCoreSample.Controllers
{
    public class AdminCommentController : Controller
    {

        WTechContext wTechContext;

        public AdminCommentController()
        {
            wTechContext = new WTechContext();
        }
       

        public IActionResult Index(int id)
        {
            List<Comment> comments = wTechContext.Comments.Where(q => q.BlogPostId == id).ToList();


            return View(comments);
        }


        public IActionResult CommentIsActiveChange(int id)
        {
            Comment comment = wTechContext.Comments.Find(id);

            comment.IsActive = !comment.IsActive;

            wTechContext.SaveChanges();

            return RedirectToAction("Index", "AdminComment", new { id = comment.BlogPostId });
        }
    }
}
