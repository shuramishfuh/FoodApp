using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface IPaymentDetails
    {
        int Id { get; set; }
        int CreditCard { get; set; }
        CreditCard CreditCardNavigation { get; set; }
        Restorant Restorant { get; set; }
    }
}