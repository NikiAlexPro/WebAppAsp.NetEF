namespace WebAppCustom.Models
{
    public class ListShop
    {
        public int ID { get; set; }
        public DateTime DateShop { get; set; }
        public decimal SumShop { get; set; }
        public Byte[] PictureShop { get; set; }
        //public IEnumerable<Client> Clients;
        public int Client_id { get; set; }
        //public Client Client { get; set; }
    }
}
