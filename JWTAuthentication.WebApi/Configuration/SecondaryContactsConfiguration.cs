using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Configuration
{
    public class SecondaryContactsConfiguration:IEntityTypeConfiguration<SecondaryContacts>
    {
        public void Configure(EntityTypeBuilder<SecondaryContacts> builder)
        {
            builder.Property(e => e.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();
        }
    }
}
