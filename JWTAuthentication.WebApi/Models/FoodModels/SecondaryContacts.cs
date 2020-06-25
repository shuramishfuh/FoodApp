using JWTAuthentication.WebApi.Models.FoodModelsInterfaces;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class SecondaryContacts : ISecondaryContacts
    {
        public int Id { get; set; }
        public int? WhatsAppNumber { get; set; }
        public int? OtherNumber { get; set; }

        public  Contact Contact { get; set; }
    }
}
