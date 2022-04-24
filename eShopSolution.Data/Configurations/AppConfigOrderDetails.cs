using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class AppConfigOrderDetails : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => new{ x.ProductId, x.OrderId});
            builder.HasOne(x => x.Order).WithMany(pc => pc.OrderDetails).HasForeignKey(pc => pc.OrderId);
            builder.HasOne(x => x.Product).WithMany(pc => pc.OrderDetails).HasForeignKey(pc => pc.ProductId);
        }
    }
}
