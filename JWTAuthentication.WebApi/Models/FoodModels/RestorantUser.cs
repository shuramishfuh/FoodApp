using System;
using JWTAuthentication.WebApi.Models.FoodModelsInterfaces;

namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public  class RestorantUser : IRestorantUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public int RestorantId { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }

        public virtual Restorant Restorant { get; set; }
    }
}
