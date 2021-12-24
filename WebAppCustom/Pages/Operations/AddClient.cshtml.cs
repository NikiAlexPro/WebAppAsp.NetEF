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
        public InfoClient infoClient { get; set; }

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
            //infoClient.Client = client;
            context.Clients.Add(client);//company        (list users)
            context.InfoClients.Add(infoClient);//user   (one company)
            context.SaveChanges();
            return RedirectToPage("/Customers");
        }
    }
}
