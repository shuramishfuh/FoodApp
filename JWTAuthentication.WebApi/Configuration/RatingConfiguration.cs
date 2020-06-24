using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Configuration
{
    public class RatingConfiguration:IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            
            
                builder.Property(e => e.Id).HasColumnName("ID");

                builder.Property(e => e.CustomerId).HasColumnName("CustomerID");

                builder.Property(e => e.ResturantId).HasColumnName("ResturantID");

                builder.HasOne(d => d.Customer)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rating_Customer");

                builder.HasOne(d => d.Resturant)
                    .WithMany(p => p.RatingNavigation)
                    .HasForeignKey(d => d.ResturantId)
                    .HasConstraintName("FK_Rating_Restorant");
            
        }
    }
}
