using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
   public class AppConfigProductInCaterogies : IEntityTypeConfiguration<ProductInCaterogy>
    {
        public void Configure(EntityTypeBuilder<ProductInCaterogy> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(t => new { t.categoryId, t.productId });
            builder.HasOne(pc => pc.product).WithMany(pc => pc.productInCaterogy)
                .HasForeignKey(pc => pc.productId);
            builder.HasOne(pc => pc.category).WithMany(pc => pc.productInCaterogy)
                .HasForeignKey(pc => pc.categoryId);
        }
    }
}
