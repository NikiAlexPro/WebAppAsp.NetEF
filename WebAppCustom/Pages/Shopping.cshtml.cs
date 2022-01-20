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
            string Ima = @"data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' fill='%23000'%3e%3cpath d='M.293.293a1 1 0 011.414 0L8 6.586 14.293.293a1 1 0 111.414 1.414L9.414 8l6.293 6.293a1 1 0 01-1.414 1.414L8 9.414l-6.293 6.293a1 1 0 01-1.414-1.414L6.586 8 .293 1.707a1 1 0 010-1.414z'/%3e%3c/svg%3e";
            ViewData["Image"] = Ima;
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
