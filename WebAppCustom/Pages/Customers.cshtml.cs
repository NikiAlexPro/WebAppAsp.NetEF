using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using WebAppCustom.Models;

namespace WebAppCustom.Pages
{
    public class CustomersModel : PageModel
    {

        public List<Client> listClients { get; set; }
        public List<InfoClient> infoClients { get; set; }

        public List<(Client, InfoClient)> clients { get; set; }
        

        public void OnGet()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                //context.Clients.Add(new Client
                //{
                //    FirstName = "QWE",
                //    LastName = "QWE",
                //    Patronymic = "QWE"
                //});
                //context.SaveChanges();

                //listClients = context.Clients.ToList();
                //var result = infoClients.Join(listClients,
                //    i => i.Client_id,
                //    l => l.ID,
                //    (i, l) => new { }).ToList();

                //foreach(var client in listClients)
                //{
                //    infoClients = context.InfoClients.Where(x => x.Client_id == client.ID).ToList();
                //}
                /////////////////////////////////////////////////////////
                //listClients = context.Clients.ToList();
                //clients = (List<(Client, InfoClient)>)listClients.Join(infoClients,
                //    c => c.ID,
                //    i => i.Client_id,
                //    (c, i) => new { });
            }

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Operations/AddClient");

        }
    }
}
