using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface IItem
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        byte[] Picture { get; set; }
        double Price { get; set; }
        int RestorantId { get; set; }
        int? OrderId { get; set; }
        Order Order { get; set; }
        Restorant Restorant { get; set; }
    }
}