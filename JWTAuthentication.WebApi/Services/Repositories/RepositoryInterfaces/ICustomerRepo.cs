using System.Collections.Generic;
using System.Threading.Tasks;
using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Services.Repositories.RepositoryInterfaces
{
    interface ICustomerRepo
    {
        Task<List<Restorant>> FindRestaurant();
        Task<List<Item>> FindItem();
        Task<Order> PlaceOrder();
        Task<List<Order>> ViewOrders();
        Task<string> RateRestaurant();
        Task<string> ChangeRatingForARestaurant();
        Task<string> ViewAllRatings();

        Task<string> AddToFavoriteRestaurant();

    }
}
