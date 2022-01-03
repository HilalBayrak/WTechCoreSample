using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models.ORM;
using WTechCoreSample.Models.VM;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WTechCoreSample.Controllers
{
    public class AdminWebUserController : Controller
    {

        WTechContext wTechContext;

        public AdminWebUserController()
        {
            wTechContext = new WTechContext();
        }

        public IActionResult Index()
        {
            List<WebUserVM> model = wTechContext.WebUsers.Select(q => new WebUserVM()
            {
                Id = q.Id,
                Name = q.Name,
                SurName = q.SurName,
                City = q.City,
                Country = q.Country,
                EMail = q.EMail,
                Address = q.Address

            }).ToList();

            return View(model);
        }


        public IActionResult AddWebUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWebUser(WebUserVM model)
        {
            if (ModelState.IsValid)
            {
                WebUser webUser = new WebUser();

                webUser.Name = model.Name;
                webUser.SurName = model.SurName;
                webUser.City = model.City;
                webUser.Country = model.Country;
                webUser.EMail = model.EMail;
                webUser.Address = model.Address;
                webUser.RoleId = 1;

                wTechContext.WebUsers.Add(webUser);
                wTechContext.SaveChanges();
            }



            return View();
        }

    }
}
