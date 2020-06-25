using System.Collections.Generic;
using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface IOrder
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        int Quantity { get; set; }
        string PaymentType { get; set; }
        Customer Customer { get; set; }
        ICollection<Item> Item { get; set; }
    }
}