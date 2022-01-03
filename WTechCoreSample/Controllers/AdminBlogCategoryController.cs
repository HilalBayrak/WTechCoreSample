using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models.ORM;
using WTechCoreSample.Models.VM;

namespace WTechCoreSample.Controllers
{
    public class AdminBlogCategoryController : Controller
    {

        WTechContext wTechContext;

        public AdminBlogCategoryController()
        {
            wTechContext = new WTechContext();
        }


        public IActionResult Index()
        {
            //List<BlogCategory> blogCategories = wTechContext.BlogCategories.ToList();

            //return View(blogCategories);

            //List<AdminBlogCategoryVM> model =
            //    wTechContext.
            //    BlogCategories.
            //    Select(x => new AdminBlogCategoryVM()
            //    {
            //        Name = x.Name.ToUpper()
            //    }).ToList();

            List<AdminBlogCategoryVM> model = new List<AdminBlogCategoryVM>();

            List<BlogCategory> blogCategories = wTechContext.BlogCategories.ToList();

            foreach (var item in blogCategories)
            {
                AdminBlogCategoryVM adminBlogCategoryVM = new AdminBlogCategoryVM();
                adminBlogCategoryVM.Name = item.Name;

                model.Add(adminBlogCategoryVM);
            }


            return View(model);

        }


        public IActionResult AddBlogCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlogCategory(AdminBlogCategoryVM model)
        {

            if (ModelState.IsValid)
            {
                //DB işlemlerini yap

                BlogCategory blogCategory = new BlogCategory();
                blogCategory.Name = model.Name;

                wTechContext.Add(blogCategory);
                wTechContext.SaveChanges();

            }

            return View();
        }
    }
}
