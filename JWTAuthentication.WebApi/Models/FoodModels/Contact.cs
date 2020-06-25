namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public class Contact : IContact
    {
        public int Id { get; set; }
        public int PrimaryPhone { get; set; }
        public int? SecondaryContacts { get; set; }

        public  SecondaryContacts SecondaryContactsNavigation { get; set; }
        public  Restorant Restorant { get; set; }
    }
}
