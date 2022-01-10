using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCustom.Models;

namespace WebAppCustom.Pages.Operations
{
    public class EditClientModel : PageModel
    {
        ApplicationContext context = new ApplicationContext();

        [BindProperty]
        public Client client { get; set; }

        [BindProperty]
        public InfoClient infoClient { get; set; }

        public static int clientID  { get; set; }
        public static int InfoID { get; set; }

        public void OnGet(int? ID)
        {

            client = context.Clients.Where(i => i.ID == ID).FirstOrDefault();
            infoClient = context.InfoClients.Where(p => p.Client_id == client.ID).FirstOrDefault();
            clientID = client.ID;
            InfoID = infoClient.ID;
            //FirstName = client.FirstName;
            //LastName = client.LastName;
            //Patronymic = client.Patronymic;
            //Email = infoClient.Email;
            //Phone = infoClient.Phone;
            //DateOfBirth = infoClient.DateOfBirth;
        }

        public void OnPostEditNameClient()
        {
            client.ID = clientID;
            infoClient.ID = InfoID;
            infoClient.Client_id = clientID;
            infoClient.Client = client;
            //infoClient.Client = client;
            context.InfoClients.Update(infoClient);
            context.Clients.Update(client);
            //context.Entry(infoClient).CurrentValues.SetValues(infoClient);
            //TEST
            context.SaveChanges();
            RedirectToPage("/Customers");
        }
    }
}
