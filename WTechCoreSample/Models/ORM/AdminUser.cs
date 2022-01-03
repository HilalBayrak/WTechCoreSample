using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WTechCoreSample.Models.ORM
{
    public class AdminUser : BaseEntity
    {

        public string Name { get; set; }

        public string SurName { get; set; }


        public string EMail { get; set; }

        public int Password { get; set; }

        public DateTime LastLoginDate { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
       


    }
}

