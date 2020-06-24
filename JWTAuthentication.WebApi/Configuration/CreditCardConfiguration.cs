using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Configuration
{
    public class CreditCardConfiguration :IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
           
                builder.Property(e => e.Id).HasColumnName("ID");
           

        }
    }
}
