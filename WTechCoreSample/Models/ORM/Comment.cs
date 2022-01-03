using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WTechCoreSample.Models.ORM
{
    public class Comment : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public bool IsActive { get; set; } = false;

        public int WebUserId { get; set; }

        public int BlogPostId { get; set; }

        [ForeignKey("BlogPostId")]
        public BlogPost BlogPost { get; set; }

        [ForeignKey("WebUserId")]
        public WebUser WebUser { get; set; }
    }
}
