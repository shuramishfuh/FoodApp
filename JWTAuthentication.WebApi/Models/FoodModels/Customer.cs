using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public   class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
            Rating = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNumber { get; set; }
        public Geometry HomeLocation { get; set; }
        public Geometry CurrentLocatiion { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<Rating> Rating { get; set; }
    }
}
