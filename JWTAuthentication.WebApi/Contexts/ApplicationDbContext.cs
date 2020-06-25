using JWTAuthentication.WebApi.Configuration;
using JWTAuthentication.WebApi.Models;
using JWTAuthentication.WebApi.Models.FoodModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthentication.WebApi.Contexts
{
    public sealed class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Day> Day { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<OperatingTime> OperatingTime { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Restorant> Restorant { get; set; }
        public DbSet<SecondaryContacts> SecondaryContacts { get; set; }
        public DbSet<RestorantUser> RestorantUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new CreditCardConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new DayConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new OperatingTimConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new RatingConfiguration());
            modelBuilder.ApplyConfiguration(new RestorantConfiguration());
            modelBuilder.ApplyConfiguration(new SecondaryContactsConfiguration());
            modelBuilder.ApplyConfiguration(new RestorantConfiguration());

        }
    }
    
}
