using System;
using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface IDay
    {
        int Id { get; set; }
        string WeekDay { get; set; }
        TimeSpan StartingHour { get; set; }
        TimeSpan ClosingHour { get; set; }
        int OperatingTimeId { get; set; }
        OperatingTime OperatingTime { get; set; }
    }
}