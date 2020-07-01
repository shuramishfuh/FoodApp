using System.Collections.Generic;
using System.Threading.Tasks;
using JWTAuthentication.WebApi.Models.FoodModels;

namespace JWTAuthentication.WebApi.Services.Repositories.RepositoryInterfaces
{
    public interface IRestorantRepo
    {
        Task<RestorantUser> CreateRestaurantUser();
        Task<string> CreateRestaurant();
        Task<string> CreateRestaurantAdmin();
        Task<string> AddUserAsWorkInRestaurant();
        Task<string> DeleteRestaurant();
        Task<string> UpdateRestaurantAddress();
        Task<string> ChangeUserPaymentMethod();
        Task<List<Rating>> ViewRatingsAndReviews(); 
        Task<List<Order>> ViewOrderHistory();
        Task<string> AcceptOrDeclineOrder();
    }
}
