using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models.ORM;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WTechCoreSample.Controllers
{
    public class WebUserController : Controller
    {
      
        public IActionResult Index()
        {
            WTechContext wTechContext = new WTechContext();

            List<WebUser> webUsers = wTechContext.WebUsers.ToList();
            return View(webUsers);
        }

        public IActionResult Detail(int id)
        {
            WTechContext wTechContext = new WTechContext();

            WebUser webUser = wTechContext.WebUsers.FirstOrDefault(q => q.Id == id);

            return View(webUser);

        }
    }
}
