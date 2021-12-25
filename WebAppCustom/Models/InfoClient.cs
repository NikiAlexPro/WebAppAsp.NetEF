using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppCustom.Models
{
    public class InfoClient
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Client_id { get; set; }

        [ForeignKey("Client_id")]
        public Client Client { get; set; }
    }
}
