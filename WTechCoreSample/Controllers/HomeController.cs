using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models.ORM;
using System.Linq;
using WTechCoreSample.Models.VM;

namespace WTechCoreSample.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            WTechContext wTechContext = new WTechContext();
            List<BlogPost> blogPosts = wTechContext.BlogPosts
                .OrderByDescending(x => x.AddDate).Where(q => q.IsDeleted == false).Take(3).ToList();
            return View(blogPosts);
        }


        public ActionResult Detail(int id)
        {
            WTechContext wTechContext = new WTechContext();

            BlogPost blogPost = wTechContext.BlogPosts.FirstOrDefault(q => q.Id == id);


            BlogDetailVM blogDetailVM = new BlogDetailVM();
            blogDetailVM.Id = blogPost.Id;
            blogDetailVM.Title = blogPost.Title;
            blogDetailVM.Content = blogPost.Content;
            blogDetailVM.AddDate = blogPost.AddDate;


            List<Comment> blogPostComments = wTechContext.Comments.Where(q => q.BlogPostId == id).ToList();

            blogDetailVM.Comments = blogPostComments;

            return View(blogDetailVM);


        }

    }
}
