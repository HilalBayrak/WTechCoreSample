using System;
using System.ComponentModel.DataAnnotations;

namespace WTechCoreSample.Models.VM
{
    public class WebUserVM
    {
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        public string SurName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        [Required(ErrorMessage = "EMail is required!")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Address is required!")]
        public string Address { get; set; }
        public int Id { get; internal set; }
    }
}
