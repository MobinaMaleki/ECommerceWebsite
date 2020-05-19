using System;
using System.Collections.Generic;
using System.Text;
using Eshop.Data.db;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static bool _created = false;

        public ApplicationDbContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=.; Initial Catalog=Eshop; Persist Security Info=True;User ID=sa;Password=123; Connect Timeout=2400; Application Name=eshop");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Articles> Tbl_Article { get; set; }
        public DbSet<Category> Tbl_Category { get; set; }
        public DbSet<Comments> Tbl_Comments { get; set; }
        public DbSet<Gallery> Tbl_Gallery { get; set; }
        public DbSet<Invoce> Tbl_Invoce { get; set; }
        public DbSet<OtherServer> Tbl_OtherServer { get; set; }
        public DbSet<ProductColors> Tbl_ProductColors { get; set; }
        public DbSet<Products> Tbl_Products { get; set; }
        public DbSet<Settings> Tbl_Settings { get; set; }
        public DbSet<ShoppingCart> Tbl_ShoppingCart { get; set; }
        public DbSet<TechnicalsDetails> Tbl_TechnicalsDetails { get; set; }
        public DbSet<UserPages> Tbl_UserPages { get; set; }
        public DbSet<ViewImage> Tbl_ViewImage { get; set; }
        public DbSet<Weight> Tbl_Weight { get; set; }
     public DbSet<PageName> Tbl_PageName { get; set; }
     public DbSet<Messages> Tbl_Message { get; set; }

    }
}
