using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCustom.Models;
using Microsoft.Extensions.Hosting;
using System.Drawing;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace WebAppCustom.Pages.Operations
{
    public class AddOrderModel : PageModel
    {
        private IHostingEnvironment hostingEnvironment { get; set; }
        
        public List<ListShop>? shops { get; set; }

        //ApplicationContext context = new ApplicationContext();
        [BindProperty]
        public Client? client { get; set; }

        [BindProperty]
        public ListShop? ListShops { get; set; }

        [BindProperty]
        public InfoClient? InfoClient { get; set; }

        [BindProperty]
        public IFormFile? FormFile { get; set; }//Content type
        //[BindProperty]
        //public IFormFile? formFile { get; set; }

        public List<Client>? listClients { get; set; }

        public List<InfoClient>? infoClients { get; set; }

        public static byte[] dataImage;

        
        public void OnGet(int ID)
        {
            ApplicationContext context = new ApplicationContext();
            
                infoClients = context.InfoClients.ToList();
                listClients = context.Clients.ToList();
                if (ID != 0)
                {
                    InfoClient = infoClients.FirstOrDefault(x => x.ID == ID);
                    client = listClients.FirstOrDefault(x => x.ID == InfoClient.Client_id);
                }
            //context.Dispose();
            
        }

        public void OnPostAddOrder()
        {
            
            using (ApplicationContext context = new ApplicationContext())
            {
                //ѕроверка форматов изображений
                Image image = new Bitmap(@"C:\Users\NikAlex\Desktop\тест.jpg");
                using (MemoryStream fs = new MemoryStream())
                {
                    image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    dataImage = fs.ToArray();
                }
                
                
                //DETAIL
                ListShops.Client = client;
                ListShops.PictureShop = dataImage;///DELETE
                context.ListShops.Add(ListShops);
                context.SaveChanges();
            }
            Response.Redirect("/Shopping");
        }

    }
}
