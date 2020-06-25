using System;
using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface IRestorantUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string Role { get; set; }
        string PhoneNumber { get; set; }
        int RestorantId { get; set; }
        string Gender { get; set; }
        DateTime Dob { get; set; }
        Restorant Restorant { get; set; }
    }
}