using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Configuration
{
    public class OperatingTimConfiguration:IEntityTypeConfiguration<OperatingTime>
    {
        public void Configure(EntityTypeBuilder<OperatingTime> builder)
        {
           
                builder.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
           
        }
    }
}
