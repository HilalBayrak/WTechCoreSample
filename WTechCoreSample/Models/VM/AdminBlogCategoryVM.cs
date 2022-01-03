using System;
using System.ComponentModel.DataAnnotations;

namespace WTechCoreSample.Models.VM
{
    public class AdminBlogCategoryVM
    {
        [Required(ErrorMessage ="Name is required!")]
        [MaxLength(40)]
        public string Name { get; set; }
    }
}
