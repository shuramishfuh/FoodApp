using System.Collections.Generic;
using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface IOperatingTime
    {
        int Id { get; set; }
        Restorant Restorant { get; set; }
        ICollection<Day> Day { get; set; }
    }
}