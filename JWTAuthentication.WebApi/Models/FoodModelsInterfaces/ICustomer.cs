using System;
using System.Collections.Generic;
using JWTAuthentication.WebApi.Models.FoodModels;
using NetTopologySuite.Geometries;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface ICustomer
    {
        int Id { get; set; }
        string UserName { get; set; }
        string Gender { get; set; }
        DateTime Dob { get; set; }
        string PhoneNumber { get; set; }
        Geometry HomeLocation { get; set; }
        Geometry CurrentLocatiion { get; set; }
        ICollection<Order> Order { get; set; }
        ICollection<Rating> Rating { get; set; }
    }
}