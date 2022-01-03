using System;
using System.Collections.Generic;
using WTechCoreSample.Models;

namespace WTechCoreSample.Service
{
    public class ProductManager
    {

        public static List<Product> GetProducts()
        {
            Category category = new Category();
            category.CategoryName = "Phone";

            Product product1 = new Product();
            product1.Name = "IPhone";
            product1.UnitPrice = 5000;
            product1.Description = "Apple ürünü";
            product1.UnitsInStock = 44;
            product1.category = category;
            product1.StockStatus = true;


            Product product2 = new Product();
            product2.Name = "Samsung";
            product2.UnitPrice = 4000;
            product2.Description = "Kore ürünü";
            product2.UnitsInStock = 34;
            product2.category = category;
            product2.StockStatus = false;

            List<Product> products = new List<Product>();

            products.Add(product1);
            products.Add(product2);

            return products;

        }
    }
}
