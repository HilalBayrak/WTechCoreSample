using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WTechCoreSample.Models.ORM
{
    public class WTechContext : DbContext
    {




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HB98; Database=WTechDB; Trusted_connection=true");


            //optionsBuilder.UseSqlServer(@"Server=.; Database=hayriDb; Trusted_connection=true");


            // Add-migration DbInit
            // Update-database
            // add-migration "...TableCreated
            // add-migration "CommentTableAddIsActiveColumn"
            // add-migration "CommentTableUpdated"
        }

        public DbSet<WebUser> WebUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
       
    }
}
