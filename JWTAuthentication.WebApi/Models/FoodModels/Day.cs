using System;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class Day
    {
        public int Id { get; set; }
        public string WeekDay { get; set; }
        public TimeSpan StartingHour { get; set; }
        public TimeSpan ClosingHour { get; set; }
        public int OperatingTimeId { get; set; }

        public  OperatingTime OperatingTime { get; set; }
    }
}
