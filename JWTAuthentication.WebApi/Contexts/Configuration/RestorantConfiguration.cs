using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Contexts.Configuration
{
    public class RestorantConfiguration:IEntityTypeConfiguration<Restorant>
    {
        public void Configure(EntityTypeBuilder<Restorant> builder)
        {
            
                builder.HasIndex(e => e.ContactId)
                    .HasName("Restorant_Contact")
                    .IsUnique();

                builder.HasIndex(e => e.OperatingTimeId)
                    .HasName("Restorant_operatingTime")
                    .IsUnique();

                builder.HasIndex(e => e.PaymentDetailsId)
                    .HasName("Restorant_PaymentdDetails")
                    .IsUnique();

                builder.Property(e => e.Id).HasColumnName("ID");

                builder.Property(e => e.ContactId).HasColumnName("ContactID");

                builder.Property(e => e.Location).IsRequired();

                builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.OperatingTimeId).HasColumnName("OperatingTimeID");

                builder.Property(e => e.PaymentDetailsId).HasColumnName("PaymentDetailsID");

                builder.HasOne(d => d.Contact)
                    .WithOne(p => p.Restorant)
                    .HasForeignKey<Restorant>(d => d.ContactId)
                    .HasConstraintName("FK__Restorant__Conta__123EB7A3");

                builder.HasOne(d => d.OperatingTime)
                    .WithOne(p => p.Restorant)
                    .HasForeignKey<Restorant>(d => d.OperatingTimeId)
                    .HasConstraintName("FK__Restorant__Opera__114A936A");

                builder.HasOne(d => d.PaymentDetails)
                    .WithOne(p => p.Restorant)
                    .HasForeignKey<Restorant>(d => d.PaymentDetailsId)
                    .HasConstraintName("FK__Restorant__Payme__1332DBDC");
            
        }
    }
}
