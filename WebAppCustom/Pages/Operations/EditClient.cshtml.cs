using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCustom.Models;

namespace WebAppCustom.Pages.Operations
{
    public class EditClientModel : PageModel
    {
        ApplicationContext context = new ApplicationContext();

        public static Client SearchClient { get; set; }

        [BindProperty]
        public Client? client { get; set; }

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
            SearchClient = context.Clients.Where(i => i.ID == ID).FirstOrDefault();
            //FirstName = client.FirstName;
            //LastName = client.LastName;
            //Patronymic = client.Patronymic;
            //Email = infoClient.Email;
            //Phone = infoClient.Phone;
            //DateOfBirth = infoClient.DateOfBirth;
        }

        public void OnPostEditNameClient()
        {
            if(client.Compare(SearchClient)) //Если имена одинаковые
            {
                client.ID = clientID;
                infoClient.ID = InfoID;
                infoClient.Client_id = clientID;
                infoClient.Client = client;
                //infoClient.Client = client;
                context.InfoClients.Update(infoClient);
                context.Clients.Update(client);
            }
            else
            {
                context.Clients.Add(client);
                context.SaveChanges();
                client = context.Clients.FirstOrDefault(c => c.FirstName == client.FirstName &&
                                                                           c.LastName == client.LastName &&
                                                                           c.Patronymic == client.Patronymic);
                //infoClient.ID = InfoID;
                infoClient.Client_id = client.ID;
                infoClient.Client = client;
                
                
                context.InfoClients.Add(infoClient);
                //SearchClient.
            }    
                

            context.SaveChanges();
            Response.Redirect("/Customers");
        }
    }
}
