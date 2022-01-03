using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WTechCoreSample.Controllers
{
    public class CategoryController : Controller
    {
      
        public IActionResult Index()
        {
            List<Category> categoryList = new List<Category>();

            Category category1 = new Category();
            category1.CategoryName = "Electronic";
            category1.Description = "Electronic products";

            Category category2 = new Category();
            category2.CategoryName = "Sport";
            category2.Description = "Sport products";

            Category category3 = new Category();
            category3.CategoryName = "Kitchen";
            category3.Description = "Kitchen products";

            categoryList.Add(category1);
            categoryList.Add(category2);
            categoryList.Add(category3);


            return View(categoryList);
        }
    }
}
