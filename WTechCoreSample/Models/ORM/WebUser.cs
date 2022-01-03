using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WTechCoreSample.Models.ORM
{
    public class WebUser : BaseEntity
    {


        [MaxLength(20)] //nvarchar(20)
        public string Name { get; set; }

        public string SurName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
                
        public string EMail { get; set; }

        [Required] // notNull
        public string Address { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public  Role Role { get; set; }
    }
}
