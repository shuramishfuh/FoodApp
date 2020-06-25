using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Contexts.Configuration
{
    public class RestorantUserConfiguration:IEntityTypeConfiguration<RestorantUser>
    {
        public void Configure(EntityTypeBuilder<RestorantUser> builder)
        {

            builder.Property(e => e.Id).HasColumnName("ID");

                builder.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                builder.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                builder.Property(e => e.RestorantId).HasColumnName("RestorantID");

                builder.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(10);

                builder.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.HasOne(d => d.Restorant)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RestorantId)
                    .HasConstraintName("FK_Users_Restorant");
           
        }
    }
}
