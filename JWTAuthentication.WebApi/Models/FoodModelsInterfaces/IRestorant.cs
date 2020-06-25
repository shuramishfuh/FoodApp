using System.Collections.Generic;
using JWTAuthentication.WebApi.Models.FoodModels;
using NetTopologySuite.Geometries;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface IRestorant
    {
        int Id { get; set; }
        string Name { get; set; }
        int OperatingTimeId { get; set; }
        Geometry Location { get; set; }
        double Rating { get; set; }
        int ContactId { get; set; }
        int PaymentDetailsId { get; set; }
        Contact Contact { get; set; }
        OperatingTime OperatingTime { get; set; }
        PaymentDetails PaymentDetails { get; set; }
        ICollection<Item> Item { get; set; }
        ICollection<Rating> RatingNavigation { get; set; }
        ICollection<RestorantUser> Users { get; set; }
    }
}