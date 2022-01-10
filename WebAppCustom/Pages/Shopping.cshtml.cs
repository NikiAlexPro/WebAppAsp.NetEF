using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCustom.Models;

namespace WebAppCustom.Pages
{
    public class ShoppingModel : PageModel
    {
        //public List<Client>? listClients { get; set; }                ? Modal window with detail info
        //public List<InfoClient> infoClients { get; set; }
        public List<ListShop>? shops { get; set; }
        //public IActionResult OnGet()
        //{
        //    return RedirectToPage("AddClient");
        //}

        public void OnGet()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                //listClients = context.Clients.ToList();
                shops = context.ListShops.ToList();
            }
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Operations/AddOrder");
        }

        public void OnPostDeleteOrder(int ID)
        {

            RedirectToPage("/Shopping");
        }
    }
}
