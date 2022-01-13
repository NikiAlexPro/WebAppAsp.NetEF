using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppCustom.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public List<InfoClient> InfoClients { get; set; } = new();
        public List<ListShop> listShops { get; set; } = new();

        public bool Compare(Client client)
        {
            if (this.FirstName == client.FirstName &&
                this.LastName == client.LastName &&
                this.Patronymic == client.Patronymic)
                return true;
            else 
                return false;
        }
    }
}
