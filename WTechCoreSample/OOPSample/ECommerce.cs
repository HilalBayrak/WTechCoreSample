using System;
namespace WTechCoreSample.OOPSample
{
    public class ECommerce
    {

        public ISort SortEntity()
        {
           
            Home home = new Home();

            return home;
        }


       
    }


    public class Order
    {
        public string OrderName { get; set; }
    }


    public class Home : ISort
    {
        public string CompanyName { get; set; }
        public int SortNumber { get; set; }

    }

    public class Car : ISort
    {
        public string Name { get; set; }
        public int SortNumber { get; set; }
    }

    public interface ISort
    {
         int SortNumber { get; set; }
    }
    

}
