using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Configuration
{
    public class OrderConfiguration:IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
           
                builder.Property(e => e.Id).HasColumnName("ID");

                builder.Property(e => e.CustomerId).HasColumnName("CustomerID");

                builder.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(20);

                builder.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Order_Customer");
            

        }
    }
}
