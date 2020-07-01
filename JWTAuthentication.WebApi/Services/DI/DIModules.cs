using System;
using Autofac;
using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Services.DI
{
    public class DIModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<Contact>().AsImplementedInterfaces();
            builder.RegisterType<CreditCard>().AsImplementedInterfaces();
            builder.RegisterType<Customer>().AsImplementedInterfaces();
            builder.RegisterType<Day>().AsImplementedInterfaces();
            builder.RegisterType<Item>().AsImplementedInterfaces();
            builder.RegisterType<OperatingTime>().AsImplementedInterfaces();
            builder.RegisterType<Order>().AsImplementedInterfaces();
            builder.RegisterType<PaymentDetails>().AsImplementedInterfaces();
            builder.RegisterType<Rating>().AsImplementedInterfaces();
            builder.RegisterType<Restorant>().AsImplementedInterfaces();
            builder.RegisterType<RestorantUser>().AsImplementedInterfaces();
            builder.RegisterType<SecondaryContacts>().AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(t => t.Name.EndsWith("Repo"))
                .AsImplementedInterfaces();
        }
    }
}
