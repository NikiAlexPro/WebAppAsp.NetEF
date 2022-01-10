using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCustom.Models;

namespace WebAppCustom.Pages.Operations
{
    public class AddOrderModel : PageModel
    {
        public List<ListShop>? shops { get; set; }

        //ApplicationContext context = new ApplicationContext();
        [BindProperty]
        public Client? client { get; set; }

        [BindProperty]
        public ListShop? ListShops { get; set; }

        [BindProperty]
        public InfoClient? InfoClient { get; set; }

        public List<Client>? listClients { get; set; }

        public List<InfoClient>? infoClients { get; set; }


        public void OnGet(int ID)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                infoClients = context.InfoClients.ToList();
                listClients = context.Clients.ToList();
                if (ID != 0)
                {
                    InfoClient = infoClients.FirstOrDefault(x => x.ID == ID);
                    client = listClients.FirstOrDefault(x => x.ID == InfoClient.Client_id);
                }
            }
        }
        
    }
}
