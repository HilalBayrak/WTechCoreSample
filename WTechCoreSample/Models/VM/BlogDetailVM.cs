using System;
using System.Collections.Generic;
using WTechCoreSample.Models.ORM;

namespace WTechCoreSample.Models.VM
{
    public class BlogDetailVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime AddDate { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
