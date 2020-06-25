using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface IContact
    {
        int Id { get; set; }
        int PrimaryPhone { get; set; }
        int? SecondaryContacts { get; set; }
        SecondaryContacts SecondaryContactsNavigation { get; set; }
        Restorant Restorant { get; set; }
    }
}