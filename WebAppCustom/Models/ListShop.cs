using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppCustom.Models
{
    public class ListShop
    {
        public int ID { get; set; }
        public DateTime DateShop { get; set; }
        public decimal SumShop { get; set; }
        public Byte[] PictureShop { get; set; }
        public int Client_id { get; set; }
        
        [ForeignKey("Client_id")]
        public Client Client { get; set; }
    }
}
