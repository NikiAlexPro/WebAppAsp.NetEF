using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using WebAppCustom.Models;

namespace WebAppCustom.Pages
{
    public class CustomersModel : PageModel
    {

        public List<Client>? listClients { get; set; }
        public List<InfoClient>? infoClients { get; set; }
        public List<ListShop>? shops { get; set; }
        
        //public List<FullClient> fullClients { get; set; }

        public void OnGet()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                listClients = context.Clients.ToList();
                //shops = context.ListShops.ToList();
                infoClients = context.InfoClients.ToList();
                
                //var result = listClients.Join(shops,
                //    c => c.ID,
                //    s => s.Client_id,
                //    (c, s) => new
                //    {
                //        FirstName = c.FirstName,
                //        LastName = c.LastName,
                //        Patronymic = c.Patronymic,
                //        DateShop = s.DateShop,
                //        SumShop = s.SumShop,
                //        PictureShop = s.PictureShop
                //    });
            }

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Operations/AddClient");
        }

        public void OnPostRowSelect(int a)
        {

        }
    }
}
