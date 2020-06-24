using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JWTAuthentication.WebApi.Configuration
{
    public class DayConfiguration:IEntityTypeConfiguration<Day>
    {
        public void Configure(EntityTypeBuilder<Day> builder)
        {
                builder.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                builder.Property(e => e.ClosingHour).HasColumnType("time(0)");

                builder.Property(e => e.OperatingTimeId).HasColumnName("OperatingTimeID");

                builder.Property(e => e.StartingHour).HasColumnType("time(0)");

                builder.Property(e => e.WeekDay)
                    .IsRequired()
                    .HasMaxLength(10);

                builder.HasOne(d => d.OperatingTime)
                    .WithMany(p => p.Day)
                    .HasForeignKey(d => d.OperatingTimeId)
                    .HasConstraintName("FK_Day_OperatingTime");
            
        }
    }
}
