namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class Rating
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public int ResturantId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }

        public  Customer Customer { get; set; }
        public  Restorant Resturant { get; set; }
    }
}
