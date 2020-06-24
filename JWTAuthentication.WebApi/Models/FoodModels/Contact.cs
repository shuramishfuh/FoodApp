namespace JWTAuthentication.WebApi.Models.FoodModels
{
    public class Contact
    {
        public byte Id { get; set; }
        public int PrimaryPhone { get; set; }
        public byte? SecondaryContacts { get; set; }

        public virtual SecondaryContacts SecondaryContactsNavigation { get; set; }
        public virtual Restorant Restorant { get; set; }
    }
}
