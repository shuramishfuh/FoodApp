using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Contexts.Configuration
{
    internal class ContactConfiguration :IEntityTypeConfiguration<Contact>
    {

        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            
                builder.HasIndex(e => e.SecondaryContacts)
                    .HasName("Contact_secondaryContact")
                    .IsUnique();

                builder.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                builder.HasOne(d => d.SecondaryContactsNavigation)
                    .WithOne(p => p.Contact)
                    .HasForeignKey<Contact>(d => d.SecondaryContacts)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Contact__Seconda__656C112C");
         
        }
    }
}


