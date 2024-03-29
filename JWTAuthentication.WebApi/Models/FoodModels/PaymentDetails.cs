﻿using JWTAuthentication.WebApi.Models.FoodModelsInterfaces;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class PaymentDetails : IPaymentDetails
    {
        public int Id { get; set; }
        public int CreditCard { get; set; }

        public  CreditCard CreditCardNavigation { get; set; }
        public  Restorant Restorant { get; set; }
    }
}
