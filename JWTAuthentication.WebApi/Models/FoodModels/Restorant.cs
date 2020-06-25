using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class Restorant
    {
        public Restorant()
        {
            Item = new HashSet<Item>();
            RatingNavigation = new HashSet<Rating>();
            Users = new HashSet<RestorantUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int OperatingTimeId { get; set; }
        public Geometry Location { get; set; }
        public double Rating { get; set; }
        public int ContactId { get; set; }
        public int PaymentDetailsId { get; set; }

        public  Contact Contact { get; set; }
        public  OperatingTime OperatingTime { get; set; }
        public  PaymentDetails PaymentDetails { get; set; }
        public  ICollection<Item> Item { get; set; }
        public  ICollection<Rating> RatingNavigation { get; set; }
        public  ICollection<RestorantUser> Users { get; set; }
    }
}
