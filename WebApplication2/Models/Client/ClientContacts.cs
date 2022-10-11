namespace WebApplication2.Models.Client
{
    public class ClientContacts
    {
        public string ClientId { get; set; }
        public string IsPrimary { get; set; }
        public string Type { get; set; }

        public string Contact { get; set; }

        public string Description { get; set; }
    }
}