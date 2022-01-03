using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models.ORM;

namespace WTechCoreSample.Controllers
{
    public class AdminUserController : Controller
    {
        WTechContext wTechContext;

        public AdminUserController()
        {
            wTechContext = new WTechContext();
        }

        //Bir veritabanı üzerinden Silme, ekleme, güncelleme(*) ve listeleme işlemlerine CRUD işlemleri denir.

        public IActionResult AdminUserList()
        {

            List<AdminUser> adminUsers = wTechContext.AdminUsers.Where(q => q.IsDeleted == false).ToList();


            return View(adminUsers);
        }

        public WTechContext GetWTechContext()
        {
            return wTechContext;
        }

        [HttpGet]
        public IActionResult AddAdminUser(WTechContext wTechContext)
        {
            List<AdminUser> adminUser = wTechContext.AdminUsers.ToList();
            return View(adminUser);
        }

        [HttpPost]
        public IActionResult AddAdminUser(AdminUser model)
        {

            wTechContext.AdminUsers.Add(model);
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


            AdminUser silinecekAdminUser = wTechContext.AdminUsers.FirstOrDefault(q => q.Id == id);


            silinecekAdminUser.IsDeleted = true;
            wTechContext.SaveChanges();


            return RedirectToAction("PostList");
        }


        [HttpGet]
        public IActionResult UpdateAdminUser(int id)
        {

            //Find primarykey e göre çalışır
            AdminUser adminUser = wTechContext.AdminUsers.Find(id);

            return View(adminUser);

        }

        [HttpPost]
        public IActionResult UpdateAdminUser(AdminUser adminUser)
        {
            //Öncelikle db den güncellenecek olan BlogPost u çekiyorum. Daha sonra dışarıdan gelen blogpost özellikleriyle eşleyip kaydediyorum
            AdminUser guncellenecekAdminUser = wTechContext.AdminUsers.Find(adminUser.Id);

            guncellenecekAdminUser.Name= adminUser.Name;
            guncellenecekAdminUser.SurName = adminUser.SurName;
            guncellenecekAdminUser.EMail = adminUser.EMail;
            guncellenecekAdminUser.Password = adminUser.Password;

            wTechContext.SaveChanges();

            return RedirectToAction("PostList");


        }
    }
}
