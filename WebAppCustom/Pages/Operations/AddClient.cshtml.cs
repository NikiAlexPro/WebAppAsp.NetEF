using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCustom.Models;

namespace WebAppCustom.Pages.Operations
{
    public class AddClientModel : PageModel
    {
        ApplicationContext context = new ApplicationContext();
        //public List<Client> listClients { get; set; }
        //public List<InfoClient> infoClients { get; set; }

        [BindProperty]
        public Client? client { get; set; }

        [BindProperty]
        public InfoClient? infoClient { get; set; }

        [BindProperty]
        public ListShop? ListShops { get; set; }

        //#region Переменные
        //public int? Id { get; set; }
        //public string? FirstName { get; set; }
        //public string? LastName { get; set; }
        //public string? Patronymic { get; set; }
        //public string? Email { get; set; }
        //public string? Phone { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        //#endregion
        public void OnGet()
        {
            

            //var result = infoClients.Join(listClients,
            //    i => i.Client_id,
            //    l => l.ID,
            //    (i, l) => new { }).ToList();


        }
        //public IActionResult OnPost()
        //{
        //    return RedirectToPage("/Customers");
        //}
        public IActionResult OnPostAddNameClient()
        {
            //ListShops.DateShop = DateTime.Now;
            //ListShops.SumShop = 99999;
            //ListShops.PictureShop = new byte[Byte.MaxValue];
            //ListShops.Client_id = client.ID;
            //ListShops.Client = client;

            infoClient.Client_id = client.ID;
            infoClient.Client = client;

            context.Clients.Add(client);
            context.InfoClients.Add(infoClient);
            //context.ListShops.Add(ListShops);
            
            //context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            context.SaveChanges();
            return RedirectToPage("/Customers");
        }
    }
}
