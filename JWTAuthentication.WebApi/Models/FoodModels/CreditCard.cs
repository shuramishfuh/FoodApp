namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class CreditCard
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public byte SecurityCode { get; set; }

        public virtual PaymentDetails PaymentDetails { get; set; }
    }
}
