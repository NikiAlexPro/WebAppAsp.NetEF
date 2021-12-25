using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCustom.Models;

namespace WebAppCustom.Pages.Operations
{
    public class EditClientModel : PageModel
    {
        ApplicationContext context = new ApplicationContext();
        FullClient fullClient = new FullClient();
        [BindProperty]
        public Client client { get; set; }
        
        //[BindProperty]
        //public InfoClient infoClient { get; set; }

        public void OnGet(int? ID)
        {

            client = context.Clients.Where(i => i.ID == ID).FirstOrDefault();
            //infoClient = context.InfoClients.Where(p => p.Client_id == client.ID).FirstOrDefault();
            
            //FirstName = client.FirstName;
            //LastName = client.LastName;
            //Patronymic = client.Patronymic;
            //Email = infoClient.Email;
            //Phone = infoClient.Phone;
            //DateOfBirth = infoClient.DateOfBirth;
        }

        public void OnPostEditNameClient()
        {
            
        }
    }
}
