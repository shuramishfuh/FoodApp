using System.Collections.Generic;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class OperatingTime
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
