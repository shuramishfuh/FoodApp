using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Configuration
{
    public class ItemConfiguration:IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            
                builder.Property(e => e.Id).HasColumnName("ID");

                builder.Property(e => e.Description).IsRequired();

                builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.OrderId).HasColumnName("OrderID");

                builder.Property(e => e.Picture).IsRequired();

                builder.Property(e => e.RestorantId).HasColumnName("RestorantID");

                builder.HasOne(d => d.Order)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Item_Order");

                builder.HasOne(d => d.Restorant)
                    .WithMany(p => p.Item)
                    .HasPrincipalKey(p => p.PaymentDetailsId)
                    .HasForeignKey(d => d.RestorantId)
                    .HasConstraintName("FK_Item_Restorant");
          
        }
    }
}
