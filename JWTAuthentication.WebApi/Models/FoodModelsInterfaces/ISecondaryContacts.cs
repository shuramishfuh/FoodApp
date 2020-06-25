using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface ISecondaryContacts
    {
        int Id { get; set; }
        int? WhatsAppNumber { get; set; }
        int? OtherNumber { get; set; }
        Contact Contact { get; set; }
    }
}