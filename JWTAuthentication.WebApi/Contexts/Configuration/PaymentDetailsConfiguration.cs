using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Contexts.Configuration
{
    public class PaymentDetailsConfiguration:IEntityTypeConfiguration<PaymentDetails>
    {
        public void Configure(EntityTypeBuilder<PaymentDetails> builder)
        {
          
                builder.HasIndex(e => e.CreditCard)
                    .HasName("Payment_CreditCard")
                    .IsUnique();

                builder.Property(e => e.Id).HasColumnName("ID");

                builder.HasOne(d => d.CreditCardNavigation)
                    .WithOne(p => p.PaymentDetails)
                    .HasForeignKey<PaymentDetails>(d => d.CreditCard)
                    .HasConstraintName("FK__PaymentDe__Credi__38996AB5");
            
        }
    }
}
