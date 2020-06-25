using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface ICreditCard
    {
        int Id { get; set; }
        int Number { get; set; }
        int SecurityCode { get; set; }
        PaymentDetails PaymentDetails { get; set; }
    }
}