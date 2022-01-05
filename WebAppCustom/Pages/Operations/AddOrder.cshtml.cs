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
        public ListShop ListShops { get; set; }

        public List<Client>? listClients { get; set; }

        public List<InfoClient>? infoClients { get; set; }


        public void OnGet()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                //listClients = context.Clients.ToList();
                infoClients = context.InfoClients.ToList();
                listClients = context.Clients.ToList();
            }
        }

        //public IActionResult 
    }
}
