using System.Collections.Generic;
using JWTAuthentication.WebApi.Models.FoodModelsInterfaces;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class Order : IOrder
    {
        public Order()
        {
            Item = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public string PaymentType { get; set; }

        public  Customer Customer { get; set; }
        public  ICollection<Item> Item { get; set; }
    }
}
