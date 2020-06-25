using System.Collections.Generic;
using JWTAuthentication.WebApi.Models.FoodModelsInterfaces;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class OperatingTime : IOperatingTime
    {
        public OperatingTime()
        {
            Day = new HashSet<Day>();
        }

        public int Id { get; set; }

        public  Restorant Restorant { get; set; }
        public  ICollection<Day> Day { get; set; }
    }
}
