using eShopSolution.Data.Configurations;
using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace eShopSolution.Data.EF
{

    public class EshopConnectDB : DbContext
    {
        public EshopConnectDB( DbContextOptions options) : base(options)
        {
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigCaterogys());
            modelBuilder.ApplyConfiguration(new AppConfigProductInCaterogies());
            modelBuilder.ApplyConfiguration(new AppConfigAppRole());
            modelBuilder.ApplyConfiguration(new AppConfigAppUser());
            modelBuilder.ApplyConfiguration(new AppConfigCart());
            modelBuilder.ApplyConfiguration(new AppConfigCategoryTranslations());
            modelBuilder.ApplyConfiguration(new AppConfigContact());
            modelBuilder.ApplyConfiguration(new AppConfigLanguage());
            modelBuilder.ApplyConfiguration(new AppConfigOrderDetails());
            modelBuilder.ApplyConfiguration(new AppConfigOrders());
            modelBuilder.ApplyConfiguration(new AppConfigProductImages());
            modelBuilder.ApplyConfiguration(new AppConfigProducts());
            modelBuilder.ApplyConfiguration(new AppConfigProductTranslations());
            modelBuilder.ApplyConfiguration(new AppConfigPromotion());
            modelBuilder.ApplyConfiguration(new AppConfigSlides());
            modelBuilder.ApplyConfiguration(new AppConfigTransaction());
            //   base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<AppConfig> AppConfigs { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<ProductInCaterogy> ProductInCategories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<ProductImages> ProductImages { get; set; }

        public DbSet<Slides> Slides { get; set; }


    }
}
