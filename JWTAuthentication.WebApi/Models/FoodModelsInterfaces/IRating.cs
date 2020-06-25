using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Models.FoodModelsInterfaces
{
    public interface IRating
    {
        int Id { get; set; }
        double Score { get; set; }
        int ResturantId { get; set; }
        int CustomerId { get; set; }
        string Comment { get; set; }
        Customer Customer { get; set; }
        Restorant Resturant { get; set; }
    }
}