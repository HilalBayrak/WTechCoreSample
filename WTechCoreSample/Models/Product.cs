using System;
namespace WTechCoreSample.Models
{
    public class Product
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public bool StockStatus { get; set; }

        public Category category { get; set; }
    }
}
