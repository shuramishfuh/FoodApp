using JWTAuthentication.WebApi.Models.FoodModelsInterfaces;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class Item : IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public double Price { get; set; }
        public int RestorantId { get; set; }
        public int? OrderId { get; set; }

        public  Order Order { get; set; }
        public  Restorant Restorant { get; set; }
    }
}
