namespace WebApplication2.Models.Client
{
    public class Client
    {
        public string ClientID { get; set; } = "";
        public string ClientName { get; set; } = "";

        public List<ClientAddress> Addresses {get;set;}

        public List<ClientContacts> Contacts {get;set;}

        public Client()
        {
            Addresses = new List<ClientAddress>();
            Contacts = new List<ClientContacts>();
        }

        
    }
}
