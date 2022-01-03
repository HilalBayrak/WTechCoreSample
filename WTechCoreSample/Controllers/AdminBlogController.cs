using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models.ORM;

namespace WTechCoreSample.Controllers
{
    public class AdminBlogController : Controller
    {

        WTechContext wTechContext;

        public AdminBlogController()
        {
            wTechContext = new WTechContext();
        }

        //Bir veritabanı üzerinden Silme, ekleme, güncelleme(*) ve listeleme işlemlerine CRUD işlemleri denir.

        public IActionResult PostList()
        {

            List<BlogPost> blogPosts = wTechContext.BlogPosts.Where(q => q.IsDeleted == false).ToList();


            return View(blogPosts);
        }

        [HttpGet]
        public IActionResult AddPost()
        {
            List<BlogCategory> blogCategories = wTechContext.BlogCategories.ToList();
            return View(blogCategories);
        }

        [HttpPost]
        public IActionResult AddPost(BlogPost model)
        {

            wTechContext.BlogPosts.Add(model);
            wTechContext.SaveChanges();

            return RedirectToAction("PostList");
        }


        //public IActionResult PostDelete(int id)
        //{
        //    //Silme işlemi


        //    BlogPost silinecekBlogPost = wTechContext.BlogPosts.FirstOrDefault(q => q.Id == id);


        //    wTechContext.BlogPosts.Remove(silinecekBlogPost);
        //    wTechContext.SaveChanges();


        //    return RedirectToAction("PostList", "Admin");
        //}



        public IActionResult PostDelete(int id)
        {
            //Silme işlemi


            BlogPost silinecekBlogPost = wTechContext.BlogPosts.FirstOrDefault(q => q.Id == id);


            silinecekBlogPost.IsDeleted = true;
            wTechContext.SaveChanges();


            return RedirectToAction("PostList");
        }


        [HttpGet]
        public IActionResult UpdateBlogPost(int id)
        {

            //Find primarykey e göre çalışır
            BlogPost blogPost = wTechContext.BlogPosts.Find(id);

            return View(blogPost);

        }

        [HttpPost]
        public IActionResult UpdateBlogPost(BlogPost blogPost)
        {
            //Öncelikle db den güncellenecek olan BlogPost u çekiyorum. Daha sonra dışarıdan gelen blogpost özellikleriyle eşleyip kaydediyorum
            BlogPost guncellenecekBlogPost = wTechContext.BlogPosts.Find(blogPost.Id);

            guncellenecekBlogPost.Title = blogPost.Title;
            guncellenecekBlogPost.Content = blogPost.Content;

            wTechContext.SaveChanges();

            return RedirectToAction("PostList");


        }
    }
}
