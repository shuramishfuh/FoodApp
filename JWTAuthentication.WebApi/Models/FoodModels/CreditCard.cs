namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class CreditCard : ICreditCard
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int SecurityCode { get; set; }

        public  PaymentDetails PaymentDetails { get; set; }
    }
}
