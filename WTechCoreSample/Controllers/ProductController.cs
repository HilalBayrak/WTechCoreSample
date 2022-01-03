using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models;
using WTechCoreSample.Service;


namespace WTechCoreSample.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            List<Product> products = ProductManager.GetProducts();
            return View(products);
        }
    }
}
