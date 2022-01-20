using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCustom.Models;
using System.Dynamic;

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
            using (ApplicationContext context = new ApplicationContext())
            {
                shops = context.ListShops.ToList();
                context.ListShops.Remove(shops.FirstOrDefault(x => x.ID==ID));
                context.SaveChanges();
            }
            Response.Redirect("/Shopping");
        }
    }
}
