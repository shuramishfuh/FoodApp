using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Configuration
{
    public class CustomerConfiguration:IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            
                builder.Property(e => e.Id).HasColumnName("ID");

                builder.Property(e => e.CurrentLocatiion).IsRequired();

                builder.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                builder.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                builder.Property(e => e.HomeLocation).IsRequired();

                builder.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                builder.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            
        }
    }
}
