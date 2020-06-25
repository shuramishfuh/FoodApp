﻿using JWTAuthentication.WebApi.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthentication.WebApi.Models.Auth;
using JWTAuthentication.WebApi.Models.Constants;

namespace JWTAuthentication.WebApi.Contexts
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedEssentialsAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Authorization.Roles.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Authorization.Roles.Root.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Authorization.Roles.User.ToString()));

            //Seed Default User
            var defaultUser = new ApplicationUser { UserName = Authorization.DefaultUsername, Email = Authorization.DefaultEmail, EmailConfirmed = true, PhoneNumberConfirmed = true };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, Authorization.DefaultPassword);
                await userManager.AddToRoleAsync(defaultUser, Authorization.Roles.Root.ToString());
            }
        }
    }
}
