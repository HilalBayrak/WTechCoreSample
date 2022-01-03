using System;
namespace WTechCoreSample.Models.ORM
{
    public class BlogPost : BaseEntity
    {

        public string Title { get; set; }

        public string Content { get; set; }

        public int BlogCategoryId { get; set; }


    }
}
