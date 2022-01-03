using System;
using System.ComponentModel.DataAnnotations;

namespace WTechCoreSample.Models.VM
{
    public class CommentVM
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public int BlogPostId { get; set; }


    }
}
