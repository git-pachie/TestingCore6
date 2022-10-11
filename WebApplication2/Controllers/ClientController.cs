using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.Client;

namespace WebApplication2.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            var ls = new List<Models.Client.Client>();
            ls.Add(new Models.Client.Client { ClientID = "CL1001", ClientName = "Robert Quizong" });
            ls.Add(new Models.Client.Client { ClientID = "CL1002", ClientName = "Wilmer De Quizong" });
            ls.Add(new Models.Client.Client { ClientID = "CL1003", ClientName = "Alexander Angeles" });
            ls.Add(new Models.Client.Client { ClientID = "CL1004", ClientName = "Tea Quizong" });
            ls.Add(new Models.Client.Client { ClientID = "CL1005", ClientName = "Jaqui Quizong" });
            ls.Add(new Models.Client.Client { ClientID = "CL1006", ClientName = "Eklabu Quizong" });

            return View(ls);
        }

        public IActionResult Update(string ClientID)
        {
            return Content($"This is client id {ClientID}");
        }
    }
}
